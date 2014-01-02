using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    class Customer
    {
        private int kID;
        private string kName;

        public Customer()
        {
        }
        public Customer(int kID, string kName)
        {
            this.kID = kID;
            this.kName = kName;
        }

        public int KID
        {
            set { this.kID = value; }
            get { return this.kID; }
        }
        public string KName
        {
            set { this.kName = value; }
            get { return this.kName; }
        }

        public override string ToString()
        {
            return this.kName;
        }
    }
}
