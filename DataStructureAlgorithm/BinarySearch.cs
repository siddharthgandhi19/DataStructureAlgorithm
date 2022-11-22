using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BinarySearch
    {
        string[] binaryArr;
        public void ReadTextFile(string filePath)
        {
            string words = File.ReadAllText(filePath);
            binaryArr = words.Split(",");
        }
          public void BinarySearchOperation(string input)
          {
                foreach(var word in binaryArr)
                {
                     if(word == input)
                     {

                       Console.WriteLine("Found the word in the list using binary search");
                       return;
                     }
                }
                       Console.WriteLine("Search element is not available in list of words");
          }
      
    }
}