﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BalancedParanthesis
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            Stack<string> stack = new Stack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    stack.Push(data);
                if (data.Equals(")"))
                    stack.Pop();
            }
            if (stack.Peek())
            {
                Console.WriteLine("Arithmatic Expression is balanced");
            }
            else
                Console.WriteLine("Arithmatic Expression is not balanced");
        }
    }
}