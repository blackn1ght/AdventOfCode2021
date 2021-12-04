namespace AdventOfCode2021.Day04
{
    public class BingoNumber
    {
        public BingoNumber(string number)
        {
            Number = int.Parse(number);
        }

        public int Number { get; set; }

        public bool IsMarked { get; set; } = false;
    }
}
