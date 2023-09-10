using System;
using System.Collections.Generic;
using System.Text;

namespace Paramenters1
{
    class Employee<T>
    {
        public List<T> things {get; set;} // property called “things”, data type is generic list matching the generic type of the class
    }
}
