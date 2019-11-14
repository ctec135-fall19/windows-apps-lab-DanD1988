using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class MyClass
    {
        // Constructer 
        public MyClass(int x)
        {
            this.myField = x;
        }

        public void printState()
        {
            Console.WriteLine("State: {0}", myField);
        }
    }
}
