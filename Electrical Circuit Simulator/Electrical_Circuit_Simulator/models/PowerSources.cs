using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electrical_Circuit_Simulator
{
    class PowerSources
    {
        int Volts;
        int IR;
        char POrS;
        public PowerSources(int Volts, int IR, char POrS)
        {
            this.Volts = Volts;
            this.IR = IR;
            this.POrS = POrS;

        }
    }
}
