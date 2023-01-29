using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "2,3";
            textBox2.Text = "6,32";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text += "Лаб.раб №2 Ст. гр. ПОКС-33";
            double Fx, x = double.Parse(textBox1.Text) ,b = double.Parse(textBox2.Text);

            textBox5.Text += Environment.NewLine + "X = " + x.ToString();
            textBox5.Text += Environment.NewLine + "B = " + b.ToString();
           

            if (radioButton1.Checked)
            {
                Fx = Math.Sinh(x); 
                textBox5.Text += Environment.NewLine + "F(x) = " + Fx.ToString();
                Start(x, b, Fx);
                textBox5.Text += Environment.NewLine + "Y = " + Start(x, b, Fx).ToString();
            }
            else if (radioButton2.Checked)
            {
                Fx = Math.Pow(x,2);
                textBox5.Text += Environment.NewLine + "F(x) = " + Fx.ToString();
                Start(x, b, Fx);
                textBox5.Text += Environment.NewLine + "Y = " + Start(x, b, Fx).ToString();

            }
            else if (radioButton3.Checked)
            {
                Fx = Math.Sinh(x);
                textBox5.Text += Environment.NewLine + "F(x) = " + Fx.ToString();
                Start(x, b, Fx);
                textBox5.Text += Environment.NewLine + "Y = " + Start(x, b, Fx).ToString();

            }

            textBox5.Text += Environment.NewLine;

        }

        public double Start(double x, double b, double Fx)
        {
            if(1 < x * b && x * b < 10)
            {
                textBox5.Text += Environment.NewLine + "1<xb<10";
                return Math.Exp(Fx);
            }
            else if(12 < x * b && x * b < 40)
            {
                textBox5.Text += Environment.NewLine + "12<xb<40";
                return  Math.Sqrt(Math.Abs(Fx + 4 * b));
            }
            else
            {
                textBox5.Text += Environment.NewLine + "Иначе";
                return  Math.Pow(Fx,2) * b ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";

        }
    }
}
