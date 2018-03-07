using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        public static void RandomArray() 
        {
            int[] newArray = new int[10];
            Random rand = new Random();
            for (int val = 0; val < 10; val++)
            {
                newArray[val] = rand.Next(5,26);
                System.Console.WriteLine(newArray[val]);
            }
            int max = newArray[0];
            int min = newArray[0];
            int sum = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if(newArray[i] > max)
                {
                    max = newArray[i];
                }
                if(newArray[i] < min)
                {
                    min = newArray[i];
                }
                sum += newArray[i];
            }
            System.Console.WriteLine(max);
            System.Console.WriteLine(min);
            System.Console.WriteLine(sum);
        }

        public static string TossCoin()
        {
            Random rand = new Random();
            int flip = rand.Next(0,2);
            string toss = "Heads";
            if(flip == 1)
            {
                toss = "Tails";
            }
            System.Console.WriteLine($"Tossing a coin... and it landed on {toss}!");
           
            return toss;
        }

        public static void TossMultipleCoins(int num)
        {
            double tailsCount = 0;
            double headsCount = 0;
            double ratio = 0;
            for(int val = 0; val < num; val++)
            {
                if(TossCoin() == "Tails")
                {
                    tailsCount += 1;
                }
                else
                {
                    headsCount += 1;
                }
            }
            System.Console.WriteLine(tailsCount);
            System.Console.WriteLine(headsCount);
            ratio = headsCount / num;
            System.Console.WriteLine($"Wow! {num} flips of the coin and we have {headsCount} heads for a ratio of {ratio}.");
        }

        public static string[] Names()
        {
            string[] NameArray = new string[]{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            int count = 0;
            for(int i = 0; i < NameArray.Length; i++)
            {
                if(NameArray[i].Length > 5)
                {
                    count++;
                }
            }
            for(int i = 0; i < NameArray.Length; i++)
            {
                int idx = rand.Next(0, NameArray.Length);
                string temp = NameArray[i];
                NameArray[i] = NameArray[idx];
                NameArray[idx] = temp;
            }
                
            string[] newArray = new string[count];
            int newidx = 0;
            foreach(string name in NameArray)
            {
                if(name.Length > 5)
                {
                    newArray[newidx] = name;
                    newidx++;
                }
            }
            foreach(string name in newArray)
            {
                System.Console.WriteLine(name);
            }
            return newArray;

        }
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(10);
            Names();

        }
    }
}
