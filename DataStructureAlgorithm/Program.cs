using System;
namespace DataStructureAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinarySearch binary = new BinarySearch();
            binary.ReadTextFile(@"E:\Bridgelabz\DataStructureAlgorithm\DataStructureAlgorithm\Files\BinarySearch.txt");
            binary.BinarySearchOperation("Language");
        }
    }
}