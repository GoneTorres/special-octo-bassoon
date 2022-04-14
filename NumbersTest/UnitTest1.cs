using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSmallNumbers()
        {
            var num1 = new int[] { 1, 2, 3 };
            var num2 = new int[] { 4, 5, 6 };

            var result = Numbers.NumbersLibrary.ReverseSecondAndAdd(num1, num2);

            Assert.AreEqual(777, result,
                    string.Format("Expected for '{0} {1}': 777; Actual: {2}",
                                    string.Join("", num1), string.Join("", num2), result));

        }

        [TestMethod]
        public void TestLargeNumbers()
        {
            var num1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var num2 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = Numbers.NumbersLibrary.ReverseSecondAndAdd(num1, num2);

            Assert.AreEqual(111111111111111110, result,
                    string.Format("Expected for '{0} {1}': 111111111111111110; Actual: {2}",
                                    string.Join("", num1), string.Join("", num2), result));

        }

        [TestMethod]
        public void TestDifferentLenghtNumbers()
        {
            var num1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var num2 = new int[] { 9, 8, 7 };

            var result = Numbers.NumbersLibrary.ReverseSecondAndAdd(num1, num2);

            Assert.AreEqual(12345678987655110, result,
                    string.Format("Expected for '{0} {1}': 12345678987655110; Actual: {2}",
                                    string.Join("", num1), string.Join("", num2), result));

        }

        [TestMethod]
        public void TestInvalidParameters()
        {
            var num1 = System.Array.Empty<int>();
            var num2 = new int[] { 9, 8, 7 };

            var result = Numbers.NumbersLibrary.ReverseSecondAndAdd(num1, num2);

            Assert.AreEqual(null, result,
                    string.Format("Expected for '{0} {1}': 12345678987655110; Actual: {2}",
                                    string.Join("", num1), string.Join("", num2), result));

        }
    }
}
