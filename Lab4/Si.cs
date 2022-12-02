namespace Lab4;

internal class Si
{
    // Теплоёмкость
    private const double C = 20.16;
    private const double MolarVolume = 12.1;

    public static double CalculateVolume(double substrateDiameter, double height, double substratesCount)
        => (Math.PI * Math.Pow(substrateDiameter, 2) * height) / 4.0 * substratesCount;

    public static double CalculateConcentration(double volume) => volume / MolarVolume;

    public static double CalculateEnergy(double atomsCount, double deltaTemperature)
        => C * atomsCount * deltaTemperature;
}
