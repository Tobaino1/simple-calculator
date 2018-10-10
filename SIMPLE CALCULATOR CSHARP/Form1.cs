using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMPLE_CALCULATOR_CSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int answer;
           
           number1 = int.Parse(textBox1.Text);
           number2 = int.Parse(textBox2.Text);
            answer = number1 + number2;

            MessageBox.Show(answer.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int answer;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            answer = number1 - number2;
            MessageBox.Show(answer.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int answer;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            answer = number1 / number2;
            MessageBox.Show(answer.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int answer;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            answer = number2 * number2;
            MessageBox.Show(answer.ToString());


        }
    }
}
