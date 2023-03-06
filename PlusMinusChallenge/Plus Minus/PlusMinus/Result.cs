namespace Plus_Minus
{
    public class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            var positive = arr.Count(x => x > 0);
            var negative = arr.Count(x => x < 0);
            var zeros = arr.Count(x => x == 0);

            var positiveToAllRatio = (decimal)positive / (decimal)arr.Count;
            var negativeToAllRatio = (decimal)negative / (decimal)arr.Count;
            var zerosToAllRatio = (decimal)zeros / (decimal)arr.Count;

            Console.WriteLine(Math.Round(positiveToAllRatio, 5));
            Console.WriteLine(Math.Round(negativeToAllRatio, 5));
            Console.WriteLine(Math.Round(zerosToAllRatio, 5));
        }

        public static void miniMaxSum(List<long> arr)
        {
            var orderedArray = arr.OrderBy(x => x).ToList();

            var minimum = orderedArray.Take(4);
            var maximum = orderedArray.TakeLast(4);

            Console.WriteLine($"{minimum.Sum()} {maximum.Sum()}");
        }
    }
}