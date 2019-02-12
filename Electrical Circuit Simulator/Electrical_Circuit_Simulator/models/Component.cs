namespace Electrical_Circuit_Simulator
{
    public class ComponentResistors
    {
        public ComponentResistors(double res, double pd, string pos, string name, int Junction)
        {
            Res = res;
            Vol = pd;
            Name = name;
            PoS = pos;
            Junction = junction;
        }

        public double Res { get; set; }
        public double Vol { get; set; }
        public string Name { get; set; }
        public string PoS { get; set; }
        public int junction { get; set; }

    }
}
