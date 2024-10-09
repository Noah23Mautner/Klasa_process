using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasa_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo("excel.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Process.Start("winword.exe");
            ProcessStartInfo startInfo1 = new ProcessStartInfo("winword.exe");
            startInfo1.WindowStyle = ProcessWindowStyle.Normal;
            startInfo1.Arguments = "www.sser.hr";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
            ProcessStartInfo startInfo2 = new ProcessStartInfo("iexplore.exe");
            startInfo2.WindowStyle = ProcessWindowStyle.Normal;
            startInfo2.Arguments = "www.sser.hr";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
            ProcessStartInfo startInfo3 = new ProcessStartInfo("notepad.exe");
            startInfo3.WindowStyle = ProcessWindowStyle.Normal;
            startInfo3.Arguments = "www.sser.hr";
        }
    }
}
