namespace Lab2
{
    internal class Substrates
    {
        // Millimeters = 20 Micrometers
        public const double SingleHeight = 0.02;

        // Millimeters
        public double Diameter;
        public int Count;

        public double Height => SingleHeight * Count;
        // mm^3
        public double Volume => (Math.PI * Math.Pow(Diameter, 2) * Height) / 4;
        public double VolumeInCubeSm => VolumeConverter.FromMmToSm(Volume);
    }
}
