namespace Win_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool proverka()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(proverka())
            {
                double m = Convert.ToDouble(textBox1.Text);
                double n = Convert.ToDouble(textBox2.Text);

                double x = (Math.Sqrt(m) + 1.27) / Math.Log(n + m);
                double y = 0.8 * Math.Exp(0.1 * m);
                double c = y + 3.2 * Math.Sin(x * y + 1.8) + Math.Sqrt(Math.Abs(x - Math.Log(2.6 + x)));

                x = Math.Round(x, 3);
                y = Math.Round(y, 3);
                c = Math.Round(c, 3); 

                textBox3.Text = x.ToString();
                textBox4.Text = y.ToString();
                textBox5.Text = c.ToString();

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                label3.Text = "x = ";
                label4.Text = "y = ";
                label5.Text = "c = ";




            }
            else
            {
                MessageBox.Show("Введите m и n", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(proverka())
            {
                double m = Convert.ToDouble(textBox1.Text);
                double n = Convert.ToDouble(textBox2.Text);

                double u = Math.Atan(Math.Log(n));
                double v = Math.Exp(Math.Cos(m));
                double w = Math.Pow(Math.Abs(Math.Sin(u * u - v) * Math.Sin(u * u - v) - Math.Cos(v * v - 1.71)), 1.0 / 3.0);
                Console.WriteLine("Ответ: u={0}, v={1},w={2}", u, v, w);

                u = Math.Round(u, 3);
                v = Math.Round(v, 3);
                w = Math.Round(w, 3);

                textBox3.Text = u.ToString();
                textBox4.Text = v.ToString();
                textBox5.Text = w.ToString();

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                label3.Text = "u = ";
                label4.Text = "v = ";
                label5.Text = "w = ";
            }
            else
            {
                MessageBox.Show("Введите m и n", "Ошибка");
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(proverka())
            {
                if(checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("Выберите только один вариант", "Ошибка");
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
                else if (checkBox1.Checked)
                {
                    double m = Convert.ToDouble(textBox1.Text);
                    double n = Convert.ToDouble(textBox2.Text);

                    double x = Math.Exp(m / n);
                    double y = Math.Cos(m / Math.Sqrt(n));
                    double u;

                    if (x + y < x * y)
                        u = x + y;
                    else if (x + y > x * y)
                        u = x * y;
                    else
                        u = 1;


                    x = Math.Round(x, 3);
                    y = Math.Round(y, 3);
                    u = Math.Round(u, 3);

                    textBox3.Text = x.ToString();
                    textBox4.Text = y.ToString();
                    textBox5.Text = u.ToString();

                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;

                    label3.Text = "x = ";
                    label4.Text = "y = ";
                    label5.Text = "u = ";

                }
                else if(checkBox2.Checked)
                {
                    double m = Convert.ToDouble(textBox1.Text);
                    double n = Convert.ToDouble(textBox2.Text);

                    double a = Math.Cos(n);
                    double b = Math.Tan(m);
                    double z;
                    if (a > 0 && b > 1)
                        z = Math.Sin(a * a - b * b);
                    else
                        z = Math.Cos(a + b);


                    a = Math.Round(a, 3);
                    b = Math.Round(b, 3);
                    z = Math.Round(z, 3);

                    textBox3.Text = a.ToString();
                    textBox4.Text = b.ToString();
                    textBox5.Text = z.ToString();

                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;

                    label3.Text = "a = ";
                    label4.Text = "b = ";
                    label5.Text = "z = ";
                }
                else
                {
                    MessageBox.Show("Выберите функцию", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Введите m и n", "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(proverka())
            {
                if(!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Выберите вариант", "Ошибка");
                }
                else if(radioButton1.Checked)
                {
                    double m = Convert.ToDouble(textBox1.Text);
                    double n = Convert.ToDouble(textBox2.Text);

                    double s = 0;

                    for (int k = 1; k <= 15; k++)
                        s += Math.Pow(-1, k) / (2 * k + m);
                    double z = s * (s - 4) + 0.02 * n;


                    s = Math.Round(s, 10);
                    z = Math.Round(z, 5);

                    textBox3.Text = s.ToString();
                    textBox4.Text = z.ToString();
                    

                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    

                    label3.Visible = true;
                    label4.Visible = true;
                   

                    label3.Text = "s = ";
                    label4.Text = "z = ";
                    
                }
                else if(radioButton2.Checked)
                {
                    double m = Convert.ToDouble(textBox1.Text);
                    double n = Convert.ToDouble(textBox2.Text);

                    double v = 0;
                    for (int k = 1; k <= 20; k++)
                        v += (Math.Pow(k, 2) + m) / (Math.Pow(k, 3) + 10);
                    double u = v * v + 2 * v - 0.2 * n;


                    v = Math.Round(v, 6);
                    u = Math.Round(u, 6);

                    textBox3.Text = v.ToString();
                    textBox4.Text = u.ToString();

                    textBox3.Visible = true;
                    textBox4.Visible = true;


                    label3.Visible = true;
                    label4.Visible = true;


                    label3.Text = "v = ";
                    label4.Text = "u = ";
                }
            }
            else
            {
                MessageBox.Show("Введите m и n", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}