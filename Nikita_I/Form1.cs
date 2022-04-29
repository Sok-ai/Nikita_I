using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikita_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double mat = 0;
            double x1;
            double x2;

            if ((!double.TryParse(textBox1.Text, out x1)) || (!double.TryParse(textBox2.Text, out x2)))
            {
                label3.Text = "Eror";
                return;
            }

            else
            {
                switch (label2.Text)
                {
                    case "+":
                        mat = x1 + x2;
                        break;

                    case "-":
                        mat = x1 - x2;
                        break;

                    case "/":
                        mat = x1 / x2; break;

                    case "*":
                        mat = x1 * x2;
                        break;

                    case "^":
                        mat = Math.Pow(x1, x2);
                        break;

                    case "%":
                        mat = mat = x1 % x2;
                        break;
                }
            }
            label3.Text = "=" + mat;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = (sender as Button).Text;
            label3.Text = "=";
        }
    }
}
