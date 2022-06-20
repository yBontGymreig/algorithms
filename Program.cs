using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 44, 54, 5, 7, 4 };
            BadBubbleSort(items);
            //PrintArrayOfInts(items);
        }


        /*
        * Returns index of item, or -1 if item is not found.
        */
        static int LinearSearch(int[] items, int target)
        {
            int currentIndex = 0;
            int end = items.Length - 1;

            while (end < currentIndex)
            {
                if (items[currentIndex] == target)
                {
                    return currentIndex;
                }
                else
                {
                    currentIndex++;
                }
            }
            return -1;
        }

        static void BubbleSort(int[] items)
        {
            bool swapped = true;
            int end = items.Length - 2;
            while (swapped)
            {
                //check whether a swap has been made on a pass. No swap means items are sorted
                swapped = false;
                // on each pass, iterate through items, stopping one position earlier on each pass
                for (int i = 0; i <= end; i++)
                {
                    //if pair of neighbouring items are out of order
                    if (items[i] > items[i + 1])
                    {
                        //swap
                        int temp = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = temp;
                        swapped = true;
                    }
                }
                //after a pass, top item is sorted so you can end one pos earlier
                end--;

                PrintArrayOfInts(items);

            }

        }

        static void BadBubbleSort(int[] items)
        {
            for (int pass = 1; pass <= items.Length-1; pass++)
            {
                // on each pass, iterate through items, stopping one position earlier on each pass
                for (int i = 0;  i < items.Length-1; i++)
                {
                    //if pair of neighbouring items are out of order
                    if (items[i] > items[i + 1])
                    {
                        //swap
                        int temp = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = temp;
                    }
                }
                PrintArrayOfInts(items);
            }
        }


        static void PrintArrayOfInts(int[] nums)
        {
            //TODO it would be nicer to print these across the screen rather than one on each line.
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
            System.Console.WriteLine("");
        }
    }
}
