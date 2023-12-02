using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2023
{
    class Day2 : Puzzle
    {
        public Day2(string inputName) : base(inputName) { }
        public override string Date { get { return "2023.12.02"; } }

        public override string Answer1()
        {
            int redLimit = 12;
            int greenLimit = 13;
            int blueLimit = 14;

            int sumOfIds = 0;
            foreach(var inputString in this.input)
            {
                int gameId = Convert.ToInt32(inputString.Split(':')[0].Replace("Game ", ""));
                string input2 = inputString.Replace($"Game {gameId}: ", "");
                List<string> gameSets = input2.Split(';').ToList();

                bool possible = true;
                foreach(var i in gameSets)
                {
                    List<string> cubeSets = i.Split(',').ToList();

                    foreach (var cube in cubeSets)
                    {
                        if (cube.Contains("red"))
                        {
                            if(Convert.ToInt32(cube.Replace(" red", "")) > redLimit)
                            {
                                possible = false;
                                break;
                            }
                        } 
                        else if (cube.Contains("green"))
                        {
                            if (Convert.ToInt32(cube.Replace(" green", "")) > greenLimit)
                            {
                                possible = false;
                                break;
                            }

                        }
                        else if (cube.Contains("blue"))
                        {
                            if (Convert.ToInt32(cube.Replace(" blue", "")) > blueLimit)
                            {
                                possible = false;
                                break;
                            }

                        }

                    }
                    

                }
                if (possible)
                {
                    sumOfIds += gameId;
                    continue;
                }
            }
            return Convert.ToString(sumOfIds);
        }

        public override string Answer2()
        {
            int sumOfPower = 0;
            foreach (var inputString in this.input)
            {
                int gameId = Convert.ToInt32(inputString.Split(':')[0].Replace("Game ", ""));
                string input2 = inputString.Replace($"Game {gameId}: ", "");

                int power;
                List<string> gameSets = input2.Split(';').ToList();

                List<int> red = new List<int> { };
                List<int> green = new List<int> { };
                List<int> blue = new List<int> { };
                foreach (var i in gameSets)
                {
                    List<string> cubeSets = i.Split(',').ToList();
                    foreach(var cube in cubeSets)
                    {
                        if (cube.Contains("red"))
                        {
                            red.Add(Convert.ToInt32(cube.Trim().Replace(" red", "")));
                        }
                        if (cube.Contains("green"))
                        {
                            green.Add(Convert.ToInt32(cube.Trim().Replace(" green", "")));
                        }
                        if (cube.Contains("blue"))
                        {
                            blue.Add(Convert.ToInt32(cube.Trim().Replace(" blue", "")));
                        }
                    }
                }

                


                power = red.Max() * green.Max() * blue.Max();
                sumOfPower += power;
                
            }
            return Convert.ToString(sumOfPower);
        }
    }
}
