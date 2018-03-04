using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform2
{
    [Serializable]
    public class History
    {
        public string Sum;
        public string Date;
        public List<string> types;

        public History(string sum, string date, List<string> list)
        {
            this.Sum = sum;
            this.Date = date;
            this.types = list;
        }

        public History()
        {

        }

        public string ShowAllInformation()
        {
            string type = "";
            foreach (string s in this.types)
            {
                if (type.Equals(""))
                {
                    type += s;
                }
                else
                {
                    type += "/" + s;
                }
            }
            return type+ " в сумме "+ this.ToString() + " руб. " + this.Date  ;
        }

        public override string ToString()
        {
            return this.Sum;
        }
    }
}