using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform2
{
    [Serializable]
    public class Papa
    {
        public string Namefirst;
        public string Namesecond;
        public string NameOtchestvo;
        public string Date;
        public string Passport;
        public string Sex;
        
        

        public Papa(string namefirst, string namesecond, string nameotchestvo,  string sex, string passport, string date)
        {
            this.Namefirst = namefirst;
            this.Namesecond = namesecond;
            this.NameOtchestvo = nameotchestvo;
            this.Sex = sex;
            this.Passport =passport;
            this.Date = date;
        }
        public Papa()
        {

        }


        public override string ToString()
        {
            return this.Namefirst + " " + this.Namesecond + " "  + this.NameOtchestvo + ", " + this.Sex + ", " + this.Passport + ", " + this.Date ;
        }
    }
}
