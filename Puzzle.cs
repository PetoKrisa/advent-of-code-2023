using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_Of_Code_2023
{
    abstract class Puzzle
    {   //constructor
        public Puzzle(string inputName)
        {
            this.input = File.ReadAllText($"inputs/{inputName}").Split('\n').ToList();
        }
        //information
        public abstract string Date { get; }
        public string Index { get {return this.GetType().Name.Replace("Day", ""); } }

        internal List<string> input;
        //solution
        public abstract string Answer();

        public override string ToString()
        {
            return Answer();
        }
    }
}
