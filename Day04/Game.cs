using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day04
{
    public class Game
    {
        private List<int> Numbers { get; set; }
        private List<Board> Boards { get; } = new List<Board>();

        public int BoardCount => Boards.Count;

        public Game(IReadOnlyList<string> inputLines)
        {
            SetNumbers(inputLines);
            SetBoards(inputLines);
        }

        private void SetNumbers(IReadOnlyList<string> inputLines)
        {
            Numbers = inputLines[0]
                .Split(',')
                .Select(int.Parse)
                .ToList();
        }

        private void SetBoards(IReadOnlyList<string> inputLines)
        {
            var startPos = 2;

            while (startPos < inputLines.Count)
            {
                var board = new Board();

                for (var rowIndex = 0; rowIndex < 5; rowIndex++)
                {
                    var inputLine = inputLines[startPos + rowIndex];
                    var rows = new List<BingoNumber>();

                    for (var x = 0; x < 14; x += 3)
                    {
                        var number = inputLine.Substring(x, 2);
                        rows.Add(new BingoNumber(number));
                    }

                    board.Rows.Add(rows);
                }

                Boards.Add(board);
                startPos += 6;
            }
        }

        public int LastNumberPicked { get; private set; }

        public List<Board> BoardsThatHaveWon { get; } = new List<Board>();

        public void PlayTurn()
        {
            LastNumberPicked = Numbers[0];
            Numbers.RemoveAt(0);

            foreach (var board in Boards.Where(b => b.HasWon == false).ToList())
            {
                foreach (var row in board.Rows)
                {
                    foreach (var playerNumber in row.Where(playerNumber => playerNumber.Number == LastNumberPicked))
                    {
                        playerNumber.IsMarked = true;

                        if (board.CheckHasWon())
                        {
                            BoardsThatHaveWon.Add(board);
                        }
                    }
                }
            }
        }
    }
}