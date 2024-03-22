using System;

class Program
{
    
    static int BinToDec(string binary)
    {
        return Convert.ToInt32(binary, 2);
    }

    static string DecToBin(int decimalValue)
    {
        return Convert.ToString(decimalValue, 2);
    }

    static int HexToDec(string hexadecimal)
    {
        return Convert.ToInt32(hexadecimal, 16);
    }

    static string DecToHex(int decimalValue)
    {
        return Convert.ToString(decimalValue, 16).ToUpper();
    }

    static void Main(string[] args)
    {
        Start:
        while (true)
        {
            Console.WriteLine("\nWählen Sie eine Option:");
            Console.WriteLine("1. Binär zu Dezimal");
            Console.WriteLine("2. Dezimal zu Binär");
            Console.WriteLine("3. Hexadezimal zu Dezimal");
            Console.WriteLine("4. Dezimal zu Hexadezimal");
            Console.WriteLine("5. Beenden");

            Console.Write("Ihre Auswahl: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                try
                {
                Console.Write("Geben Sie die Binärzahl ein: ");
                string binaryInput = Console.ReadLine();
                Console.WriteLine("Ergebnis: " + BinToDec(binaryInput));
                }
                catch
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                    goto Start;
                }
            }
            else if (choice == "2")
            {
                Console.Write("Geben Sie die Dezimalzahl ein: ");
                try
                {
                    int decimalInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ergebnis: " + DecToBin(decimalInput));
                }
                catch
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                    goto Start;
                }
            }
            else if (choice == "3")
            {
                try
                {
                    Console.Write("Geben Sie die Hexadezimalzahl ein: ");
                    string hexInput = Console.ReadLine();
                    Console.WriteLine("Ergebnis: " + HexToDec(hexInput));
                }
                catch
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                    goto Start;
                }
            }
            else if (choice == "4")
            {
                try
                {
                Console.Write("Geben Sie die Dezimalzahl ein: ");
                int decimalInput2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ergebnis: " + DecToHex(decimalInput2));
                }
                catch
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                    goto Start;
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Auf Wiedersehen!");
                return;
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
                goto Start;
            }
        }
    }
}
