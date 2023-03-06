namespace MinMax
{
    internal class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        internal static void miniMaxSum(List<long> arr)
        {
            var orderedArray = arr.OrderBy(x => x).ToList();

            var minimum = orderedArray.Take(4);
            var maximum = orderedArray.TakeLast(4);

            Console.WriteLine($"{minimum.Sum()} {maximum.Sum()}");
        }

        internal class Solution
        {
            internal static void Main(string[] args)
            {
                var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

                Result.miniMaxSum(arr);
            }
        }
    }
}
