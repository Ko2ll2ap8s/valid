using System;
using System.Text.RegularExpressions;
namespace ConsoleApp44
{
    class RegexUtilities
    {

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^(?("")("".+?""@)|(([0-9a-zA-Z-а-яА-Я]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z-а-яА-Я])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z-а-яА-Я][-\w]*[0-9a-zA-Z-а-яА-Я]\.)+[a-zA-Z-а-яА-Я]{2,6}))$");
        }
        public static bool IsValuesNumber(string number)
        {
            return Regex.IsMatch(number, @"(\+7|8|\b)[\(\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[)\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)");
        }
        public static bool IsValueIP(string ip)
        {
            return Regex.IsMatch(ip, "^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
        class Program
        {
            static void Main()
            {
                Console.WriteLine(IsValidEmail("alenabushak@хренандекс.рф"));
                Console.WriteLine(IsValuesNumber("+7(937)545-15-50"));
                Console.WriteLine(IsValueIP("1.0.0.0"));

            }
        }
    }

}

