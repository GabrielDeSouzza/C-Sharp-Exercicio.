using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_calcu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            resu.Text = Convert.ToString(num1 + num2);
        }

        private void sub_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            resu.Text = Convert.ToString(num1 - num2);

        }

        private void division_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            resu.Text = Convert.ToString(num1 / num2);
        }

        private void multi_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            resu.Text = Convert.ToString(num1 * num2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Genshin Impact/launcher.exe");
        }
    }
}
