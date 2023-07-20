using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment11
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the 'LargeDataCollection' class and demonstrate its usage
            int[] initialData = { 10, 30, 50, 70, 90 };
            using (LargeDataCollection collection = new LargeDataCollection(initialData))
            {
                Console.WriteLine("Initial Data in Collection:");
                for (int i = 0; i < initialData.Length; i++)
                {
                    Console.WriteLine(collection.GetElement(i));
                }

                collection.AddElement(60);
                Console.WriteLine("Added 60 to the Collection.");

                collection.RemoveElement(30);
                Console.WriteLine("Removed 30 from the Collection.");

                Console.WriteLine("Data in Collection after Changes:");
                for (int i = 0; i < initialData.Length; i++)
                {
                    Console.WriteLine(collection.GetElement(i));
                }

                // 'Dispose' method will be called automatically after exiting the 'using' block/ above block
            }

            // After using the 'LargeDataCollection' object, its resources will be released and memory freed
            // The data ll be updated then .
        }
    }
}