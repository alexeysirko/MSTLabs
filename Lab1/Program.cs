using Lab1;

internal class Program
{
    private static double _moltenIronVolume;
    private static double _moltenSiliconWeight;
    private static double _ironConcentration;
    private static double _crystallizedPrecentageP;
    private static double _crystallizedPrecentageR;

    private static void Main(string[] args)
    {
        Console.WriteLine("Для подсчёта требуется ввод данных:");
        Console.WriteLine("Нажмите [1], чтобы выбрать значения варианта 25. Или [AnyKey], чтобы ввести значения вручную");
        ConsoleKeyInfo readKey = Console.ReadKey(intercept: true);
        if (readKey.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
        {
            SetVariantValues();
        }
        else
        {
            InputManually();
        }

        Tigel tigel = new(_moltenIronVolume, _ironConcentration);
        Silicon silicon = new(_moltenSiliconWeight, _crystallizedPrecentageP, _crystallizedPrecentageR);

        double initialIronConcentration = ConcentrationCalculator.GetInitialIronConcentrationInMelt(tigel, silicon);
        double beginConcentrationInSolidPhase = ConcentrationCalculator.GetBeginConcentrationInSolidPhase(tigel, silicon);
        double tailConcentrationInSolidPhase = ConcentrationCalculator.GetTailConcentrationInSolidPhase(tigel, silicon);

        Console.WriteLine("\nРезультаты подсчётов:");
        Console.WriteLine($"Первоначальная концентрация примеси в расплаве = {initialIronConcentration}");
        Console.WriteLine($"Концентрацию железа в затравочной части слитка = {beginConcentrationInSolidPhase}");
        Console.WriteLine($"Концентрацию железа в хвостовой части слитка = {tailConcentrationInSolidPhase}");
    }


    private static void SetVariantValues()
    {
        const double VariantMoltenIronVolume = 540;
        const double VariantMoltenSiliconWeight = 16740;
        const double VariantIronConcentration = 4.4;
        const double VariantCrystallizedPrecentageP = 0.12;
        const double VariantCrystallizedPrecentageR = 0.66;

        Console.WriteLine($"Материала тигля расстворилось (X [см^3]) = {VariantMoltenIronVolume}");
        _moltenIronVolume = VariantMoltenIronVolume;
        Console.WriteLine($"Вес расплава кремния (Y [г]) = {VariantMoltenSiliconWeight}");
        _moltenSiliconWeight = VariantMoltenSiliconWeight;
        Console.WriteLine($"Концентрация железа в материале (Z [см^-3]) = {VariantIronConcentration}");
        _ironConcentration = VariantIronConcentration;
        Console.WriteLine($"Доля закристаллизовавшегося расплава в затравочной части (Р [%]) = {VariantCrystallizedPrecentageP}");
        _crystallizedPrecentageP = VariantCrystallizedPrecentageP;
        Console.WriteLine($"Доля в хвостовой части (R [%]) = {VariantCrystallizedPrecentageR}");
        _crystallizedPrecentageR = VariantCrystallizedPrecentageR;
    }

    private static void InputManually()
    {
        Console.Write("Материала тигля расстворилось (X [см^3]): ");
        _moltenIronVolume = Convert.ToDouble(Console.ReadLine());
        Console.Write("Вес расплава кремния (Y [г]): ");
        _moltenSiliconWeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Концентрация железа в материале (Z [см^-3]): ");
        _ironConcentration = Convert.ToDouble(Console.ReadLine());
        Console.Write("Доля закристаллизовавшегося расплава в затравочной части (Р [%]): ");
        _crystallizedPrecentageP = Convert.ToDouble(Console.ReadLine());
        Console.Write("Доля в хвостовой части (R [%]): ");
        _crystallizedPrecentageR = Convert.ToDouble(Console.ReadLine());
    }
}