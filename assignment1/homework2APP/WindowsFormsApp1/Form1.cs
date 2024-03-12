using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            double number1=Double.Parse(num1);
            string num2 = textBox3.Text;
            double number2 = Double.Parse(num2);
            string ope = textBox2.Text;

            double res = 0;
            switch (ope)
            {
                case "+":
                    res = number1 + number2;
                    break;
                case "-":
                    res = number1 - number2;
                    break;
                case "*":
                    res = number1 * number2;
                    break;
                case "/":   
                    res = number1 / number2;
                    break;
                default:
                    Console.WriteLine("请输入正确的运算符");
                    break;
            }

            MessageBox.Show("运算结果为：" + res);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
