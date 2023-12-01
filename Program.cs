using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Puzzle> AnswerList = new List<Puzzle> {
                new Day1("day1_input.txt")
            };

            foreach(var i in AnswerList)
            {
                Console.WriteLine($"Day {i.Index}: {i}");
            }

            Console.ReadKey();
        }
    }
}
