namespace Electrical_Circuit_Simulator
{
    public class ComponentResistors
    {
        public ComponentResistors(double res, double pd, string pos, string name)
        {
            Res = res;
            Vol = pd;
            Name = name;
            PoS = pos;

        }

        public double Res { get; set; }
        public double Vol { get; set; }
        public string Name { get; set; }
        public string PoS { get; set; }

    }
}
