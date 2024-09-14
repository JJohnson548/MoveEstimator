using System;

class Program
{
    public static void Main(string[] args)
    {

        const double HOURLY_RATE = 150.00;
        const double BASE_RATE = 200.00;
        const double PER_MILE_RATE = 2.00;

        Console.Write("Enter number of moving hours: ");
        string userHours = Console.ReadLine();

        Console.Write("Enter the number of moving miles ");
        string userMiles = Console.ReadLine();

        double hours;
        double miles;

        if (double.TryParse(userHours, out hours) && double.TryParse(userMiles, out miles))
        {
            double totalFee = BASE_RATE + (HOURLY_RATE * hours) + (PER_MILE_RATE * miles);

            Console.WriteLine($"The total moving fee is: ${totalFee:F2}");
        }
        else
        {
            Console.WriteLine("WRONG input. Please enter a number.");
        }
    }
}