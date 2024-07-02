using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private bool check()
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
                return true;

            else
                return false;
        }


        private void error()
        {
            MessageBox.Show("Введите m и n", "Ошибка");
        }


        // Список2
        private void ToolStripMenuItem1_2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                dataGridView1.Visible = false;
                chart1.Visible = false;

                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 2;
                double b = 3;
                double h = 0.2;



                listBox1.DataSource = null;
                listBox1.Items.Clear();

                double x, y;

                int k = (int)((b - a) / h + 1);

                string[] s = new string[k];

                x = a;

                for (int i = 0; i < k; i++)
                {
                    y = Math.Pow(2, m * x / (n * Math.Log(x)));
                    y = Math.Round(y, 3);

                    s[i] = "y(" + x.ToString() + ") = " + y.ToString();

                    x += h;
                }

                listBox1.DataSource = s;
                listBox1.Visible = true;

            }





            else
                error();
        }

        // Диаграмма1
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                listBox1.Visible = false;
                dataGridView1.Visible = false;

                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 2;
                double b = 3;
                double h = 0.2;

                double x, y;

                chart1.Series.Clear();


                x = a;

                double N = (int)((b - a) / h + 1);


                for (int k = 0; k < N; k++)
                {

                    y = Math.Pow(2, m * x / (n * Math.Log(x)));
                    y = Math.Round(y, 3);

                    chart1.Series.Add("y(" + x.ToString() + ")");
                    chart1.Series[k].Points.AddY(y);

                    x += h;

                }

                chart1.DataBind();
                chart1.Visible = true;

            }

            else
                error();
        }

        // Диаграмма2
        private void ToolStripMenuItem2_2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                listBox1.Visible = false;
                dataGridView1.Visible = false;

                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 1;
                double b = 3;
                double h = 0.2;

                double x, y;

                chart1.Series.Clear();


                x = a;

                double N = (int)((b - a) / h + 1);


                for (int k = 0; k < N; k++)
                {

                    y = Math.Pow(3, x / (m + Math.Log(x))) + m / n;
                    y = Math.Round(y, 3);

                    chart1.Series.Add("y(" + x.ToString() + ")");
                    chart1.Series[k].Points.AddY(y);

                    x += h;

                }

                chart1.DataBind();
                chart1.Visible = true;

            }

            else
                error();
        }
        
        //Список1
        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                dataGridView1.Visible = false;
                chart1.Visible = false;


                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 1;
                double b = 3.1;
                double h = 0.2;



                listBox1.DataSource = null;
                listBox1.Items.Clear();

                double x, y;
                string s;


                for (x = a; x <= b; x += h)
                {
                    y = Math.Pow(3, x / (m + Math.Log(x))) + m / n;
                    y = Math.Round(y, 3);
                    s = "y(" + x.ToString() + ") = " + y.ToString();
                    listBox1.Items.Add(s);

                }

                listBox1.Visible = true;
            }

            else
                error();
        }

        //Таблица1
        private void ToolStripMenuItem3_1_Click(object sender, EventArgs e)
        {
            if (check())
            {


                listBox1.Visible = false;
                chart1.Visible = false;

                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 0;
                double b = 1;
                double h = 0.2;
                double c = 2;
                double d = 3;
                double l = 0.2;


                double x, y, z;



                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("", "x / y");



                for (y = c; y <= d; y += l)
                {
                    dataGridView1.Columns.Add("", y.ToString());
                }

                for (x = a; x <= b; x += h)
                {
                    dataGridView1.Rows.Add(x.ToString());
                }



                int row = 0;

                for (x = a; x <= b; x += h)
                {
                    int cell = 1;
                    for (y = c; y <= d; y += l)
                    {
                        z = (m * m * Math.Exp(-x) - n * Math.Exp(-y * 2)) / (x * x + y * y);
                        z = Math.Round(z, 2);

                        dataGridView1.Rows[row].Cells[cell].Value = z;
                        cell++;
                    }

                    row++;
                }

                dataGridView1.Visible = true;
            }

            else
                error();
        }

        //Таблица2
        private void ToolStripMenuItem3_2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                listBox1.Visible = false;
                chart1.Visible = false;

                double m = Convert.ToDouble(comboBox1.Text);
                double n = Convert.ToDouble(comboBox2.Text);
                double a = 1;
                double b = 3;
                double h = 0.5;
                double c = 2;
                double d = 3;
                double l = 0.2;
                double x, y, z;


                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("", "x / y");

                for (y = c; y <= d; y += l)
                    dataGridView1.Columns.Add("", y.ToString());

                for (x = a; x <= b; x += h)
                    dataGridView1.Rows.Add(x.ToString());



                int row = 0;

                for (x = a; x <= b; x += h)
                {
                    int cell = 1;
                    for (y = c; y <= d; y += l)
                    {
                        z = Math.Log(Math.Abs(x + y * y - m)) / (n * Math.Sqrt(m) * (x * x + Math.Sqrt(y)));
                        z = Math.Round(z, 5);

                        dataGridView1.Rows[row].Cells[cell].Value = z;
                        cell++;
                    }

                    row++;
                }

                dataGridView1.Visible = true;
            }


            else
                error();
        }

        //Файл2
        private void ToolStripMenuItem4_2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            chart1.Visible = false;
            listBox1.Visible = false;

            openFileDialog1.ShowDialog();
            string[] s = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);

            string f = "";

            string z;

            for (int i = 0; i < 5; i++)
            {
                z = s[i];
                string[] y = z.Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    double x = Convert.ToDouble(y[j]);

                    if (x > 0)
                    {
                        f += x.ToString() + " ";
                    }
                }
            }

            saveFileDialog1.ShowDialog();

            File.WriteAllText(saveFileDialog1.FileName, f.ToString(), Encoding.Default);
        }

        //Файл1
        private void ToolStripMenuItem4_1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            chart1.Visible = false;
            listBox1.Visible = false;

            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();

            StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);





            string s;
            double Sum = 0;
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();

                    string[] x = s.Split(' ');

                    for (int i = 0; i < 5; i++)
                    {
                        double y = Convert.ToDouble(x[i]);

                       if (y < 0) 
                            Sum += y;
                    }
                }
                sw.WriteLine(Sum.ToString());
            }
        }

        //Очистка
        private void очисткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            chart1.Visible = false;
            listBox1.Visible = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}


