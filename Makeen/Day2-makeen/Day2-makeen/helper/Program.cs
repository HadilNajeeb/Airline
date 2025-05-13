using System.Numerics;

namespace Day2_makeen.helper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello, World!");
            // Helpermathed help = new Helpermathed();
            //Console.WriteLine(help.Sum(1, 2));
            // Helpermathed.Sum(1, 2);
            //Console.WriteLine(help.PI);

            // PhoneBook.phone = new PhoneBook(3);
            //phone.AddEntry(0, "ahmed", 123456);
            // phone.AddEntry(1, "hadeel", 123456);


            PhoneBook1 book = new PhoneBook1(3);
            book["hadeel "] = 135466;
            Console.WriteLine(book["hadeel"]);




        }
    }
}
