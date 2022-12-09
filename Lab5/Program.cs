using Lab5;

internal class Program
{
    private static double _volumeFlow;
    private static Reactor _reactor = new();

    private static void Main(string[] args)
    {
        SetVariantValues();

        double linearFlow = _volumeFlow / _reactor.AreaBetweenSubstratesAndWalls;
        Console.WriteLine($"Линейная скорость расхода (U) = {linearFlow} [см/мин]");

        double reactorHeight = _reactor.CalculateLength();
        Console.WriteLine($"Длина реактора (h) = {reactorHeight} [см]");

        double timeInReactor = reactorHeight / linearFlow;
        Console.WriteLine($"Длительность пребывания газа в реакторе (t): {timeInReactor} [мин]");
    }

    private static void SetVariantValues()
    {
        Console.WriteLine("Установлены значения варианта 25");
        _volumeFlow = 602;
        Console.WriteLine($"Объемный расход (V): {_volumeFlow} [см^3/мин]");

        _reactor.Capacity = 68;
        Console.WriteLine($"Объём реактора (L): {_reactor.Capacity} [л]");
        _reactor.Diameter = 270;
        Console.WriteLine($"Диаметр реактора (D): {_reactor.Diameter} [см]");
        _reactor.AreaBetweenSubstratesAndWalls = 165;
        Console.WriteLine($"Площадь между подложками и стенками реактора (S): {_reactor.AreaBetweenSubstratesAndWalls} [см^2]");
    }
}