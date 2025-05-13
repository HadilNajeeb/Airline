using System.Threading.Tasks;
using static Task_Manager.Task;

namespace Task_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Manager manager = new Manager();
            Task task1 = new Task("finish", Priority.High);
            Task task2 = new Task(".....", Priority.medium);
            task1.OnCompleted += TaskCompleted;
            task2.OnCompleted += TaskCompleted;

            manager = task1;
            manager = task2;
            manager.Display();
            Console.WriteLine(" ");
            manager[0].Completed();
            Console.WriteLine("updata task");
            manager.Display();
        }
    }
}
