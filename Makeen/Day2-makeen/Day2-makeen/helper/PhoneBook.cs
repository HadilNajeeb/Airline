using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day2_makeen.helper
{
    internal class PhoneBook
    {
        private string[] Name;
        private int Size;
        private int[] Number;

        public void Phone(string Name, int Size, int Number)
        {
            this.Size = Size;

            this.Name = new string[Size];
            this.Number = new int[Size]; 
            

        }

        public void AddEntry(int index , string name , int number)
        {
            Name[index] = name;
            Number[index] = number;
        }
        public void Getrecord(int index)
        {
            Console.WriteLine($"Name{Name[index]}, Number: {Number[index]} ");

        }
        public void Getrecord(string name)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == name)
                {
                    Console.WriteLine($"Name{Name[inde]}, Number: {Number[i]} ");
                }
            }

        }
    }
    
}
