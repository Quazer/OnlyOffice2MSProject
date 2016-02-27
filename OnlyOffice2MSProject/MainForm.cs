using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quazisoft.Common;
using System.Security.Cryptography;
using System.Configuration;
using System.Collections.Specialized;
using System.Security.Principal;
using System.Security;
using System.Net.Http;
using System.Net;
using System.Xml.Linq;
using System.Xml.XPath;
using MSProject = Microsoft.Office.Interop.MSProject;

namespace OnlyOffice2MSProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SLog.AttachControl(ref lvLog);
            SLog.Append("Init");
            LoadSettings();

        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var address = tbAddress.Text.Trim();
            var userName = tbUserName.Text.Trim();
            var password = tbPassword.Text.Trim();

            Properties.Settings.Default["Address"] = address;
            Properties.Settings.Default["UserName"] = userName;
            Properties.Settings.Default["Password"] = JonGallowaySecuriyString.EncryptString(JonGallowaySecuriyString.ToSecureString(password));

            using (var client = new WebClient())
            {
                var protocol = "http";
                var urlprefix = $"{protocol}://{address}/api/2.0/";

                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers["Accept"] = "text/xml";
                client.Headers["Content-type"] = "application/x-www-form-urlencoded";

                string res = "";
                string token;
                XDocument xdoc;
                try
                {
                    res = client.UploadString(urlprefix + "authentication.xml", $"userName={userName}&password={password}");
                    xdoc = XDocument.Parse(res);
                    token = xdoc.XPathSelectElement("//token").Value;
                }
                catch (WebException ex)
                {
                    SLog.Append(SLog.Type.Error, ex.Message);
                    return;
                }
                catch (XmlSyntaxException ex)
                {
                    SLog.Append(SLog.Type.Error, ex.Message);
                    return;
                }

                SLog.Append($"Token: {token}");

                client.Headers["Authorization"] = token;
                res = client.DownloadString($"{urlprefix}project/@self.xml");
                xdoc = XDocument.Parse(res);

                var selectProject = new SelectProject()
                {
                    Projects =
                        xdoc.XPathSelectElements("//response")
                            .ToDictionary(node => node.XPathSelectElement("./id").Value,
                                node => node.XPathSelectElement("./title").Value)
                };

                if (selectProject.ShowDialog() != DialogResult.OK) { SLog.Append(SLog.Type.Warning, "User cancel"); return; }
                var projectId = selectProject.SelectedProjectId;
                SLog.Append($"ProjectID: {projectId}");

                res = client.DownloadString($"{urlprefix}project/{projectId}/task.xml");
                xdoc = XDocument.Parse(res);

                // Resource list
                var persons = new Dictionary<string, string>();
                foreach (var xperson in xdoc.XPathSelectElements("/result/response/responsibles"))
                {
                    var id = xperson.XPathSelectElement("id").Value;
                    if (persons.ContainsKey(id)) continue;
                    var displayName = xperson.XPathSelectElement("displayName").Value;
                    persons[id] = displayName;
                }

                // Task list
                var msapp = new MSProject.Application { Visible = true };
                var msproject = msapp.Projects.Add();
                foreach (var person in persons)
                {
                    var msresource = msproject.Resources.Add(person.Value);
                    msresource.Code = person.Key;
                    msresource.EnterpriseText40 = person.Key;
                }

                foreach (var xtask in xdoc.XPathSelectElements("/result/response"))
                {
                    var title = xtask.XPathSelectElement("title").Value;
                    var mstask = msproject.Tasks.Add(title);
                    mstask.EnterpriseText40 = xtask.XPathSelectElement("id").Value;
                    var xresource = xtask.XPathSelectElement("responsibles");
                    if (xresource != null)
                    {
                        mstask.ResourceNames = xresource.XPathSelectElement("displayName").Value;
                    }
                    var xstart = xtask.XPathSelectElement("startDate");
                    if (xstart != null)
                    {
                        mstask.Start = DateTime.Parse(xstart.Value);
                    }
                    var xfinish = xtask.XPathSelectElement("deadline");
                    if (xfinish != null)
                    {
                        mstask.Finish = DateTime.Parse(xfinish.Value);
                    }
                    var xnotes = xtask.XPathSelectElement("description");
                    if (xnotes != null)
                    {
                        mstask.Notes = xnotes.Value;
                    }
                }
            }
            SaveSettings();
        }

        public void LoadSettings()
        {
            tbAddress.Text = Properties.Settings.Default.Address;
            tbUserName.Text = Properties.Settings.Default.UserName;
            try
            {
                tbPassword.Text = JonGallowaySecuriyString.ToInsecureString(JonGallowaySecuriyString.DecryptString(Properties.Settings.Default.Password));
            }
            catch (CryptographicException ex)
            {
                tbPassword.Text = "";
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

    }
}
