namespace DiplomaSolutions
{
    public class CalculatedData
    {
        //from GeometricParams
        public double alphaN;
        public double alphaW;
        public double alphaX;

        //
        public double b1;
        public double b2;
        public double cU;
        public double D;
        //from calculationDiameters;
        public double d1;
        public double d2;
        public double dA1;
        public double dA2;
        public double dAE2;
        public double dB;
        public double dW1;
        public double gamma;
        public double gammaB;
        public double gammaOmega;
        public double gammaU;
        public double h1;
        public double ha1;
        public double hAL;
        public double M1;


        //From CalculationControls
        public double p1;
        public double pz1;
        public double rK;
        public double RoF1;
        public double sa1;
        public double u;
        public double uCurr;
        public double x;
        public double xMax;
        public double xMin;

        //unknown yet
        public double z2;

        public override string ToString()
        {
            return
                $"AlphaN: {alphaN}, \n" +
                $"AlphaW: {alphaW},\n" +
                $" B1: {b1},\n" +
                $" B2: {b2},\n" +
                $" CU: {cU},\n" +
                $" D: {D},\n" +
                $" D1: {d1},\n" +
                $" D2: {d2}, \n" +
                $"DA1: {dA1},\n" +
                $" DA2: {dA2},\n" +
                $" DAe2: {dAE2},\n" +
                $" DB: {dB},\n" +
                $" DW1: {dW1},\n" +
                $" Gamma: {gamma},\n" +
                $" GammaB: {gammaB},\n" +
                $" GammaU: {gammaU},\n" +
                $" H1: {h1},\n" +
                $" Ha1: {ha1},\n" +
                $" HAl: {hAL},\n" +
                $" M1: {M1}, \n" +
                $"GammaOmega: {gammaOmega},\n" +
                $" AlphaX: {alphaX}, \n" +
                $"P1: {p1}, \n" +
                $"Pz1: {pz1},\n" +
                $" RK: {rK},\n" +
                $" RoF1: {RoF1},\n" +
                $" Sa1: {sa1},\n" +
                $" U: {u}, \n" +
                $"UCurr: {uCurr},\n" +
                $" XMax: {xMax},\n" +
                $" XMin: {xMin},\n" +
                $" Z2: {z2},\n" +
                $" X: {x}";
        }
    }
}