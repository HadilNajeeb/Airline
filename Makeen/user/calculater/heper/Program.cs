namespace calculater.heper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //Console.WriteLine("welcome");
            // Console.Write("please enter :");
            // double logged = double.Parse(Console.ReadLine());
            // Console.Write("please enter :");
            // double wage = double.Parse(Console.ReadLine());

            // Helper.example2(logged, wage);
            // double net = Helper.example2(logged, wage);
            // Console.WriteLine($"your salary is : {net}");

            Console.WriteLine("welcome");
            Console.Write("please enter :");
            string name = Console.ReadLine();

            Console.Write("please enter :");
            double wage = double.Parse(Console.ReadLine());


            Console.Write("please enter :");
            double loggedhours = double.Parse(Console.ReadLine());


            Console.Write("please enter :");
            string position = Console.ReadLine();
            


            Employee emp1 = new Employee();
            Console.WriteLine(emp1.gr)

        }
    }
}
