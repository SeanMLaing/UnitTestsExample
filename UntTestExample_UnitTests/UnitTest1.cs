namespace UntTestExample_UnitTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            int sumTotal = 9;
            int[] input1 = new int[] { 2, 7, 11, 15 };
            int[] output1 = new int[] { 0, 1 };
            int[] results;
            
            results = UnitTestExample.TwoSum(input1, sumTotal);

            Assert.IsTrue(CompareIntArrays(output1, results));

        } // EOM

        [TestMethod]
        public void TestMethod2()
        {
            int sumTotal = 10;
            int[] input1 = new int[] { 0, 7, 11, 5, 5 };
            int[] output1 = new int[] { 3, 4 };
            int[] results;

            results = UnitTestExample.TwoSum(input1, sumTotal);

            Assert.IsTrue(CompareIntArrays(output1, results));

        } // EOM

        [TestMethod]
        public void TestMethod3()
        {
            int sumTotal = 1;
            int[] input1 = new int[] { 3, 1, 4, 5, 9, 0 };
            int[] output1 = new int[] { 1, 5 };
            int[] results;

            results = UnitTestExample.TwoSum(input1, sumTotal);

            Assert.IsTrue(CompareIntArrays(output1, results));

        } // EOM

        /// <summary>
        /// TestMethod4 the TwoSum method should not return the value of output4, this is correct and will mark the test as passed
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            int sumTotal = 21; // yes this is a reference to the Vine
            int[] input1 = new int[] { 9, 10 };
            int[] output1 = new int[] { 0, 1 };
            int[] results;

            results = UnitTestExample.TwoSum(input1, sumTotal); // should return 0,0

            Assert.IsFalse(CompareIntArrays(output1, results));

        } // EOM


        /// <summary>
        /// Compare the two int arrays to make sure they carry the same values at each index
        /// </summary>
        /// <param name="expectedValue"></param>
        /// <param name="testResult"></param>
        /// <returns></returns>
        private bool CompareIntArrays(int[] expectedValue, int[] testResult)
        {
            if (testResult.Length != expectedValue.Length)
                return false;

            for (int i = 0; i < expectedValue.Length; i++)
            {
                if (expectedValue[i] != testResult[i])
                    return false;
            }

            return true;
        } // EOM
    } // EOC
} // NameSpace