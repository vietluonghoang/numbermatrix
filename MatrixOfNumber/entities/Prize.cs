using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    class Prize
    {
        private string label;
        private string number;

        public Prize(string label, string number)
        {
            this.label = label;
            this.number = number;
        }
        public string Label
        {
            set { this.label = value; }
            get { return this.label; }
        }
        public string Number
        {
            set { this.number = value; }
            get { return this.number; }
        }
    }
}
