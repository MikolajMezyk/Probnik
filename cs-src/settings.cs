using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTP
{
    public partial class settings : Form
    {
        public Form1 form1;
        public settings()
        {
            InitializeComponent();
        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.ApplySettings(serverAdressSMTP.Text, (int)portBox.Value, mailAdress.Text, passBox.Text, mailToAdress.Text,checkBox1.Checked);
        }
    }
}
