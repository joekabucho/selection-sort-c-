using System;

namespace forgetCode
{
    class Program
    {
        public static void Main()
        {
            int[] a = new int[100];
            int min, pass, i;
            Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("-----------------------");
            Console.WriteLine(" array elements ");
            Console.WriteLine("-----------------------");
            for (int j = 0; j < x; j++)
            {
                string s1 = Console.ReadLine();
                a[j] = Int32.Parse(s1);
                try
                {
                    a[j] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid numerical value!");

                    a[j] = int.Parse(Console.ReadLine());
                }
            }
            for (pass = 0; pass < x - 1; pass++)
            {
                min = pass;//pos_greatest=0
                for (i = pass + 1; i < x; i++)
                {
                    if (a[min] > a[i])
                        min = i;
                }//end inner loop 
                if (min != pass)
                {
                    int k = a[pass]; 
                    a[pass] = a[min];
                    a[min] = k;
                }
            }//end outer loop
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Sorted elements of an array are(selection sort)");
            for (int j = 0; j < x; j++)
            { 
                Console.WriteLine(a[j]);
        }
            Console.ReadLine();

        }
    }
}