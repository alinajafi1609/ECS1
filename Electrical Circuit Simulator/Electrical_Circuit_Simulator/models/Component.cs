namespace Electrical_Circuit_Simulator
{
    public class Component
    {
        public Component(double res, double pd, string pos, string name)
        {
            Res = res;
            Vol = pd;
            Name = name;
            Pos = pos;

        }

        public double Res { get; set; }
        public double Vol { get; set; }
        public string Name { get; set; }
        public string Pos { get; set; }

    }
}
