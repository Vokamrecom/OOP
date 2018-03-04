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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//>
        {
            label1.Text = ">";
            action(textBox1, textBox2, textBox3);
        }
        //созд экзаемпляр
        private static Action<TextBox, TextBox, TextBox> action = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                
                bool greater = Calculator.Bigger(a.Text, b.Text);
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
                
            }
        });

        private void button2_Click(object sender, EventArgs e)//<
        {
            label1.Text = "<";
            action2(textBox1, textBox2, textBox3);
        }
        static Action<TextBox, TextBox, TextBox> action2 = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                bool greater = Calculator.Smaller(a.Text, b.Text);
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
            }
        });

        private void button3_Click(object sender, EventArgs e)//==
        {
            label1.Text = "==";
            action3(textBox1, textBox2, textBox3);
        }
        static Action<TextBox, TextBox, TextBox> action3 = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                bool greater = Calculator.Equal(a.Text, b.Text);
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
            }
        });

        private void button4_Click(object sender, EventArgs e)//!=
        {
            label1.Text = "!=";
            action4(textBox1, textBox2, textBox3);
        }
        static Action<TextBox, TextBox, TextBox> action4 = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                bool greater = Calculator.NoEqual(a.Text, b.Text);
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
            }
        });

        private void button5_Click(object sender, EventArgs e)//>>
        {
            label1.Text = ">>";
            action5(textBox1, textBox2, textBox3);
        }
        static Action<TextBox, TextBox, TextBox> action5 = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                int greater = Calculator.Right(Int32.Parse(a.Text), Int32.Parse(b.Text));
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
            }
        });

        private void button6_Click(object sender, EventArgs e)//<<
        {
            label1.Text = "<<";
            action6(textBox1, textBox2, textBox3);
        }
        static Action<TextBox, TextBox, TextBox> action6 = new Action<TextBox, TextBox, TextBox>((TextBox a, TextBox b, TextBox c) => {
            try
            {
                int greater = Calculator.Left(Int32.Parse(a.Text), Int32.Parse(b.Text));
                c.Text = greater.ToString();
            }
            catch
            {
                c.Text = "NaN";
            }
        });

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
