namespace Resistor_color_trio
{
    internal class Program
    {

        static Dictionary<string, int> colorValues = new Dictionary<string, int>()
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9}
    };

        static void Main()
        {

            Console.WriteLine("Введіть перший колір:");
            string color1 = Console.ReadLine().ToLower();

            Console.WriteLine("Введіть другий колір:");
            string color2 = Console.ReadLine().ToLower();

            Console.WriteLine("Введіть третій колір:");
            string color3 = Console.ReadLine().ToLower();


            if (!colorValues.ContainsKey(color1) || !colorValues.ContainsKey(color2) || !colorValues.ContainsKey(color3))
            {
                Console.WriteLine("Некоректні кольори. Переконайтеся, що кольори правильні.");
                return;
            }


            int firstDigit = colorValues[color1];
            int secondDigit = colorValues[color2];
            int multiplier = colorValues[color3];

            int baseValue = firstDigit * 10 + secondDigit;


            int resistance = baseValue * (int)Math.Pow(10, multiplier);


            string result = resistance >= 1000 ? $"{resistance / 1000} кілоом" : $"{resistance} Ом";

            Console.WriteLine($"Резистор має значення: {result}");
        }
    }
}
