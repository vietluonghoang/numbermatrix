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
    }
}
