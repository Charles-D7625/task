namespace task;

class Program
{

    public static string ComputerAmount(int amount) {

        if (amount == 0 || (amount >= 5 && amount <= 20)) {
            return amount.ToString() + " компьютеров";
        }

        if (amount % 10 == 1) {
            return amount.ToString() + " компьютер";
        }

        if (amount % 10 >= 2 && amount % 10 <= 4) {
            return amount.ToString() + " компьютера";
        }

        return amount.ToString() + " компьютеров";
    }

    static void Main(string[] args)
    {
        int amount;

        Console.Write("Write number: ");

        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out amount))
                break; 
            else 
            {
                Console.WriteLine("Invalid input");
            }
        }

        Console.WriteLine(ComputerAmount(amount));
    }
}
