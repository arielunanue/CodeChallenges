namespace ConsoleApp
{
    public static class NumberUtilities
    {
        private static int[] SumNumbersAsArraysWithOrder(int[] numberLargerSize, int[] numberSmallerSize)
        {
            int[] result = new int[numberLargerSize.Length];

            int carry = 0;
            int sum;
            for (int i = 0; i < numberSmallerSize.Length; i++)
            {
                sum = numberLargerSize[numberLargerSize.Length - i - 1] + numberSmallerSize[numberSmallerSize.Length - i - 1] + carry;
                result[result.Length - i - 1] = sum % 10;
                carry = sum / 10;
            }

            for (int i = 0; i < numberLargerSize.Length - numberSmallerSize.Length; i++)
            {
                int index = numberLargerSize.Length - numberSmallerSize.Length - i - 1;

                sum = numberLargerSize[index] + carry;
                result[index] = sum % 10;
                carry = sum / 10;
            }

            return result;
        }

        public static int[] SumNumbersAsArrays(int[] number1, int[] number2)
        {
            /*From my point of view this definition is not clear 
             * 'You are given two arbitrarily large numbers, stored one digit at a time in an array
             I'm receiving numbers or the arrays? I'm assuming that the arrays are received as parameters 
            */

            //making sure both arrays have values
            if (number1 == null || number1.Length == 0)
                number1 = new int[] { 0 };
            if (number2 == null || number2.Length == 0)
                number2 = new int[] { 0 };

            number2 = number2.Reverse().ToArray();

            if (number1.Length >= number2.Length)
                return SumNumbersAsArraysWithOrder(number1, number2);
            else
                return SumNumbersAsArraysWithOrder(number2, number1);
        }
    }
}
