using System;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)this.Owner;

            try
            {
                switch (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text)
                {
                    case "Круг":
                        double.TryParse(textBox1.Text, out double r);
                        frm.AddToAll(new Circle(r));
                        break;
                    case "Треугольник":
                        double.TryParse(textBox1.Text, out double a);
                        double.TryParse(textBox2.Text, out double b);
                        double.TryParse(textBox3.Text, out double c);
                        frm.AddToAll(new Triangle(a, b, c));
                        break;
                    case "Прямоугольник":
                        double.TryParse(textBox1.Text, out double f);
                        double.TryParse(textBox2.Text, out double g);
                        frm.AddToAll(new Model.Rectangle(f, g));
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

    
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label1.Text = "Радиус";

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text = "а";
            label2.Text = "b";
            label3.Text = "c";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox3.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label1.Text = "a";
            label2.Text = "b";
        }
    }
}
