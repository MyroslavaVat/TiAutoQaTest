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
    }
}
