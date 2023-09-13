using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_1
{
    class ChainClass
    {

        //Chain two constructors together
        public ChainClass(string myStr) : this(myStr, 100)
        {
        }

        public ChainClass(string myStr, int myInt)
        {
            this.classStr = myStr;
            this.classInt = myInt;
        }
        public string classStr;
        public int classInt;
    }
}
