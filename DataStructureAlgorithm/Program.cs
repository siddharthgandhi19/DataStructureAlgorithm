using DataStructureAlgorithm.DataStructureAlgorithm;
using System;
namespace DataStructureAlgorithm
{
    class Program
    {
        public static string textPath = @"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt";
        public static string numberPath = @"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\Number.txt";
        public static string paranthesisPath = @"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BalancedParanthesis.txt";
        public static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to Stack and Queue problem Statement");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. Binary Search\n 2. Insertion Sorting\n 3. Bubble Sorting\n 4. Anagram Detectiong\n 5. UnOrdered List\n 6. Ordered List\n 7. Balance Parentheses\n 8. Prime Number Range\n 9. UserInput ");
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
                        int[] binaryArr = { 2, 5, 4, 1, 3 };
                        insertionSort.Sort(binaryArr);
                        break;

                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] arr = { 20, 50, 40, 10, 30 };
                        bubbleSort.Sort(arr);
                        break;

                    case 4:
                        AnagramDetection anagramDetection = new AnagramDetection();
                        anagramDetection.CheckAnagram("heart","earth");
                        anagramDetection.CheckAnagram("heart", "erth");
                        break;
                    case 5:
                        UnOrderedList unOrderedList = new UnOrderedList();
                        unOrderedList.ReadAllTextFile(textPath);
                        break;
                    case 6:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadTextFile(numberPath);
                        break;
                    case 7:
                        BalancedParanthesis check = new BalancedParanthesis();
                        check.ReadTextFile(paranthesisPath);
                        break;
                    case 8:
                        PrimeNumberRange range = new PrimeNumberRange();
                        range.Range(0, 1000);
                        break;
                    case 9:
                        UserInput input = new UserInput();
                        input.ReplaceString();
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