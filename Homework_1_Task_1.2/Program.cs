using System;
using System.Globalization;

namespace Homework_1_Task_1._2
{
    class Program
    {
        static bool IsLong(string s)
        {
            return long.TryParse(s, out _);
        }
        static bool IsDouble(string s)
        {
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            return double.TryParse(s, style, culture, out _);
        }
        static bool IsBool(string s)
        {
            return bool.TryParse(s, out _);
        }
        static string GetType(string s)
        {
            if (IsLong(s))
                return "целое число";
            if (IsDouble(s))
                return "дробное число";
            if (IsBool(s))
                return "булевое значение";
            return "текст";
        }
        static void Main(string[] args)
        {
            Console.Write("Введите что-то: ");
            string text;
            text = Console.ReadLine();
            Console.WriteLine("Введенное что-то имеет тип: " + GetType(text));
        }
    }
}
