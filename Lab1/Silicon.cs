namespace Lab1
{
    // Density - Плотность
    public class Silicon
    {
        // [g/sm^3]
        public const double Density = 2.33;
        // Y [g]
        public double MoltenWeight;
        public double CrystallizedPercentageP;
        public double CrystallizedPercentageR;
        

        public Silicon(double moltenWeight, double crystallizedPercentageP, double crystallizedPercentageR)
        {
            MoltenWeight = moltenWeight;
            CrystallizedPercentageP = crystallizedPercentageP;
            CrystallizedPercentageR = crystallizedPercentageR;
        }
    }
}
