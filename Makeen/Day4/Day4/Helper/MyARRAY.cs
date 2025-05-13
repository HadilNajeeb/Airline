using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Helper
{
    internal class MyARRAY<T>
    {
        private T[] array;
        public void Add(T element)
        {
            if (array is null)
            {
                array = new T[] { element };
            }
            else
            {
                int length = array.Length;
                T[] temp = new T[length+1];
                for (int i = 0; i< length; i++)
                {
                    temp[i] = array[i];
                }
                temp[temp.Length - 1] = element;
                array = temp;
            }
        }

        public int count ()
        {
            return array.Length;
        }
        public void Removeat(int index)
        {
            if (index < 0 || index >= array.Length - 1)
            {
                return;
            }
            int pos = 0;
            T[] temp = new T[pos + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (index == 1)
                {
                    continue;
                }
                temp[i] = array[i];
            }
        }

        public bool isEmpty=> array is null || array.Length == 0;   
       public int Count => array.Length;    
        public void display()
        {
            Console.Write("");
            foreach (T element in array)
            {
                Console.Write(element); 
            }
        }

    }
}
