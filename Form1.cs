using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void loop()
        {
            int count = 0;
            for (int i = 0; i < 10000; i++)
            {
                count = count + 1;
                count = count + 2;
            }
        }

        private int sum(int a, int b)
        {
            return a + b;
        }

        private void Loop()
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loop();
            rdpCtl.Server = textBox1.Text;
            rdpCtl.UserName = textBox2.Text;
            MSTSCLib.IMsTscNonScriptable mstscScript = (MSTSCLib.IMsTscNonScriptable)rdpCtl.GetOcx();
            mstscScript.ClearTextPassword = textBox3.Text;
            rdpCtl.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdpCtl.Connected.ToString() == "1")
            rdpCtl.Disconnect();
        }

        
    }
}
