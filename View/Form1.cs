using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Form1 : Form
    {
        public IList<IFigure> Figures = new List<IFigure>();

        public Form1()
        {
            InitializeComponent();
        }

        public void AddToAll(IFigure figure)
        {
            Figures.Add(figure);
            dataGridView1.Rows.Add(figure.Name, figure.Square);
        }

        public void FindFigures(string name, double from, double to)
        {
            dataGridView1.Rows.Clear();

            foreach (var figures in Figures.Where(z => z.Name == name && z.Square >= from && z.Square <= to).ToList())
            {
                dataGridView1.Rows.Add(figures.Name, figures.Square);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add addFrm = new Add();
            addFrm.Text = "Добавить";
            addFrm.Owner = this;
            addFrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.Cells[0].Value == null) return;

            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(index);
            Figures.RemoveAt(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            switch (rnd.Next(1, 4))
            {
                case 1:
                    double r = rnd.NextDouble()*10;
                    AddToAll(new Circle(r));
                    break;
                case 2:
                    double a = rnd.NextDouble() * 10;
                    double b = rnd.NextDouble() * 10;
                    double c = GetRandomNumber(a, b);

                    AddToAll(new Triangle(a, b, c));
                    break;
                case 3:
                    double d = rnd.NextDouble() * 10;
                    double f = rnd.NextDouble() * 10;
                    AddToAll(new Model.Rectangle(d, f));
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

                FileStream file = File.Create(saveFileDialog1.FileName);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, Figures);
                file.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                FileStream file = File.OpenRead(openFileDialog1.FileName);
                BinaryFormatter formatter = new BinaryFormatter();
                Figures.Clear();
                dataGridView1.Rows.Clear();
                if (Figures != null)
                {
                    foreach (var figure in (IList<IFigure>)formatter.Deserialize(file))
                    {
                        AddToAll(figure);
                    }
                }
                file.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search searchFrm = new Search();
            searchFrm.Text = "Добавить";
            searchFrm.Owner = this;
            searchFrm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var figure in Figures)
            {
                dataGridView1.Rows.Add(figure.Name, figure.Square);
            }
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

    }
}
