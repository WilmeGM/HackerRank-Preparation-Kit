namespace PlusMinus
{
    internal class Result
    {
        public static void PlusMinus(List<int> arr)
        {
            int count = arr.Count;
            decimal positive = 0, negative = 0, zeros = 0;

            foreach (var num in arr)
            {
                if (num > 0)
                {
                    positive++;
                } 
                else if (num < 0)
                {
                    negative++;
                }
                else
                {
                    zeros++;
                }
            }

            Console.WriteLine(Math.Round(positive / count, 6));
            Console.WriteLine(Math.Round(negative / count, 6));
            Console.WriteLine(Math.Round(zeros / count, 6));
        }
    }

    internal class Program
    {
        static void Main()
        {
            Result.PlusMinus([-4, 3, -9, 0, 4, 1]);
            Console.ReadLine();
        }
    }
}