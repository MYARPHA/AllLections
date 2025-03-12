namespace Lection3
{
    internal class ExtendedRandom : Random
    {
        public double NextDouble(double minValue, double maxValue)
            => NextDouble() * (maxValue - minValue) + minValue;
    } 
}
