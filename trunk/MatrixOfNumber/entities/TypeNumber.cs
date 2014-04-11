using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    public class TypeNumber
    {
        private int type;
        private int number;

        public TypeNumber(int type, int number)
        {
            this.type = type;
            this.number = number;
        }
        public int Type
        {
            set { this.type = value; }
            get { return this.type; }
        }
        public int Number
        {
            set { this.number = value; }
            get { return this.number; }
        }
    }
}
