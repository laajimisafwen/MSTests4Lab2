using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToBeTested
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The input array can't be NULL !!!",
                nameof(array));
            }
            if (array.Length == 0)
            {
                return;
            }
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }
    }
}
