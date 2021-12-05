using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day02
{
    public class DiveChallenge
    {
        private readonly IEnumerable<Instruction> _instructions;

        public DiveChallenge(string[] inputLines)
        {
            _instructions = inputLines
                .Select(x => x.Split(' '))
                .Select(x => new Instruction
                {
                    Direction = x[0],
                    Value = int.Parse(x[1])
                });
        }


        public int Part1()
        {
            var position = 0;
            var depth = 0;

            foreach (var instruction in _instructions)
            {
                switch (instruction.Direction)
                {
                    case "forward":
                        position += instruction.Value;
                        break;
                    case "up":
                        depth -= instruction.Value;
                        break;
                    case "down":
                        depth += instruction.Value;
                        break;
                }
            }

            var answer = position * depth;

            return answer;
        }

        public int Part2()
        {
            var position = 0;
            var depth = 0;
            var aim = 0;

            foreach (var instruction in _instructions)
            {
                switch (instruction.Direction)
                {
                    case "forward":
                        position += instruction.Value;
                        depth += (aim * instruction.Value);
                        break;
                    case "up":
                        aim -= instruction.Value;
                        break;
                    case "down":
                        aim += instruction.Value;
                        break;
                }
            }

            var answer = position * depth;

            return answer;
        }
    }
}
