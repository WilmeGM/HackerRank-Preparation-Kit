namespace MiniMaxSum
{
    internal class Result
    {
        public static void MiniMaxSum(List<int> arr)
        {
            List<long> nums = [.. arr.Select(n => (long)n)];

            var largest = nums.Max();
            var smallest = nums.Min();
            var sum = nums.Sum();

            var maxSum = sum - smallest;
            var minSum = sum - largest;

            var output = $"{minSum} {maxSum}";

            Console.WriteLine(output);
        }
        
    }
    internal class Program
    {
        static void Main()
        {
            Result.MiniMaxSum([1, 2, 3, 4, 5]);
        }
    }
}
