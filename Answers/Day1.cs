using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2023
{
    class Day1 : Puzzle
    {   
        public Day1(string inputName) : base(inputName)
        { }
        public override string Date { get { return "2023.12.01"; } }
        public override string Answer()
        {
            Console.WriteLine(this.input[0]);
            return "Not done yet";
        }
    }
}
