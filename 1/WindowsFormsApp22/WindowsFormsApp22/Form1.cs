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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Student> collection;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int count;
                if (textBox1.Text == "" || (count = Convert.ToInt32(textBox1.Text)) == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                    this.collection = null;
                }
                else
                {
                    collection = new List<Student>(count);
                    Student st;
                    for (int i = 0; i < count; i++)
                    {
                        st = new Student();
                        collection.Add(st);
                    }
                    foreach (Student s in collection)
                    {
                        listBox1.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)//по возраст
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                }
                else
                {
                    collection.Sort();
                    foreach (Student s in collection)
                    {
                        listBox2.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//по убыв
        {
            try
            {
                listBox2.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                }
                else
                {
                    Student st = new Student();
                    collection.Sort(0, collection.Count, st);
                    foreach (Student s in collection)
                    {
                        listBox2.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    if (form2.kurs > 0)
                    {
                        var query = from st in collection
                            where st.kurs == form2.kurs
                            select st;
                        foreach (Student s in query)
                        {
                            listBox3.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                        }
                    }
                    else
                    {
                        MessageBox.Show("вы не написали № группы");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    var query = from st in collection
                        where st.name == form3.name
                        select st;
                    short count = 0;
                    foreach (Student s in query)
                    {
                        count++;
                        listBox3.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("Такое имя не найдено");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Коллекция пуста");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    if (form2.kurs > 0)
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        var query = from st in collection
                            where st.kurs == form2.kurs && st.name == form3.name
                            select st;
                        short count = 0;
                        foreach (Student s in query)
                        {
                            count++;
                            listBox3.Items.Add(s.name + " , " + s.kurs + " курс, " + s.group + " группа;");
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("такого имени не найдено");
                        }
                    }
                    else
                    {
                        MessageBox.Show("вы не написали № группы");
                        throw new Exception("пожалуйста повторите и напишите номер группы");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
    }
}
