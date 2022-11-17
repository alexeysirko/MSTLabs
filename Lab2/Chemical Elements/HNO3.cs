namespace Lab2
{
    internal class HNO3
    {
        // Vm [sm^3/mole]
        private const double MolarVolume = 41.64;

        public static double CalculateVolumeFromMoles(double moles) => moles * MolarVolume;
    }
}
