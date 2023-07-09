namespace CodilityLessons.Test
{
    public class LessonsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1041, ExpectedResult = 5)]
        [TestCase(32, ExpectedResult = 0)]
        public int BinaryGapTest(int N)
        {
            return new BinaryGap().Solution(N);
        }

        [Test]
        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 3, ExpectedResult = new int[] { 9, 7, 6, 3, 8 })]
        [TestCase(new int[] { 0, 0, 0 }, 1, ExpectedResult = new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        public int[] CyclicRotationTest(int[] A, int K)
        {
            return new CyclicRotation().Solution(A, K);
        }

        [Test]
        [TestCase(new int[] { 9, 3, 9, 3, 9, 7, 9 }, ExpectedResult = 7)]
        public int OddOccurrencesInArrayTest(int[] A)
        {
            return new OddOccurrencesInArray().Solution(A);
        }

        [Test]
        [TestCase(10, 85, 30, ExpectedResult = 3)]
        public int FrogJmpTest(int X, int Y, int D)
        {
            return new FrogJmp().Solution(X, Y, D);
        }

        [Test]
        [TestCase(new int[] { 2, 3, 1, 5 }, ExpectedResult = 4)]
        public int PermMissingElemTest(int[] A)
        {
            return new PermMissingElem().Solution(A);
        }

        [Test]
        [TestCase(new int[] { 3, 1, 2, 4, 3 }, ExpectedResult = 1)]
        public int TapeEquilibriumTest(int[] A)
        {
            return new TapeEquilibrium().Solution(A);
        }

        [Test]
        [TestCase(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, ExpectedResult = 6)]
        public int FrogRiverOneTest(int X, int[] A)
        {
            return new FrogRiverOne().Solution(X, A);
        }

        [Test]
        [TestCase(new int[] { 4,1,3,2 }, ExpectedResult = 1)]
        [TestCase(new int[] { 4, 1, 3 }, ExpectedResult = 0)]
        public int PermCheckTest(int[] A)
        {
            return new PermCheck().Solution(A); 
        }
    }
}