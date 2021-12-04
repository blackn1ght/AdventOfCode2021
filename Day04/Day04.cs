using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day04
{
    public class Day04
    {
        private readonly Game _game;

        public Day04(IReadOnlyList<string> inputLines)
        {
            _game = new Game(inputLines);
        }

        public int Part1()
        {
            while (_game.BoardsThatHaveWon.Count == 0)
            {
                _game.PlayTurn();
            }

            var firstBoardToWin = _game.BoardsThatHaveWon[0];

            var score = firstBoardToWin.CalculateScore();

            var answer = score * _game.LastNumberPicked;

            return answer;
        }

        public int Part2()
        {
            while (_game.BoardsThatHaveWon.Count != _game.BoardCount)
            {
                _game.PlayTurn();
            }

            var lastBoardToWin = _game.BoardsThatHaveWon.Last();

            var score = lastBoardToWin.CalculateScore();

            var answer = score * _game.LastNumberPicked;

            return answer;
        }
    }
}
