using NetRemoting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRemoting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        xx obj = new xx();
        private void button1_Click(object sender, EventArgs e)
        {
            obj = (xx)Activator.GetObject(typeof(xx),
                          "tcp://localhost:8085/ehsan");
            int x = Int32.Parse(textBox1.Text);
            int y = Int32.Parse(textBox2.Text);
            textBox3.Text = (obj.sum(x, y)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = (xx)Activator.GetObject(typeof(xx),
              "tcp://localhost:8085/ehsan");

            MessageBox.Show(obj.hello(textBox4.Text));
        }
    }
}
