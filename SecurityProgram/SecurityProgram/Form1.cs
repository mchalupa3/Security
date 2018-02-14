using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTurnOnFirewall_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C NetSh Advfirewall set allprofiles state on";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btnTurnOnDefender_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C sc start WinDefend";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btnAutomateDefender_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C sc config WinDefend start= auto";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
