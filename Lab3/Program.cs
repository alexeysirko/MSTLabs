using Lab3;

internal class Program
{
    private const double SiO2Volume = 1.0;

    private static double _clConcentration;
    private static double ClConcentration
    { 
        get => _clConcentration * Math.Pow(10, 18); 
        set => _clConcentration = value; 
    }

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

        double countOfAtomsSio2 = SiO2.CalculateCountOfAtoms(SiO2Volume);
        Console.WriteLine($"Количество атомов SiO2 = {countOfAtomsSio2}");

        double percentOfClInSiO2 = SiO2.CalculatePrecentOfElementInTape(ClConcentration, countOfAtomsSio2);
        Console.WriteLine($"Процентное содержание Cl(%) в плёнке SiO2 = {percentOfClInSiO2}%");
    }

    private static void InputManually()
    {
        Console.Write("Введите концентрацию хлора в начальных слоях осаждённой плёнки  SiO2 (C) [см^-3]: ");
        ClConcentration = Convert.ToDouble(Console.ReadLine());
    }

    private static void SetVariantValues()
    {
        const double VariantConcentration = 4.0;
        ClConcentration = VariantConcentration;
    }
}