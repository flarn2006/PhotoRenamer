using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoRenamer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void openLinkLabelAsURL(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as Control).Tag as string;
            System.Diagnostics.Process.Start(url);
        }
    }
}
