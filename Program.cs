namespace PracticeGenericArray
{
    internal class Program
    {


        //class GFG
        //{
        //     // An optimized version of Bubble Sort
        //     //static void bubbleSort(int[] arr, int n)
        //     //{
        //     //    int a, b, notParmanent;
        //     //    bool swap;
        //     //    for (a = 0; a < arr.Length; a++)
        //     //    {
        //     //        swap = false;
        //     //        for(b=0;b<)
        //     //    }
        //     //    int i, j, temp;
        //     //    bool swapped;
        //     //    for (i = 0; i < n - 1; i++)
        //     //    {
        //     //        swapped = false;
        //     //        for (j = 0; j < n - i - 1; j++)
        //     //        {
        //     //            if (arr[j] > arr[j + 1])
        //     //            {

        //     //                // Swap arr[j] and arr[j+1]
        //     //                temp = arr[j];
        //     //                arr[j] = arr[j + 1];
        //     //                arr[j + 1] = temp;
        //     //                swapped = true;
        //     //            }
        //     //        }

        //     //        // If no two elements were
        //     //        // swapped by inner loop, then break
        //     //        if (swapped == false)
        //     //            break;
        //     //    }
        //     //}

        //     // Function to print an array
        //     //static void printArray(int[] arr, int size)
        //     //{
        //     //    int i;
        //     //    for (i = 0; i < size; i++)
        //     //        Console.Write(arr[i] + " ");
        //     //    Console.WriteLine();
        //     //}

        //     // Driver method
        //     static void Main(string[] args)
        //     {
        //         int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        //         int n = arr.Length;
        //         bubbleSort(arr, n);
        //         Console.WriteLine("Sorted array:");
        //         //printArray(arr, n);
        //     }
        //}


        //class GFG
        //{
        //    //public static int search(int[] arr, int N, int x)
        //    //{
        //    //    for (int i = 0; i < N; i++)
        //    //    {
        //    //        if (arr[i] == x)
        //    //            return i;
        //    //    }
        //    //    return -1;
        //    //}

        //    //public static string search(string[] arr, int N, string x)
        //    //{
        //    //    for (int i = 0; i < N; i++)
        //    //    {
        //    //        if (arr[i] == x)
        //    //            return i;
        //    //    }
        //    //    return -1;
        //    //}



        //    //public static T search<T>(T[] arr, int N, T x)
        //    //{
        //    //    for (int i = 0; i < N; i++)
        //    //    {
        //    //        if (arr[i].Equals(x))
        //    //            return arr[i];
        //    //    }
        //    //    return default(T);
        //    //}
        //    //// Driver's code 

        //}
        //static void Main(string[] args)
        //{
        //   // int[] arr = { 2, 3, 4, 10, 40 };
        //   //// string[] arr2 = { "Zishan", "araf", "rafsan", "rafa" };
        //   // int x = 10;
        //   // Console.WriteLine("Enter a name which you want to serach:");
        //    //string name=Console.ReadLine();
           
        //    // Function call 
        //    //int result = GFG.search(arr, arr.Length, x);
        //    //if (result == -1)
        //    //    Console.WriteLine(
        //    //        "Element is not present in array");
        //    //else
        //    //    Console.WriteLine("Element is present at index "
        //    //                      + result);

        //    //string results=GFG.search(arr2, arr2.Length, name );


            
        //    string[] arr2 = { "Zishan", "araf", "rafsan", "rafa" };
        //    Console.WriteLine("Enter a name which you want to search:");
        //    string name = Console.ReadLine();
        //    var results = GFG.search(arr2, arr2.Length, name);

        //    if (results == null)
        //        Console.WriteLine("Element is not present in array");
        //    else
        //        Console.WriteLine("Element is present at: " + T);
        //}


        class GFG
        {
            public static int search<T>(T[] arr, int N, T x) 
            { for (int i = 0; i < N; i++) 
                { if (EqualityComparer<T>.Default.Equals(arr[i], x))
                        return i; 
                } return -1; 
            }        
            // Driver's code
            
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 10, 40 };
            int x1 = 10;
            int result1 = GFG.search(arr1, arr1.Length, x1);
            if (result1 == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result1);
            string[] arr2 = { "apple", "banana", "orange", "grape", "pear" };
            string x2 = "grape";
            int result2 = GFG.search(arr2, arr2.Length, x2);
            if (result2 == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result2);
        }
    }
}