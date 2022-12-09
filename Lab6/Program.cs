internal class Program
{
    private static double _tapeThickness;
    private static double AInFormula;
    private static double BInFormula;

    private static void Main(string[] args)
    {
        SetVariantValues();

        double time = CalculateTime(_tapeThickness, AInFormula, BInFormula);
        Console.WriteLine($"Времени потребуется для выращивания плёнки {time} часов");
        Console.WriteLine($"Что равно {ConvertToSeconds(time)} секунд");
    }

    private static double CalculateTime(double tapeThickness, double AInFormula, double BInFormula) 
        => (Math.Pow(tapeThickness, 2) + AInFormula * tapeThickness) / BInFormula;

    private static double ConvertToSeconds(double hours) 
        => hours * 3600;

    private static void SetVariantValues()
    {
        Console.WriteLine("Установлены значения варианта 25");
        _tapeThickness = 2;
        Console.WriteLine($"Толщина окисла плёнки SiO2 (X): {_tapeThickness}[мкм]");
        Console.WriteLine("Уравнение d^2+Ad=B(t+τ)");
        AInFormula = 0.5;
        Console.WriteLine($"В котором A: {AInFormula}");
        BInFormula = 0.203;
        Console.WriteLine($"И B: {AInFormula}");
    }
}