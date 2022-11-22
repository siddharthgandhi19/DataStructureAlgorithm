using System;
namespace DataStructureAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue problem Statement");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. Binary Search\n 2. Insertion Sorting  ");
                Console.WriteLine("Enter above mention option");
                int option = Convert.ToInt32(Console.ReadLine());                
                switch (option)
                {
                    case 1:
                        BinarySearch binary = new BinarySearch();
                        binary.ReadTextFile(@"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt");
                        binary.BinarySearchOperation("Language");
                        break;

                   case 2:
                        InsertionSort insertionSort = new InsertionSort();
                        int[] arr = { 2, 5, 4, 1, 3 };
                        insertionSort.Sort(arr);
                        break;

                   default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
              
            }
               
        }
    }
}