using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AdventOfCode2021.Day12
{
    [DebuggerDisplay("Cave = {Name}")]
    public class Cave
    {
        public Cave(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsSmallCave => string.Equals(Name, Name.ToLower(), StringComparison.CurrentCulture);

        public List<Cave> LinkedCaves { get; } = new List<Cave>();
    }
}
