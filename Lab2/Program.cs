namespace Lab2;

internal class Program
{
    private static Substrates _substrates = new();

    private static void Main(string[] args)
    {
        Console.WriteLine("Для подсчёта требуется ввод данных");
        Console.Write("Нажмите [1], чтобы выбрать значения варианта 25. Или [AnyKey], чтобы ввести значения вручную");

        ConsoleKeyInfo readKey = Console.ReadKey(intercept: true);
        if (readKey.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
        {
            Console.WriteLine();
            SetVariantValues();
        }
        else
        {
            InputManually();
        }

        double Vsi = _substrates.VolumeInCubeSm;
        Console.WriteLine();
        Console.WriteLine($"Объём кремния всех подложек (Vsi) [см^3] = {Vsi}");

        double n_Si = Si.CalculateMoles(Vsi);
        Console.WriteLine($"Количество вещества (n_si) [Моль] = {n_Si}");

        double n_HNO3 = n_Si * (4.0 / 3);
        double Vhno3 = HNO3.CalculateVolumeFromMoles(n_HNO3);
        Console.WriteLine();
        Console.WriteLine($"Количество необходимого вещества (n_HNO3) [Моль] = {n_HNO3}");
        Console.WriteLine($"Необходимый объём (Vhno3) [см^3] = {Vhno3}");

        double n_HF = n_Si * (18.0 / 3);
        double Vhf = HF.CalculateVolumeFromMoles(n_HF);
        Console.WriteLine();
        Console.WriteLine($"Количество необходимого вещества (n_HF) [Моль] = {n_HF}");
        Console.WriteLine($"Необходимый объём (Vhf) [см^3] = {Vhf}");
    }

    private static void SetVariantValues()
    {
        const int VariantCount = 50;
        const double VariantDiameter = 300;

        Console.WriteLine($"Количество подложек(X) = {VariantCount}");
        Console.WriteLine($"Диаметр одной подложки(D) [мм] = {VariantDiameter}");

        _substrates.Count = VariantCount;
        _substrates.Diameter = VariantDiameter;
    }

    private static void InputManually()
    {
        Console.WriteLine("Введите количество подложек (X): ");
        _substrates.Count = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите диаметр одной подложки (D) [мм]: ");
        _substrates.Diameter = Convert.ToInt32(Console.ReadLine());
    }
}