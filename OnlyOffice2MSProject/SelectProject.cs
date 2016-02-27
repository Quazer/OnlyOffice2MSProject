using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyOffice2MSProject
{
    public partial class SelectProject : Form
    {
        public SelectProject()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> Projects;
        public string SelectedProjectId;

        private void SelectProject_Load(object sender, EventArgs e)
        {
            lvProjects.Items.Clear();
            // TODO convert to Items.AddRange(...)
            lvProjects.Items.AddRange(Projects.Select(item => (string) item.Value).ToArray());
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            SelectedProjectId = Projects.Keys.ToList()[lvProjects.SelectedIndex];
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
