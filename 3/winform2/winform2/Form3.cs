using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // pictureBox1.Load(< Рабочий стол >);
            System.IO.FileStream fs = new System.IO.FileStream(@"D:\\Снимок.PNG", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pictureBox1.Image = img;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        }
    }

