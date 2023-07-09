namespace CodilityLessons.Test
{
    public class LessonsTests
    {
        [SetUp]
        public void Setup() 
        {
        }

        [Test]
        [TestCase(new int[] { 3, 1, 2, 4, 3 }, ExpectedResult = 1)]
        public int TapeEquilibriumTest(int[] A)
        {
            return new TapeEquilibrium().Solution(A);
        }
    }
}