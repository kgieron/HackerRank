using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PlusMinusChallengeTests")]
namespace Plus_Minus
{
    internal class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        internal static void plusMinus(List<int> arr)
        {
            var positive = arr.Count(x => x > 0);
            var negative = arr.Count(x => x < 0);
            var zeros = arr.Count(x => x == 0);

            var positiveToAllRatio = (decimal)positive / (decimal)arr.Count;
            var negativeToAllRatio = (decimal)negative / (decimal)arr.Count;
            var zerosToAllRatio = (decimal)zeros / (decimal)arr.Count;

            Console.WriteLine(string.Format("{0:0.00000}", Math.Round(positiveToAllRatio, 5)));
            Console.WriteLine(string.Format("{0:0.00000}", Math.Round(negativeToAllRatio, 5)));
            Console.WriteLine(string.Format("{0:0.00000}", Math.Round(zerosToAllRatio, 5)));
        }
    }

    internal class Solution
    {
        internal static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var inputList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(inputList);
        }
    }
}
