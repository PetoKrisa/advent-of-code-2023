using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2023
{
    class Day1 : Puzzle
    {
        public Day1(string inputName) : base(inputName) { }
        public override string Date { get { return "2023.12.01"; } }
        public override string Answer1()
        {
            string _ints = "0123456789";
            int _sum = 0; //the answer to the puzzle

            foreach(var inputString in this.input)
            {
                List<int> _intList = new List<int> { };
                int _numberFromDigits = 0;

                foreach(var inputChar in inputString)
                {
                    if (_ints.Contains(inputChar))
                    {
                        _intList.Add(Convert.ToInt32(inputChar-'0'));
                    }
                }

                if (_intList.Count > 0)
                {
                    _numberFromDigits = Convert.ToInt32($"{_intList[0]}{_intList.Last()}");
                }
               

                _sum += _numberFromDigits;
            }

            return _sum.ToString();
        }

        public override string Answer2()
        {
            string _ints = "0123456789";
            int _sum = 0; //the answer to the puzzle

            foreach (var inputString in this.input)
            {
                List<int> _intList = new List<int> { };
                int _numberFromDigits = 0;
                string inp = "";
                inp = inputString.Replace("zero", "z0o");
                inp = inp.Replace("one", "o1e");
                inp = inp.Replace("two", "t2o");
                inp = inp.Replace("three", "t3e");
                inp = inp.Replace("four", "f4r");
                inp = inp.Replace("five", "f5e");
                inp = inp.Replace("six", "s6x");
                inp = inp.Replace("seven", "s7n");
                inp = inp.Replace("eight", "e8t");
                inp = inp.Replace("nine", "n9e");
                foreach (var inputChar in inp)
                {
                    if (_ints.Contains(inputChar))
                    {   
                        _intList.Add(Convert.ToInt32(inputChar - '0'));
                    }
                }

                if (_intList.Count > 0)
                {
                    _numberFromDigits = Convert.ToInt32($"{_intList[0]}{_intList.Last()}");
                }
                _sum += _numberFromDigits;
            }

            return _sum.ToString();
        }

    }
}
