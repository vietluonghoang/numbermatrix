using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    class LoBase
    {
        private int blID;
        private string blName;
        private float blBase;

        public LoBase(int blID,string blName, float blBase)
        {
            this.blID = blID;
            this.blName = blName;
            this.blBase = blBase;
        }
        public int BlID
        {
            set { this.blID = value; }
            get { return this.blID; }
        }
        public string BlName
        {
            set { this.blName = value; }
            get { return this.blName; }
        }
        public float BlBase
        {
            set { this.blBase = value; }
            get { return this.blBase; }
        }
        public override string ToString()
        {
            return this.blName;
        }
    }
}
