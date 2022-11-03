using Lab1;

Console.WriteLine("Для подсчёта требуется ввод данных:");

    Console.Write("Материала тигля расстворилось (X [см^3]): ");
    double moltenIronVolume = Convert.ToDouble(Console.ReadLine());

    Console.Write("Вес расплава кремния (Y [г]): ");
    double moltenSiliconWeight = Convert.ToDouble(Console.ReadLine());

    Console.Write("Концентрация железа в материале (Z [см^-3]): ");
    double ironConcentration = Convert.ToDouble(Console.ReadLine());

    Console.Write("Доля закристаллизовавшегося расплава в затравочной части (Р [%]): ");
    double crystallizedPrecentageP = Convert.ToDouble(Console.ReadLine());

    Console.Write("Доля в хвостовой части (R [%]): ");
    double crystallizedPrecentageR = Convert.ToDouble(Console.ReadLine());

Tigel crusible = new(moltenIronVolume, ironConcentration);
Silicon silicon = new(moltenSiliconWeight, crystallizedPrecentageP, crystallizedPrecentageR);

double initialIronConcentration = ConcentrationCalculator.GetInitialIronConcentrationInMelt(crusible, silicon);
double beginConcentrationInSolidPhase = ConcentrationCalculator.GetBeginConcentrationInSolidPhase(crusible, silicon);
double tailConcentrationInSolidPhase = ConcentrationCalculator.GetTailConcentrationInSolidPhase(crusible, silicon);

Console.WriteLine("\nРезультаты подсчётов:");
Console.WriteLine($"Первоначальная концентрация примеси в расплаве = {initialIronConcentration}");
Console.WriteLine($"Концентрацию железа в затравочной части слитка = {beginConcentrationInSolidPhase}");
Console.WriteLine($"Концентрацию железа в хвостовой части слитка = {tailConcentrationInSolidPhase}");