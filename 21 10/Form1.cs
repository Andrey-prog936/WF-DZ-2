using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_10
{
    public partial class Form1 : Form
    {
        int count = 0;
        int ric = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    price += Convert.ToDouble(rb.Tag);
                }
            }
            foreach (RadioButton rb in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    price += Convert.ToDouble(rb.Tag);
                }
            }
            foreach (RadioButton rb in groupBox3.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    price += Convert.ToDouble(rb.Tag);
                }
            }
            textBox1.Text += $"№{++count} Price: {price} - Date: {DateTime.Now.ToShortDateString()}\r\n";
            label15.Text = price.ToString();
        }

    }
}
