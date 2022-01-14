using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)this.Owner;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string name = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

                frm.FindFigures(name, double.Parse(textBox1.Text), double.Parse(textBox2.Text));

                this.Close();
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}
