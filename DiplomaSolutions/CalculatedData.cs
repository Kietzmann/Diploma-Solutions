namespace DiplomaSolutions
{
    public class CalculatedData
    {
        //from GeometricParams
        public double alphaN;
        public double alphaW;

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
        public double gammaU;
        public double h1;
        public double ha1;
        public double hAL;
        public double M1;
        public double gammaOmega;
        public double alphaX;
        

        //From CalculationControls
        public double p1;
        public double pz1;
        public double rK;
        public double RoF1;
        public double sa1;
        public double u;
        public double uCurr;
        public double xMax;
        public double xMin;

        //unknown yet
        public double z2;
        public double x;

        public override string ToString()
        {
            return $"AlphaN: {alphaN}, AlphaW: {alphaW}, B1: {b1}, B2: {b2}, CU: {cU}, D: {D}, D1: {d1}, D2: {d2}, DA1: {dA1}, DA2: {dA2}, DAe2: {dAE2}, DB: {dB}, DW1: {dW1}, Gamma: {gamma}, GammaB: {gammaB}, GammaU: {gammaU}, H1: {h1}, Ha1: {ha1}, HAl: {hAL}, M1: {M1}, GammaOmega: {gammaOmega}, AlphaX: {alphaX}, P1: {p1}, Pz1: {pz1}, RK: {rK}, RoF1: {RoF1}, Sa1: {sa1}, U: {u}, UCurr: {uCurr}, XMax: {xMax}, XMin: {xMin}, Z2: {z2}, X: {x}";
        }
    }
}