using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form2 : Form
    {
        public short kurs;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                short kurs;
                if (this.textBox1.Text != "" && (kurs = Convert.ToInt16(this.textBox1.Text)) > 0 && kurs < 5)
                {
                    this.kurs = kurs;
                }
                else
                {
                    this.kurs = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
