namespace DiplomaSolutions
{
    public class InputData
    {
        public double alphaX;
        public int aW;
        public double c1;
        public double c2;
        public double D;
        public string gearType;
        public double h1;
        public double hAstrxAL;
        public double m;
        public double q;
        public int Ro;
        public double RoAstrxF1;
        public double sAstrx;
        public double x;
        public int z1;
        public int z2;

        public override string ToString()
        {
            return $"AlphaX: {alphaX}, AW: {aW}, C1: {c1}, C2: {c2}, D: {D}, GearType: {gearType}, H1: {h1}, HAstrxAl: {hAstrxAL}, M: {m}, Q: {q}, Ro: {Ro}, RoAstrxF1: {RoAstrxF1}, SAstrx: {sAstrx}, X: {x}, Z1: {z1}, Z2: {z2}";
        }
    }
}