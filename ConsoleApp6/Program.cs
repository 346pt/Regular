using System.Text.RegularExpressions;

namespace ConsoleAApp6
{
    class Program
    {
        static void Main()

        {
            Regex r = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\D\d\d?)\.?){4}$");
            string text1 = "ip = 145.92.137.11";
            string text2 = "ip = 255.255.240.0";
            string text3 = "ip = 217.9.142.131";
            string text4 = "ip = 142.9.199.545";
            string text5 = "ip = 317.9.191.133";
            Console.WriteLine(r.IsMatch(text1));
            Console.WriteLine(r.IsMatch(text2));
            Console.WriteLine(r.IsMatch(text3));
            Console.WriteLine(r.IsMatch(text4));
            Console.WriteLine(r.IsMatch(text5));
        }
    }
}