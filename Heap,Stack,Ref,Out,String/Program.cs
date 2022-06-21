//Adlari Tersine Cevirmek


using System;

namespace Heap_Stack_Ref_Out_String
{
    class Program
    {
        static void Main(string[] args)
        {
            AdlariTersineCevir();
        }
        static void AdlariTersineCevir()
        {
            string name;
            Console.Write("Add Name:");
            name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[name.Length - i - 1]);
            }

            Console.ReadKey();
        }


    }
}




