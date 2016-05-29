using System;

namespace DiplomaSolutions
{
    public class Utils
    {
        private static readonly double[] rollerDimensions =
        {
            1.0, 1.25, 1.4, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 4.0, 4.25, 4.5, 5.0, 5.25, 5.5, 6.0, 6.5,
            7.0,
            8.0, 9.0, 10.0, 11.0, 12.0, 14.0, 15.0, 16.0, 18.0, 20.0, 22.0, 25.0, 28.0, 30.0, 35.0
        };

        public static double chooseRollerDimension(double compareTo)
        {
            compareTo *= 1.67;
            for (var i = 0; i < rollerDimensions.Length - 1; i++)
            {
                if (rollerDimensions[i] >= compareTo)
                {
                    return rollerDimensions[i];
                }
            }
            return Math.Ceiling(compareTo);
        }

        public static string formatter(double number)
        {
            return number.ToString("#.000");
        }

        public class Angle
        {
            public int degrees;
            public int minutes;
            public int seconds;
        }
    }
}