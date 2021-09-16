using System;
//computes the largest subarray with contiguous elements.
//Example.
//Input:  arr[] = { 1, 56, 58, 57, 90, 92, 94, 98, 99, 93, 91, 45};
//Output: Length of the longest contiguous subarray is 5  
class longestContiguousSubarray
{

    // Returns length of the longest contiguous (touching) subarray 
    static int findLength(int[] arr, int n)
    {
        int max_len = 1; // results 
        for (int i = 0; i < n - 1; i++)
        {
            // set min and max for subarrays 
            int mn = arr[i], mx = arr[i];

            // subarrays starting with i and ending with j 
            for (int j = i + 1; j < n; j++)
            {
                // min and max in subarray 
                mn = Math.Min(mn, arr[j]);
                mx = Math.Max(mx, arr[j]);
 
                // check for contiguous elements 
                if ((mx - mn) == j - i)
                    max_len = Math.Max(max_len,
                                  mx - mn + 1);
            }
        }
        return max_len; // Return result 
    }

    public static void Main()
    {

        //int[] arr = { 1, 56, 58, 57, 90, 92, 94, 93, 91, 45 }; //5
        int[] arr = { 10, 12, 11 }; //3
        //int[] arr = { 14, 12, 11, 20 }; //2
        int n = arr.Length;

        Console.WriteLine("Length of the longest"
                     + " contiguous subarray is "
                           + findLength(arr, n));
        
    }
}