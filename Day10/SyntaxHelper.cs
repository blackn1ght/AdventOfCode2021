using System.Collections.Generic;

namespace AdventOfCode2021.Day10
{
    public static class SyntaxHelper
    {
        private static Dictionary<char, char> Tags = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'<', '>'},
            {'[', ']'}
        };

        public static string FindMissingClosingTags(string line)
        {
            var chars = line.ToCharArray();

            var previousTags = new Stack<char>();

            foreach (var thisChar in chars)
            {
                if (Tags.ContainsKey(thisChar))
                {
                    previousTags.Push(thisChar);
                }
                else
                {
                    previousTags.Pop();
                }
            }

            var missingTags = "";

            while (previousTags.Count > 0)
            {
                var c = previousTags.Pop();
                missingTags += Tags[c];
            }

            return missingTags;
        }

        public static char? FindCorruptedTag(string line)
        {
            var chars = line.ToCharArray();

            var expectedClosingTags = new Stack<char>();
            var previousTags = new Stack<char>();

            foreach (var thisChar in chars)
            {
                if (Tags.ContainsKey(thisChar))
                {
                    expectedClosingTags.Push(Tags[thisChar]);
                    previousTags.Push(thisChar);
                }
                else
                {
                    if (expectedClosingTags.Peek() != Tags[previousTags.Peek()] || thisChar != expectedClosingTags.Peek()) return thisChar;

                    expectedClosingTags.Pop();
                    previousTags.Pop();
                }
            }

            return null;
        }
    }
}
