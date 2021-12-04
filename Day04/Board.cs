using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day04
{
    public class Board
    {
        public List<List<BingoNumber>> Rows { get; set; } = new List<List<BingoNumber>>();

        public bool HasWon { get; private set; }

        public bool CheckHasWon()
        {
            if (CheckIfARowHasWon() || CheckIfAColumnHasWon()) return true;

            return false;
        }

        private bool CheckIfARowHasWon()
        {
            if (Rows.Any(row => row.All(r => r.IsMarked)))
            {
                HasWon = true;
                return true;
            }

            return false;
        }

        private bool CheckIfAColumnHasWon()
        {
            var numberOfColumns = Rows[0].Count;

            for (var colIndex = 0; colIndex < numberOfColumns; colIndex++)
            {
                var markedCount = Rows.Count(row => row[colIndex].IsMarked);

                if (markedCount == numberOfColumns)
                {
                    HasWon = true;
                    return true;
                }
            }

            return false;
        }

        public int CalculateScore()
        {
            return Rows
                .Sum(row => row
                    .Sum(n => !n.IsMarked ? n.Number : 0));
        }
    }
}