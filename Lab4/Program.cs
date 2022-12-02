using Lab4;
using System.Runtime.CompilerServices;

internal class Program
{
    public static double SubstrateDiameter { get => _substrateDiameter; set => _substrateDiameter = value /= 10; }

    private static double SpeedOfLayerGrowth; 
    private static double LayerThickness; 
    private static double _substrateDiameter; 
    private static int SubstratesCount;

    private const double Hour = 60;
    private const double Micro = 1e-4;
    private const double DeltaTemperature = 1080.0;
    private const double KilowatInHour = 3600000.0;

    private static void Main(string[] args)
    {
        Console.WriteLine("Для подсчёта требуется ввод данных");
        Console.WriteLine("Нажмите [1], чтобы выбрать значения варианта 25. Или [OtherKey], чтобы ввести значения вручную");

        ConsoleKeyInfo readKey = Console.ReadKey(intercept: true);
        if (readKey.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
        {
            SetVariantValues();
        }
        else
        {
            InputManually();
        }

        double heightPerHour = (LayerThickness + SpeedOfLayerGrowth * Hour) * Micro;
        Console.WriteLine($"h = {heightPerHour} см");
        
        double siVolume = Si.CalculateVolume(SubstrateDiameter, heightPerHour, SubstratesCount);
        Console.WriteLine($"V Si = {siVolume} см^3");

        double siConcentration = Si.CalculateConcentration(siVolume);
        Console.WriteLine($"n Si = {siConcentration}");

        double energy = Si.CalculateEnergy(siConcentration, DeltaTemperature);
        Console.WriteLine($"Энергия, необходимая для проведения процесса роста (длительностью 1 ч) эпитаксиального слоя кремния из дихлорсилана\n = {energy} Дж");
        Console.WriteLine($"= {energy / KilowatInHour} кВ/ч");
    }

    private static void InputManually()
    {
        Console.Write("Введите скорость роста слоя (X) [мкм/мин]: ");
        SpeedOfLayerGrowth = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите толщину слоя (Y) [мкм]: ");
        LayerThickness = Convert.ToDouble(Console.ReadLine()); 
        
        Console.Write("Введите диаметр подложек (Z) [мм]: ");
        SubstrateDiameter = Convert.ToDouble(Console.ReadLine()); 
        
        Console.Write("Введите количество одновременно загружаемых в горизонтальный реактор подложек (N): ");
        SubstratesCount = Convert.ToInt32(Console.ReadLine());
    }

    private static void SetVariantValues()
    {
        SpeedOfLayerGrowth = 5.0;
        LayerThickness = 34.0;
        SubstrateDiameter = 300.0;
        SubstratesCount = 15;
    }
}