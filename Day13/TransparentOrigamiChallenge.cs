using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2021.Day13
{
    public class TransparentOrigamiChallenge
    {
        private string[,] _origami;
        private int _height;
        private int _width;
        private readonly List<Tuple<Action<int>, int>> _foldActions = new();

        public TransparentOrigamiChallenge(IReadOnlyList<string> inputLines)
        {
            var foldInstructionsIndex = inputLines.ToList().FindIndex(string.IsNullOrEmpty);

            _origami = BuildSheet(inputLines, foldInstructionsIndex);
            _foldActions = GetFoldInstructions(inputLines, foldInstructionsIndex);
        }

        private string[,] BuildSheet(IReadOnlyList<string> inputData, int foldInstructionsIndex)
        {
            var positions = new List<(int Y, int X)>();

            for (var i = 0; i < foldInstructionsIndex; i++)
            {
                var coordinates = inputData[i].Split(',');

                positions.Add(new (int.Parse(coordinates[1]), int.Parse(coordinates[0])));
            }

            _height = positions.Max(p => p.Item1);
            _width = positions.Max(p => p.Item2);

            var origami = new string[_height + 1, _width + 1];

            foreach (var (Y, X) in positions)
            {
                origami[Y, X] = "#";
            }

            return origami;
        }

        private List<Tuple<Action<int>, int>> GetFoldInstructions(IReadOnlyList<string> inputData, int foldInstructionsIndex)
        {
            var actions = new List<Tuple<Action<int>, int>>();

            for (var i = foldInstructionsIndex + 1; i < inputData.Count; i++)
            {
                var direction = inputData[i].Substring(11, 1);
                var position = int.Parse(inputData[i].Substring(13));

                actions.Add(direction == "y"
                    ? new Tuple<Action<int>, int>(FoldUp, position)
                    : new Tuple<Action<int>, int>(FoldAcross, position));
            }

            return actions;
        }

        public int Part1()
        {
            var (foldAction, foldPoint) = _foldActions[0];

            foldAction(foldPoint);

            return _origami.Cast<string>().Sum(row => row == "#" ? 1 : 0);
        }

        public void Part2()
        {
            foreach (var (foldAction, foldPoint) in _foldActions)
            {
                foldAction(foldPoint);
            }

            WriteFoldResultToFile();
        }

        private void WriteFoldResultToFile()
        {
            var stringBuilder = new StringBuilder();

            for (var y = 0; y <= _height; y++)
            {
                for (var x = 0; x <= _width; x++)
                {
                    var c = _origami[y, x] == "#"
                        ? "#"
                        : " ";

                    stringBuilder.Append(c);
                }
                stringBuilder.AppendLine();
            }

            var result = stringBuilder.ToString();

            File.WriteAllText("Day13/output.txt", result);
        }

        private void FoldUp(int foldPoint)
        {
            var array = new string[_height / 2, _width + 1];

            var newY = _height / 2 - 1;
            for (var y = foldPoint + 1; y <=_height; y++)
            {
                for (var x = 0; x <= _width; x++)
                {
                    array[newY, x] = _origami[y, x];
                    if (_origami[newY, x] == "#")
                    {
                        array[newY, x] = "#";
                    }
                }

                newY--;
            }

            _origami = array;
            _height = (_height / 2) - 1;
        }

        private void FoldAcross(int foldPoint)
        {
            var array = new string[_height + 1, _width / 2];

            for (var y = 0; y <= _height; y++)
            {
                var newX = 0;

                for (var x = _width; x > foldPoint; x--)
                {
                    array[y, newX] = _origami[y, x];
                    if (_origami[y, newX] == "#")
                    {
                        array[y, newX] = "#";
                    }

                    newX++;
                }
            }

            _origami = array;
            _width = (_width / 2) - 1;
        }


    }
}
