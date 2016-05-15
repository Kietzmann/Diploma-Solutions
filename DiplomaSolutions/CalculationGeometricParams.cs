using System;

namespace DiplomaSolutions
{
    public class CalculationGeometricParams
    {
        private double alphaN;
        private double alphaW;
        private double aW;
        private double gamma;
        private double gammaB;
        private double m;
        private double q;

        public double AlphaN
        {
            get { return alphaN; }
        }

        public double AlphaW
        {
            get { return alphaW; }
        }

        public double AW
        {
            get { return aW; }
        }

        public double Gamma
        {
            get { return gamma; }
        }

        public double GammaB
        {
            get { return gammaB; }
        }

        public double M
        {
            get { return m; }
        }

        public double Q
        {
            get { return q; }
        }

        public double U
        {
            get { return u; }
        }

        public double UCurr
        {
            get { return uCurr; }
        }

        public double X
        {
            get { return x; }
        }

        public double Z1
        {
            get { return z1; }
        }

        public double Z2
        {
            get { return z2; }
        }

        public double XMin
        {
            get { return xMin; }
        }

        public double HAstrxAl
        {
            get { return hAstrxAL; }
        }

        public double AlphaX
        {
            get { return alphaX; }
        }

        public double XMax
        {
            get { return xMax; }
        }

        private double u;
        private double uCurr;
        private double x;
        private double z1;
        private double z2;
        private double xMin;
        private double hAstrxAL;
        private double alphaX;
        private double xMax;
        


        public void calculateQuantityOfTeeth()
        {
            z2 = z1*uCurr;
        }

        public void calculateWormDrag()
        {
            x = aW/m - 0.5*(z2 + q);
        }

        public void calculateTransmitionCoef()
        {
            u = z2/z1;
        }

        public void calculateInteraxalDistance()
        {
            alphaW = 0.5*(z2 + q + 2*x)*m;
        }

        public void calculateDividerLiftAngle()
        {
            gamma = Math.Atan(z1/q);
        }

        public void calculateMainLiftAngle()
        {
            gammaB = Math.Acos(Math.Cos(alphaN)*Math.Cos(gamma));
        }

        public void calculateMinCoefDrag()
        {
            xMin = hAstrxAL - z2*Math.Pow(Math.Sin(alphaX), 2)/2.0;
        }

        public void calculateMaxCoefDrag()
        {
            xMax = 0.05*z2 - 0.64 + hAstrxAL - 0.024*alphaX;
        }
    }
}