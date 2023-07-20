using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment11
{


    public class LargeDataCollection : IDisposable
    {
        private int[] data; //I am using Array as  Internal data structure (Example: array of integers)

        public LargeDataCollection(int[] initialData)
        {
            // Here It Initialize the data structure with the initial data
            data = new int[initialData.Length];
            Array.Copy(initialData, data, initialData.Length);
        }

        //A  Method to add elements to the collection
        public void AddElement(int element)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = element;
        }

        // Its a Method to remove elements from the collection
        public bool RemoveElement(int element)
        {
            int index = Array.IndexOf(data, element);
            if (index >= 0)
            {
                for (int i = index; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                Array.Resize(ref data, data.Length - 1);
                return true;
            }
            return false;
        }

        // A Method to access elements in the collection by index
        public int GetElement(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        // Implement the Dispose method to release the resources 
        public void Dispose()
        {


            // Set the internal data structure to null to free up memory
            data = null;
        }
    }
}