using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            char[] array = new char[100];
            string binary = "";
            int num = 0;

            //Requesting number
            Console.Write(" Enter the binary number: ");
            binary = Console.ReadLine();
            array = binary.ToCharArray();     
            
            for( int i = 0; i < array.Length; i++)
            {
                if(array[i] == '1')
                {
                    num += (int)Math.Pow(2, (double)i);
                }
            }
            Console.Write(" The binary number " + binary + " as binary {0}",num);

            Console.ReadKey();
        }
    }
}
