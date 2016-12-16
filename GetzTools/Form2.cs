using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetzTools
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string result = "";
        private async void button1_Click(object sender, EventArgs e)
        {
            result = "";
            textBox1.Text = "You can move this form. \r\n";
            result = await WaitAsynchronouslyAsync();

            textBox1.Text += "\r\n\r\n" + result;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            result = "";
            textBox1.Text = "You cannot move this form. \r\n";
            result = await WaitSynchronously();

            textBox1.Text += "\r\n\r\n" + result;
        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(10000);
            return "\r\n-- Finish Asycn";
        }

        public async Task<string> WaitSynchronously()
        {
            Thread.Sleep(2000);
            return "\r\n-- Finished Synchronous --";
        }
    }
}
