namespace Lab2
{
    internal class HF
    {
        // Vm [sm^3/mole]
        private const double MolarVolume = 15.9;

        public static double CalculateVolumeFromMoles(double moles) => moles * MolarVolume;
    }
}
