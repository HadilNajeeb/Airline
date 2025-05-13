namespace AnimalSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



        public abstract class Animals
        {
            public string animalName;


            public Animals(string name)
            {
                animalName = name;
            }


            public abstract void MakeSound();
        }

        public class Dog : Animals
        {
            public Dog(string name) : base(name) { }

            public override void MakeSound()
            {
                Console.WriteLine(animalName + " says: Woof!");
            }
        }

        public class Cat : Animals
        {
            public Cat(string name) : base(name) { }

            public override void MakeSound()
            {
                Console.WriteLine(animalName + " says: Meow!");
            }
        }

        public class Cow : Animals
        {
            public Cow(string name) : base(name) { }

            public override void MakeSound()
            {
                Console.WriteLine(animalName + " says: Moo!");
            }
        }
    }
}

