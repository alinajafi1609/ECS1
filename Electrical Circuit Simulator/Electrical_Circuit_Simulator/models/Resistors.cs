using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electrical_Circuit_Simulator
{
    class Resistors
    {
        int pd;
        int res;
        char POrS; 
        public Resistors(int res, int pd, char POrS)
        {
            this.pd = pd;
            this.res = res;
            this.POrS = POrS;
        }
    }
}
