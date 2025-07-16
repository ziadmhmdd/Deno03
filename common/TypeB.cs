using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeB
    {
        private int X;
        internal int Y;
        public int Z;
        




        void fun01()
        { 
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB();

            typeB.X = 12; // Valid
            typeB.Y = 12; // Valid
            typeB.Z = 12; // Valid


        }

    }
}
