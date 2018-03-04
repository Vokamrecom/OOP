using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace winform2
{
    [Serializable]
    public class Shchet
    {
        public static string[] types = new string[3]
        {
            "Денежные переводы", "Обмен валют", "Пополнение баланса"
        };
        public int Nomer;
        public string Type;
        public int Balans;
        public string Dates;
        public List<string> types1;
        public List<string> Vladelec;

        public Shchet( string dates,int nomer, string type, List<string> list1 ,int balans, List<string> vladelec)
        {
            this.Nomer = nomer;
            this.types1 = list1;
            this.Type = type;

            // this.list_of_crewman = list;
             this.Balans = balans;
            this.Dates = dates;
            this.Vladelec = vladelec;
        }

        public Shchet()
        {

        }

        public string ShowAllInformation()
        {
            string types1 = "";
            foreach (string s in this.types1)
            {
                if (types1.Equals(""))
                {
                    types1 += s;
                }
                else
                {
                    types1 += "/" + s;
                }
            }
            string Vladelec = "";
            foreach (string ss in this.Vladelec)
            {
                if (Vladelec.Equals(""))
                {
                    Vladelec += ss;
                }
                else
                {
                    Vladelec += "/" + ss;
                }
            }

            return Dates+" №:" +this.Nomer+","+this.Type+" Балансом: "+this.Balans+"руб. "+types1 + ", " + Vladelec;
        }

        public override string ToString()
        {
            return Dates + " №:" + this.Nomer.ToString() +","+this.Type.ToString() + " Балансом: "+this.Balans.ToString() + "руб. " /*+ this.types1+ this.types1.ToString() + types1.ToString()+ this.Vladelec.ToString()*/;
        }
    }
}
