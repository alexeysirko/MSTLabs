internal class Program
{
    private static double 

    private static void Main(string[] args)
    {
        Console.WriteLine("Для подсчёта требуется ввод данных");
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
    }

    private static void InputManually()
    {
        
    }

    private static void SetVariantValues()
    {
        
    }
}