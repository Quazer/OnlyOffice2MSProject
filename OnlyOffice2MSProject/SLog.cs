using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quazisoft.Common
{
    /// <summary>
    /// Simple log for listview
    /// </summary>
    public class SLog
    {
        /// <summary>
        /// ListView control
        /// </summary>
        private static ListView _listView;

        /// <summary>
        /// Log record types
        /// </summary>
        public enum Type { Information, Warning, Error };

        /// <summary>
        /// Constuctor
        /// </summary>
        public static void AttachControl(ref ListView lvLog)
        {
            _listView = lvLog;
        }

        /// <summary>
        /// New log record
        /// </summary>
        public static void Append(string text)
        {
            Append(Type.Information, text);
        }

        /// <summary>
        /// New log record
        /// </summary>
        public static ListViewItem Append(Type type, string text)
        {
            var dt = DateTime.Now;
            var logNode = new string[4];
            logNode[0] = dt.ToShortDateString() + " " + dt.ToShortTimeString();
            logNode[1] = text;
            var lvItem = new ListViewItem(logNode);
            switch (type)
            {
                case Type.Information:
                    lvItem.SubItems[1].ForeColor = Color.Green;
                    break;
                case Type.Error:
                    lvItem.SubItems[1].BackColor = Color.Red;
                    break;
                case Type.Warning:
                    lvItem.SubItems[1].BackColor = Color.Blue;
                    break;
                default:
                    lvItem.SubItems[0].BackColor = Color.Black;
                    break;
            }
            var lvNew = _listView.Items.Insert(0, lvItem);
            lvNew.Selected = true;
            Application.DoEvents();
            _listView.Refresh();
            return lvItem;
        }
    }
}
