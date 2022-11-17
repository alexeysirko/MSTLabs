namespace Lab2
{
    public class Si
    {
        // Vm [sm^3/mole]
        private const double MolarVolume = 12.1;

        /// <param name="volume"> should be in sm^3 </param>
        public static double CalculateMoles(double volume) => volume / MolarVolume;
    }
}