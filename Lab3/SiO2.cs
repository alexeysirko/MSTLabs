namespace Lab3;

public class SiO2
{
    private const double MolarVolume = 23.1;
    private const double AvogadroNumber = 6.022E23;

    public static double CalculateCountOfAtoms(double volume) 
        => (volume / MolarVolume) * AvogadroNumber * 3.0;

    public static double CalculatePrecentOfElementInTape(double ElementConcentration, double SiO2countOfAtoms)
        => ElementConcentration / SiO2countOfAtoms * 100;
}
