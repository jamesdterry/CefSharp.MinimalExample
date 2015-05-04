using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class ConfigForm : Form
    {
        public BrowserForm browserForm;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            System.Windows.Forms.Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            browserForm = new BrowserForm();
            browserForm.Show();
        }
    }
}
