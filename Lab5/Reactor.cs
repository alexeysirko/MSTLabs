namespace Lab5
{
    internal class Reactor
    {
        public double Capacity { get; set; }
        public double Diameter { get; set; }
        public double AreaBetweenSubstratesAndWalls { get; set; }


        public double CalculateLength() => GetCapasityInCubeSm * GetSectionalArea;

        private double GetCapasityInCubeSm => Capacity * 1000; 
        private double GetSectionalArea => 4 / (Math.PI * Math.Pow(Diameter, 2));


    }
}
