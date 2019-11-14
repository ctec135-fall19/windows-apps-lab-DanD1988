using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class MyClass
    {
        // static partial class
        // field and nothing else
        private int myField;

        // property needs to be public / part of it
        public int MyProperty { get; set; }
    }
}
