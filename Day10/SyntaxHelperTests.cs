using NUnit.Framework;

namespace AdventOfCode2021.Day10
{
    [TestFixture]
    public class SyntaxHelperTests
    {
        [TestCase("()")]
        [TestCase("[]")]
        [TestCase("([])")]
        [TestCase("{()()()}")]
        [TestCase("<([{}])>")]
        [TestCase("[<>({}){}[([])<>]]")]
        [TestCase("(((((((((())))))))))")]
        public void IndexOfCorruptedTag_ValidSyntax_ShouldReturnMinus1(string line)
        {
            var invalidTag = SyntaxHelper.FindCorruptedTag(line);

            Assert.IsNull(invalidTag);
        }

        [TestCase("(]", ']')]
        [TestCase("{()()()>", '>')]
        [TestCase("(((()))}", '}')]
        [TestCase("<([]){()}[{}])", ')')]
        public void IsSyntaxValid_InvalidSyntax_ShouldReturnFalse(string line, char corruptTag)
        {
            var invalidTag = SyntaxHelper.FindCorruptedTag(line);

            Assert.AreEqual(corruptTag, invalidTag);
        }

        [TestCase("[({(<(())[]>[[{[]{<()<>>", "}}]])})]")]
        [TestCase("[(()[<>])]({[<{<<[]>>(", ")}>]})")]
        [TestCase("(((({<>}<{<{<>}{[]{[]{}", "}}>}>))))")]
        [TestCase("{<[[]]>}<{[{[{[]{()[[[]", "]]}}]}]}>")]
        [TestCase("<{([{{}}[<[[[<>{}]]]>[]]", "])}>")]
        public void FindMissingClosingTags_ShouldAddCorrectClosingTags(string line, string tagsToAdd)
        {
            var result = SyntaxHelper.FindMissingClosingTags(line);

            Assert.AreEqual(tagsToAdd, result);
        }
    }
}
