using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Resources;

namespace FloatingPerformanceMonitor
{
    public partial class version : Form
    {
        string app_version = Application.ProductVersion;
        string appProductName = Application.ProductName;
        string appCompanyName = Application.CompanyName; 


        public version()
        {
            InitializeComponent();
            App_name.Text = appProductName;
            Version_number.Text = app_version;
        }

        private void my_twitter_URL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            my_twitter_URL.LinkVisited = true;
            System.Diagnostics.Process.Start("http://twitter.com/highsokujin");
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
