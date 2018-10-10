using System;

namespace InsertionSort
{
    class Program
    {
    static void sort(int[] arr){
        int inIndex,outIndex;
        for(outIndex=1; outIndex<arr.Length;outIndex++){
            var temp = arr[outIndex];
            inIndex =outIndex;
            while(inIndex > 0 && arr[inIndex-1] >= temp){
                arr[inIndex] = arr[inIndex-1];
                --inIndex;
            }
            arr[inIndex] = temp;
            }
    }
    // Prints the array 
    static void printArray(int []arr) 
    { 
        int n = arr.Length; 
        for (int i=0; i<n; ++i) 
            Console.Write(arr[i]+" "); 
        Console.WriteLine(); 
    } 
  
    // Driver code  
    public static void Main() 
    { 
        int []arr = {64,25,12,22,11}; 
        sort(arr); 
        Console.WriteLine("Sorted array"); 
        printArray(arr); 
    } 
    }
}
