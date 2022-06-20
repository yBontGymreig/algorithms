using System;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] items = {1,2,3,4,5,6,8,9,10,234,1234,23,423,23,443,,234,324,432,342,324,342,234};
            Console.WriteLine(BinarySearch(items, 8));
        }
        
        static int LinearSearch(int [] items, int target){
            /*
            * Returns index of item, or -1 if item is not found.
            */
            int currentIndex = 0;
            int end = items.Length-1;

            while (currentIndex <= end){
                if(items[currentIndex]==target){
                    return currentIndex;
                }
                else{
                    currentIndex++;
                }
            }
            return -1;
        }
        //Divide and conquer always linked to logarithmic time complexities
        static int BinarySearch(int [] items, int target){
            /*
            * Returns index of item, or -1 if item is not found.
            */
            int startIndex = 0;
            int endIndex = items.Length - 1;
            int middleIndex = endIndex / 2;

            while (startIndex <= endIndex){
                if(items[middleIndex]==target){
                    return middleIndex;
                }
                else{
                    if(items[middleIndex]<target){ //target is bigger than middle
                        startIndex = middleIndex + 1;
                    }
                    else{
                        endIndex = middleIndex - 1;
                    } 
                } 
                //average of startIndex and end index        
                middleIndex = startIndex + (endIndex - startIndex)/2;
            }
            return -1;
        }
    }
}
