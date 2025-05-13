using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_makeen.helper
{
    internal class PhoneBook1
    {
        private string[] Name;
        private int Size;
        private int[] Number;

        public  PhoneBook1( int Size)
        {
            this.Size = Size;

            this.Name = new string[Size];
            this.Number = new int[Size];
        }
        public int this[string Name]
        {
            get
            {
                for(int i = 0; i < this.Name.Length; i++)
                {
                    if (this.Name[i] == Name)
                    {
                        return Number[i];
                    }
                }
                return -1;
            }
            set
            {

            }
        }
    }
}
