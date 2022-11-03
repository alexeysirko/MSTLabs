namespace Lab1
{
    // Numerator - Числитель
    // Denominator - Знаменатель
    public static class ConcentrationCalculator
    {
        // k0
        private const double SegregationCoef = 6e-5;

        public static double GetBeginConcentrationInSolidPhase(Tigel crusible, Silicon silicon) 
            => GetConcentrationInSolidPhase(crusible, silicon, silicon.CrystallizedPercentageP);
        public static double GetTailConcentrationInSolidPhase(Tigel crusible, Silicon silicon) 
            => GetConcentrationInSolidPhase(crusible, silicon, silicon.CrystallizedPercentageR);
        

        public static double GetInitialIronConcentrationInMelt(Tigel crusible, Silicon silicon)
        {
            double numerator = crusible.MoltenIronVolume * crusible.IronConcentration;
            double denominator = (silicon.MoltenWeight / Silicon.Density) + crusible.MoltenIronVolume;
            return numerator / denominator;
        }

        private static double GetConcentrationInSolidPhase(Tigel crusible, Silicon silicon, double crystallizedPercentage)
        {
            double initialIronConcentrationInMelt = GetInitialIronConcentrationInMelt(crusible, silicon);
            double expression = Math.Pow(1 - crystallizedPercentage, SegregationCoef - 1);
            return SegregationCoef * initialIronConcentrationInMelt * expression;
        }
    }
}
