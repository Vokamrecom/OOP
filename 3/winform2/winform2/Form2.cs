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
    [Serializable]
    public partial class Form2 : Form
    {
        public Form2(List<Shchet> list)
        {
            InitializeComponent();
            this.PoiskTypeOperation.Items.AddRange(Shchet.types);
            this.list = list;
        }
        public string type = String.Empty;//type
        public string FamiliaP= String.Empty;//company
        public int NomerShchetaP= -1;//space
        public int BalansP = -1;// capacity
        private List<Shchet> list;
        public List<Shchet> search_result = new List<Shchet>();

        public Form2()
        {
            InitializeComponent();
            this.PoiskTypeOperation.Items.AddRange(Shchet.types);
        }

        private void GoToDefault()
        {
            this.type = this.FamiliaP = String.Empty;
            this.BalansP = this.NomerShchetaP = -1;
            this.search = true;
        }

        
        private bool search = true;

        private void ClearPoisk_Click_1(object sender, EventArgs e)
        {
            this.PoiskNomera.Text = String.Empty;
            this.PoiskTypeOperation.Text = String.Empty;
            this.PoiskFamilia.Text = String.Empty;
            this.PoiskBalans.Text = String.Empty;
            this.SearchResult_List.Items.Clear();
        }


        private void Search(IEnumerable<Shchet> list)
        {
            try
            {
                SearchResult_List.Items.Clear();
                bool wasCheck = false;
                List<Shchet> query = new List<Shchet>(list.Count<Shchet>());
                if (!this.type.Equals(String.Empty))
                {
                    wasCheck = true;
                    var result = from shchet in list
                                 where shchet.Type == this.type
                                 select shchet;
                    if (result.Count<Shchet>() == 0)
                    {
                        this.search = false;
                    }
                    else
                    {
                        foreach (Shchet a in result)
                        {
                            query.Add(a);
                            //search_result.Add(a);
                        }
                    }
                }

                /*if (!this.FamiliaP.Equals(String.Empty) && this.search)
                {
                    var result = from airplane in wasCheck ? query : list
                        where airplane.Vladelec. == this.FamiliaP
                        select airplane;
                    wasCheck = true;
                    if (result.Count<Shchet>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Shchet>(result.Count<Shchet>());
                        foreach (Shchet a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                            }
                        }
                    }
                }*/

                if (this.NomerShchetaP != -1 && this.search)
                {
                    var result = from shchet in wasCheck ? query : list
                                 where shchet.Nomer == this.NomerShchetaP
                                 select shchet;
                    wasCheck = true;
                    if (result.Count<Shchet>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Shchet>(result.Count<Shchet>());
                        foreach (Shchet a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                                //search_result.Add(a);
                            }
                        }

                    }
                }
                if (this.BalansP != -1 && this.search)
                {
                    var result = from shchet in wasCheck ? query : list
                                 where shchet.Balans == this.BalansP
                                 select shchet;
                    wasCheck = true;
                    if (result.Count<Shchet>() == 0)
                    {
                        this.search = false;
                    }
                    else if (this.search)
                    {
                        query = new List<Shchet>(result.Count<Shchet>());
                        foreach (Shchet a in result)
                        {
                            if (!query.Contains(a))
                            {
                                query.Add(a);
                                search_result.Add(a);
                            }
                        }
                    }
                }
                if (query.Count != 0 && this.search)
                {
                    foreach (Shchet a in query)
                    {
                        this.SearchResult_List.Items.Add(a);
                        search_result.Add(a);
                    }
                }
                else
                {
                    MessageBox.Show("no matches found");
                }
                this.GoToDefault();
                query.Clear();
            }
            catch
            {
                MessageBox.Show("Test");
            }
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            this.SearchResult_List.Items.Clear();
            try
            {
                bool flag = false;
                int capac;
                if (!this.PoiskBalans.Text.Equals(String.Empty) && (capac = Convert.ToInt32(this.PoiskBalans.Text)) > -1 && capac < 10000000)
                {
                    this.BalansP = capac;
                    flag = true;
                }
                if (!this.PoiskTypeOperation.Text.Equals(String.Empty))
                {
                    flag = true;
                    this.type = this.PoiskTypeOperation.Text;
                }
                int space;
                if (!this.PoiskNomera.Text.Equals(String.Empty) && (space = Convert.ToInt32(this.PoiskNomera.Text)) > -1 && space < 201)
                {
                    flag = true;
                    this.NomerShchetaP = space;
                }
              /*  if (!this.PoiskFamilia.Text.Equals(String.Empty))
                {
                    flag = true;
                    this.FamiliaP = this.PoiskFamilia.Text;
                }*/
                if (!flag)
                {
                    MessageBox.Show("no criteries for search");
                    return;
                }

                this.Search(this.list);
                this.GoToDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
    }
}
