Console.WriteLine("Welcome to my temperature converter app.");
do
{//Types of conversions which can be made.
    Console.WriteLine("\nKindly choose an option below:\n");
    Console.WriteLine("1. Celsius to Fahrenheit");
    Console.WriteLine("2. Fahrenheit to Celsius");
    Console.WriteLine("3. Celsius to Kelvin");
    Console.WriteLine("4. Kelvin to Celsius");
    Console.WriteLine("5. Fahrenheit to Kelvin");
    Console.WriteLine("6. Kelvin to Fahrenheir\n");

    string option = Console.ReadLine();

    switch (option)
    {

        case "1":
            Console.Write("\nEnter the temperature in Celsius: ");
            double celsiusTemp = Convert.ToDouble(Console.ReadLine());

            double fahrenheitTemp = (celsiusTemp / 5) * 9 + 32;
            Console.WriteLine($"\n{celsiusTemp} degress celsius = {fahrenheitTemp} degress Fahrenheit.\n");
            break;

        case "2":
            Console.Write("\nEnter the temperature in Fahrenheit: ");
            fahrenheitTemp = Convert.ToDouble(Console.ReadLine());

            celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
            Console.WriteLine(celsiusTemp);
            break;

        case "3":
            Console.Write("\nEnter the temperature in Celsius: ");
            celsiusTemp = Convert.ToDouble(Console.ReadLine());

            double kelvinTemp = celsiusTemp + 273.15;
            Console.WriteLine(kelvinTemp);
            break;

        case "4":
            Console.Write("\nEnter the temperature in Kelvin: ");
            kelvinTemp = Convert.ToDouble(Console.ReadLine());

            celsiusTemp = kelvinTemp - 273.15;
            Console.WriteLine(celsiusTemp);
            break;

        case "5":
            Console.Write("\nEnter the temperature in Fahrenheit: ");
            fahrenheitTemp = Convert.ToDouble(Console.ReadLine());

            kelvinTemp = (fahrenheitTemp + 459.67) * 5 / 9;
            Console.WriteLine(kelvinTemp);
            break;

        case "6":
            Console.Write("\nEnter the temperature in Kelvin: ");
            kelvinTemp = Convert.ToDouble(Console.ReadLine());

            fahrenheitTemp = (kelvinTemp * 9) / 5 - 459.67;
            Console.WriteLine(fahrenheitTemp);
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid option.");
            Console.ResetColor();
            Console.WriteLine("Choose a valid option.");
            break;
    }
    Console.WriteLine("Do you want to make another conversion? Y / N");
} while (Console.ReadLine().ToUpper() == "Y");
Console.WriteLine("Bye!");