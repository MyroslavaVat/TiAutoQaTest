namespace TeamI
{
    public static class FormulStore
    {
        public static double SideLength(Coordinate firstDot, Coordinate secondDot)
        {

            var sideLength = Math.Sqrt((Math.Pow(secondDot.X, 2) - 2 * secondDot.X * firstDot.X + Math.Pow(firstDot.X, 2)) +
                (Math.Pow(secondDot.Y, 2) - 2 * secondDot.Y * firstDot.Y + Math.Pow(firstDot.Y, 2)));

            return sideLength;
        }

        public static bool IsEquiLateralTriangle(double[] sidesLength)
        {
            if (sidesLength.Length != 0)
            {
                var firstElement = sidesLength[0];

                for (int i = 0; i < sidesLength.Length; i++)
                {
                    if (sidesLength[i] != firstElement)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsoscelesTriangle(double[] sidesLength)
        {
            if (sidesLength.Length != 0)
            {
                var firstElement = sidesLength[0];
                int iter = 0;

                for (int i = 0; i < sidesLength.Length; i++)
                {
                    if (sidesLength[i] == firstElement)
                    {
                        iter++;
                        if (iter == 2)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            return false;
        }

        public static bool IsRightTriangle(double[] sidesLength)
        {
            if (sidesLength[0] == sidesLength[1] + sidesLength[2])
            {
                return true;
            }
            if (sidesLength[1] == sidesLength[0] - sidesLength[2])
            {
                return true;
            }
            if (sidesLength[2] == sidesLength[0] - sidesLength[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Perimeter(double[] sidesLength)
        {
            double perimeter = 0;
            for (int i = 0; i < sidesLength.Length; i++)
            {
                perimeter = perimeter + sidesLength[i];
            }

            return perimeter;
        }

        public static double[] PowAll(double[] sidesLength)
        {
            double[] sidesLengthPow = new double[sidesLength.Length];

            for (int i = sidesLength.Length - 1, j = 0; i >= 0; i--, j++)
            {
                sidesLengthPow[j] = Math.Pow(sidesLength[i], 2);
            }

            return sidesLengthPow;
        }

    }
}

