using ConsoleApp;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTestNumberUtilities
    {
        [Fact]
        public void SumNumbersAsArrays_Both_Arrays_Ok()
        {
            int[] array1 = new int[] { 7, 8, 9 };
            int[] array2 = new int[] { 1, 2 };

            var result = NumberUtilities.SumNumbersAsArrays(array1, array2);

            Assert.NotNull(result);
            Assert.True(result.Length == array1.Length);
        }

        [Fact]
        public void SumNumbersAsArrays_Both_Arrays_Ok_2ndLarger()
        {
            int[] array1 = new int[] { 7, 8, 9 };
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };

            var result = NumberUtilities.SumNumbersAsArrays(array1, array2);

            Assert.NotNull(result);
            Assert.True(result.Length == array2.Length);
        }

        [Fact]
        public void SumNumbersAsArrays_Both_Arrays_Ok_FromEmail()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };

            var result = NumberUtilities.SumNumbersAsArrays(array1, array2);

            Assert.NotNull(result);
            Assert.True(result.Length == array1.Length);
        }

        [Fact]
        public void SumNumbersAsArrays_1stArray_Ok_2dnArray_Empty()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = Array.Empty<int>();

            var result = NumberUtilities.SumNumbersAsArrays(array1, array2);

            Assert.NotNull(result);
            Assert.True(result.Length == array1.Length);
        }

        [Fact]
        public void SumNumbersAsArrays_1stArray_Empty_2dnArray_Ok()
        {
            int[] array1 = Array.Empty<int>();
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };

            var result = NumberUtilities.SumNumbersAsArrays(array1, array2);

            Assert.NotNull(result);
            Assert.True(result.Length == array2.Length);
        }
    }
}