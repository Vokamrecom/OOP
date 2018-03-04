using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace winform2
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ShchetType.Items.AddRange(Shchet.types); //добавили в выпад меню 3 пункта
           // this.Airplane_Type.Items.AddRange(Shchet.types);
        }

        public List<Papa> list_of_papa = new List<Papa>();
         public List<Shchet> list_of_shchet = new List<Shchet>();

        public List<Shchet> search_result = new List<Shchet>();
        public List<Shchet> sort_result = new List<Shchet>();

        private void AddPapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.PapaFamiliya.Text.Equals("") || this.PapaName.Text.Equals("") ||
                    this.PapaOtchestvo.Text.Equals("") ||
                    (this.Papa_pol_myz.Checked == false && this.Papa_pol_zhenshina.Checked == false) ||
                    this.PapaPassport.Text.Equals(""))
                {
                    MessageBox.Show("Ошибка в правильности полей");
                }
                else
                {
                    Papa crewman = new Papa(this.PapaFamiliya.Text, this.PapaName.Text, this.PapaOtchestvo.Text,
                        this.Papa_pol_myz.Checked == true ? this.Papa_pol_myz.Text : this.Papa_pol_zhenshina.Text,
                        this.PapaPassport.Text, this.PapaDate.Text);


                    list_of_papa.Add(crewman);
                    this.PapaList.Items.Add(crewman);
                    this.ShchetListVladelec.Items.Add(crewman);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void ClearPapa_Click(object sender, EventArgs e)
        {
            this.PapaFamiliya.Clear();
            this.PapaName.Clear();
            this.PapaOtchestvo.Clear();
            this.Papa_pol_zhenshina.Checked = this.Papa_pol_myz.Checked = false;
            this.PapaPassport.Clear();

            //this.Crewman_Age.Value = this.Crewman_Age.Minimum;
            // this.Crewman_Experience.Value = 0;
            // this.Crewman_Position.Text = "";
        }

        private void ClearPapaSpisok_Click(object sender, EventArgs e)
        {
            PapaList.Items.Clear();
        }

        private void AddHistory_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                bool check = false;
                

                    if (this.HistorycheckBox1.Checked)
                    {
                        list.Add(this.HistorycheckBox1.Text);
                        check = true;
                    }
                

                if (this.HistorycheckBox2.Checked)
                {
                    list.Add(this.HistorycheckBox2.Text);
                    check = true;
                }

                if (this.HistorycheckBox3.Checked)
                {
                    list.Add(this.HistorycheckBox3.Text);
                    check = true;
                }


                int sum;
                if ((sum = Convert.ToInt32(this.HistorySum.Text)) < 0 || sum > 10000000 )
                {
                    MessageBox.Show("Проверьте правильность суммы ");
                }
                else
                {
                    History company = new History(this.HistorySum.Text, this.DateHistory.Text, list);
                    this.HistoryList.Items.Add(company.ShowAllInformation());
                    //this.ShchetType.Items.Add(company);добавляет в выпад список сумму
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {

            this.HistorySum.Clear();
            this.HistorycheckBox1.Checked = this.HistorycheckBox2.Checked = this.HistorycheckBox3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e) //очистить список History
        {
            HistoryList.Items.Clear();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ShchetListVladelec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddShchet_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ShchetType.SelectedIndex == 0)
                {
                    bool check1 = HistorycheckBox1.Checked;
                    check1 = true;
                }


                if (this.ShchetNomer.Text.Equals("") || this.ShchetType.Text.Equals("") ||
                    this.ShchetBalans.Text.Equals("") || this.ShchetListVladelec.Text.Equals(""))
                {
                    MessageBox.Show("информация не заполнена");
                }
                else
                {
                    int capac;
                    if ((capac = Convert.ToInt32(this.ShchetBalans.Text)) < 0 || capac > 10000000 ||
                        Convert.ToInt32(this.ShchetNomer.Text) < 0 || capac > 10000000)
                    {
                        MessageBox.Show("Проверьте правильность баланса и номера");
                    }
                    else
                    {
                        List<string> list1 = new List<string>();
                        bool check = false;
                        

                        if (this.ShchetcheckBox1.Checked)
                        {
                            list1.Add(this.ShchetcheckBox1.Text);
                            check = true;
                        }

                        if (this.ShchetcheckBox2.Checked)
                        {
                            list1.Add(this.ShchetcheckBox2.Text);
                            check = true;
                        }

                         List<string> listVladelec = new List<string>();
                        if (ShchetListVladelec.CheckedItems.Count > 1)
                        {
                            MessageBox.Show("Вы выбрали много владельцев! ");
                            this.ShchetList.Items.Clear();
                        }
                        else
                        {
                            foreach (object itemChecked in ShchetListVladelec.CheckedItems)
                        {
                                listVladelec.Add(itemChecked.ToString());
                            }
                        }

                        
                        
                            if (this.ShchetNomer.Text.Equals(""))
                        {
                            MessageBox.Show("error: check information");
                        }
                        else
                        {
                            Shchet company = new Shchet(Convert.ToString(this.ShchetmonthCalendar1.SelectionStart),
                                Convert.ToInt32(this.ShchetNomer.Text), this.ShchetType.Text,
                                list1, Convert.ToInt32(this.ShchetBalans.Text), listVladelec);

                            list_of_shchet.Add(company);
                                this.ShchetList.Items.Add(company.ShowAllInformation());
                                //this.ShchetType.Items.Add(company.ToString());/////////////////////////////////////////////////////
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Входная строка имела неверный формат.")
                {
                    MessageBox.Show("error: check digital information");
                }
                else
                {
                    MessageBox.Show("error: " + ex.Message);
                }


            }
        }

        private void ClearShchet_Click(object sender, EventArgs e)
        {
            this.ShchetNomer.Clear();
            this.ShchetBalans.Clear();
            this.ShchetType.ResetText();
            this.ShchetcheckBox1.Checked = this.ShchetcheckBox2.Checked = false;
        }

        private void ClearspisVladel_Click(object sender, EventArgs e)
        {
            this.ShchetListVladelec.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ShchetList.Items.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            this.saveFileDialog1.FileName = "serialization.xml";
            this.saveFileDialog1.InitialDirectory = "D:\\Кирилл\\Универ\\ООП\\Лабы\\2";
            this.saveFileDialog1.ShowDialog(); 

            if (list_of_shchet.Count != 0)
            {
                using (FileStream fs = new FileStream(this.saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                   /* if (this.saveFileDialog1.FileName.Contains(".json"))
                    {
                        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Shchet>));
                        jsonSerializer.WriteObject(fs, list_of_shchet);
                    }
                    else*/ if (this.saveFileDialog1.FileName.Contains(".xml"))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shchet>));
                        xmlSerializer.Serialize(fs, list_of_shchet);
                    }
                    else
                    {
                        throw new Exception("uncorrect extension");
                    }
                }
            }
            else
            {
                MessageBox.Show("list is empty");
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            
            try {
                
                this.openFileDialog1.FileName = "serialization.xml";
            this.openFileDialog1.InitialDirectory = "D:\\Кирилл\\Универ\\ООП\\Лабы\\2";
            this.openFileDialog1.ShowDialog(); 

            List<Shchet> lst;
            using (FileStream fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open))
            {/*
                     if (this.openFileDialog1.FileName.Contains(".json"))
                      {
                          DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Shchet>));
                          lst = (List<Shchet>) jsonSerializer.ReadObject(fs);
                      }
                     else*/
                if (this.openFileDialog1.FileName.Contains(".xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shchet>));
                    lst = (List<Shchet>) xmlSerializer.Deserialize(fs);
                }
                else
                {
                    throw new Exception("uncorrect extension");
                }
            }

            if (lst.Count != 0)
            {
                foreach (Shchet a in lst)
                {
                    list_of_shchet.Add(a);
                    ShchetList.Items.Add(a);
                }
            }
            else
            {
                MessageBox.Show("collection is empty");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("error:" + ex.Message);
        }
    }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(list_of_shchet);

            form2.ShowDialog();
            if (form2.search_result != null)
            {
                this.search_result = form2.search_result;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.ShowDialog();
        }

        private void типОперацииToolStripMenuItem_Click(object sender, EventArgs e)//по номеру операции
        {
            var result = from a in this.list_of_shchet
                orderby a.Nomer
                select a;
           /* var result1 = from a in result
                orderby a.Type
                select a;*/
           this.ShchetList.Items.Clear();
            this.search_result.Clear();
            foreach (Shchet a in result)
            {
                this.search_result.Add(a);
                this.ShchetList.Items.Add(a);
            }

        }

        private void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = from a in this.list_of_shchet
                orderby a.Dates
                select a;
            /* var result1 = from a in result
                 orderby a.Type
                 select a;*/
            this.ShchetList.Items.Clear();
            this.search_result.Clear();
            foreach (Shchet a in result)
            {
                this.search_result.Add(a);
                this.ShchetList.Items.Add(a);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void последнийПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "search.xml";
            this.saveFileDialog1.InitialDirectory = "D:\\Кирилл\\Универ\\ООП\\Лабы\\3";
            this.saveFileDialog1.ShowDialog();

            if (search_result.Count != 0)
            {
                using (FileStream fs = new FileStream(this.saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shchet>));
                    xmlSerializer.Serialize(fs, search_result);
                }
            }
            else MessageBox.Show("Пусто");
        }

        private void сортировкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save_Dialog.FileName = "sort.xml";
            this.Save_Dialog.InitialDirectory = "D:\\Кирилл\\Универ\\ООП\\Лабы\\3";
            this.Save_Dialog.ShowDialog();

            if (list_of_shchet.Count != 0)
            {
                using (FileStream fs = new FileStream(this.Save_Dialog.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Shchet>));
                    xmlSerializer.Serialize(fs, list_of_shchet);
                }
            }
            else MessageBox.Show("Пусто");
        }
    }
    }

