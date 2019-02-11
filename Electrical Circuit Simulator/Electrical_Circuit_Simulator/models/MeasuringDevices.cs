using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electrical_Circuit_Simulator
{
    class MeasuringDevices
    {
        int pd;
        int current;
        public MeasuringDevices(int current, int pd)
        {
            this.pd = pd;
            this.current = current;
        }
    }
}
