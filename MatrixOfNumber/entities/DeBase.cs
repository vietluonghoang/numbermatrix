using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumber.entities
{
    class DeBase
    {
        private int bdID;
        private string bdName;
        private float bdBase;

        public DeBase(int bdID, string bdName, float bdBase)
        {
            this.bdID = bdID;
            this.bdName = bdName;
            this.bdBase = bdBase;
        }
        public int BdID
        {
            set { this.bdID = value; }
            get { return this.bdID; }
        }
        public string BdName
        {
            set { this.bdName = value; }
            get { return this.bdName; }
        }
        public float BdBase
        {
            set { this.bdBase = value; }
            get { return this.bdBase; }
        }
        public override string ToString()
        {
            return this.bdName;
        }
    }
}
