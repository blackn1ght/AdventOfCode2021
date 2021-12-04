using System;
using System.IO;

namespace AdventOfCode2021.Utilities
{
    public static class DayInputReader
    {
        public static string[] Read(int day)
        {
            var file = string.Empty;
            var dayString = day.ToString().PadLeft(2, '0');

            using (var reader = new StreamReader($"InputData/day{dayString}.txt"))
            {
                file = reader.ReadToEnd();
            }

            return file.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
