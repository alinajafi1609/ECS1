using System.Collections.Generic;

namespace Electrical_Circuit_Simulator
{
    public class Circuit
    {
        public List<Component> ComponentList { get; }
        public Circuit()
        {
            ComponentList = new List<Component>();
        }

        public double caclucate()
        {
            foreach(Component c in ComponentList)
            {
                if(c.Pos == "p")
                {

                }
            }

            return 0;
        }
    }
}
