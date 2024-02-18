﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum=int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());

            for (int i = firstNum; i <=secondNum; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j%2==0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum+=currentDigit;
                    }
                }
                if (oddSum==evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
