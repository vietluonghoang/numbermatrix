using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    class Result
    {
        private string date;
        private string header;
        private List<Prize> prizes;

        public Result(string date, string header, List<Prize> prizes)
        {
            this.date = date;
            this.header = header;
            this.prizes = prizes;
        }

        public string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }

        public string Header
        {
            set { this.header = value; }
            get { return this.header; }
        }
        public List<Prize> Prizes
        {
            set { this.prizes = value; }
            get { return this.prizes; }
        }

        public List<TypeNumber> getNumbers()
        {
            List<TypeNumber> lstNum = null;
            if (this.prizes.Count > 0)
            {
                lstNum = new List<TypeNumber>();
                foreach (Prize p in prizes)
                {
                    if ("Giải đặc biệt".Equals(p.Label))
                    {
                        TypeNumber tp = new TypeNumber(1, int.Parse(splitNumber(p.Number)[0]));
                        lstNum.Add(tp);
                    }
                    else
                    {
                        foreach (string s in splitNumber(p.Number))
                        {
                            TypeNumber tp = new TypeNumber(0, int.Parse(s));
                            lstNum.Add(tp);
                        }
                    }
                }
            }
            return lstNum;
        }
        private List<string> splitNumber(string prize)
        {
            string[] tn = prize.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> rs = new List<string>();
            foreach (string s in tn)
            {
                rs.Add(s.Substring(s.Length-2));
            }
            return rs;
        }
    }
}
