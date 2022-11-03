namespace Lab1
{
    public class Tigel
    {
        // X [sm^3]
        public double MoltenIronVolume;
        // Z*(10^18) [sm^-3]
        private double _ironConcentration;
        public double IronConcentration
        {
            get => _ironConcentration * Math.Pow(10, 18);
            init => _ironConcentration = value;
        }


        public Tigel(double moltenIronVolume, double ironConcentration)
        {
            MoltenIronVolume = moltenIronVolume;
            IronConcentration = ironConcentration;
        }     
    }
}
