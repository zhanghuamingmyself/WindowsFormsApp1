using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.dto.res;

namespace WindowsFormsApp1
{
    public partial class Form1 : AntdUI.Window
    {

        Test test;
        public Form1()
        {
            InitializeComponent();
            test = new Test();
            test.refreshToken("admin", "admin123");
            this.input1.Text = "24367029320240308";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetDeviceResponse res = test.getDevice(this.input1.Text);
            this.label1.Text = res.imei;
        }
    }
}
