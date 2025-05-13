using Day4.Helper;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");

           // HelperMethod.print("hello");
           // HelperMethod.print(1);
            //HelperMethod.print(1.2);
            //HelperMethod.print(true);
          //  HelperMethod.Vehcile = new Vehcile();
           // HelperMethod.print(Vehcile);

            MyARRAY<int> grades = new MyARRAY<int>();
            MyARRAY<string> names = new MyARRAY<string>();
            Console.WriteLine(grades.isEmpty());
            grades.Add(1);
            grades.Add(2);
            grades.Add(3);
            grades.Add(4);
            grades.Add(5);
            grades.Add(6);

            names.Add("hadeel");
            names.Add("hadeel");
            names.Add("hadeel");
            names.Add("hadeel");
            names.Add("hadeel");
            names.Add("hadeel");
            names.display();
            Console.WriteLine(grades.isEmpty());
            Console.WriteLine(grades.count());
            grades.display();






        }
    }
}
