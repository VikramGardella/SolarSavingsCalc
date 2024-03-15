using System;
using System.Security.Cryptography.X509Certificates;

class Program{
    public static void Main(string[] args){

        //Initialize Potential Customer Initial Input Variables
        double customerProjectedAnnualUsage; //Electricity used in kilowatt-hours
        string customerPropertyState; //Location of property potentially converted to solar powered for billing estimates
        double customerPropertyArea;

        //Initialize Economical Savings Variables
        double initialSetupCost; //Initial hardware + labor cost customer would have to incur for switching to solar power
        double stateCostPerKiloWattHour;
        double annualTaxWriteOff; //Government's pecuniary incentive for switching to renewable energy source

        //Initialize Ecological Savings Variables
        double reduxCarbonMonoxide = 0;
        double reduxCarbonDioxide = 0;
        double reduxPollutantA = 0;
        double reduxPollutantB = 0;
        double reduxPollutantC = 0;
        double reduxCarcinogenX = 0;
        double reduxCarcinogenY = 0;
        double reduxCarcinogenZ = 0;

        //Input Potential Customer's Data
        Console.WriteLine("\nWhat is the projected amount of electricity consumed by this property in kilowatt-hours?");
        customerProjectedAnnualUsage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nIn which state is this property located?");
        customerPropertyState = Console.ReadLine();
        Console.WriteLine("\nWhat is the land area of the property in square feet?");
        customerPropertyArea = Convert.ToDouble(Console.ReadLine());

        annualTaxWriteOff = 5000;
        initialSetupCost = 0.2 * (customerProjectedAnnualUsage / customerPropertyArea);

        if (customerPropertyState == "Ohio") {
            stateCostPerKiloWattHour = 0.03;
            annualTaxWriteOff *= 1.05;
        }
        else {
            stateCostPerKiloWattHour = 0.13;
        }

        double annualRunningSavings = customerProjectedAnnualUsage * stateCostPerKiloWattHour;
        double profit = -initialSetupCost;

        for (int year = 1; year <= 30; year++) {
            profit += (annualRunningSavings + annualTaxWriteOff);
            reduxCarbonMonoxide += (customerProjectedAnnualUsage*400);
            reduxCarbonDioxide += (customerProjectedAnnualUsage*250);
            reduxPollutantA += (customerProjectedAnnualUsage*300);
            reduxPollutantB += (customerProjectedAnnualUsage*600);
            reduxPollutantC += (customerProjectedAnnualUsage*50);
            reduxCarcinogenX += (customerProjectedAnnualUsage*20);
            reduxCarcinogenY += (customerProjectedAnnualUsage*12);
            reduxCarcinogenZ += (customerProjectedAnnualUsage*3);

            Console.WriteLine("\n\nAfter " + year + " years:\n");
            Console.WriteLine("Profit = $" + Math.Round(profit, 2));
            Console.WriteLine("Aggregate Environmental Impact:\n");
            Console.WriteLine("Carbon Monoxide = " + Convert.ToDouble(reduxCarbonMonoxide) + " grams");
            Console.WriteLine("Carbon Dioxide = " + Convert.ToDouble(reduxCarbonDioxide) + " grams");
            Console.WriteLine("Pollutant A = " + Convert.ToDouble(reduxPollutantA) + " grams");
            Console.WriteLine("Pollutant B = " + Convert.ToDouble(reduxPollutantB) + " grams");
            Console.WriteLine("Pollutant C = " + Convert.ToDouble(reduxPollutantC) + " grams");
            Console.WriteLine("Carcinogen X = " + Convert.ToDouble(reduxCarcinogenX) + " grams");
            Console.WriteLine("Carcinogen Y = " + Convert.ToDouble(reduxCarcinogenY) + " grams");
            Console.WriteLine("Carcinogen Z = " + Convert.ToDouble(reduxCarcinogenZ) + " grams");
            
        }
    }
}