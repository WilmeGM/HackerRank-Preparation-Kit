namespace BreakingTheRecords
{
    internal class Result
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            try
            {
                int max = scores[0], min = scores[0], maxCount = 0, minCount = 0;

                foreach (var score in scores)
                {
                    if (score > max)
                    {
                        max = score;
                        maxCount++;
                    }

                    if (score < min)
                    {
                        min = score;
                        minCount++;
                    }
                }

                return [maxCount, minCount];
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
                return [];
            }
        }

    }

    internal class Program
    {
        static void Main()
        {
            var testCases = new List<(List<int> input, List<int> expected)>
            {
                (new List<int> { 10, 5, 20, 20, 4 }, new List<int> { 1, 2 }),
                (new List<int> { 10, 10, 10, 10 }, new List<int> { 0, 0 }),
                (new List<int> { 5, 10, 15, 20 }, new List<int> { 3, 0 }),
                (new List<int> { 20, 15, 10, 5 }, new List<int> { 0, 3 }),
                (new List<int> { 10 }, new List<int> { 0, 0 })
            };

            Console.WriteLine("--- EJECUTANDO PRUEBAS ---");

            foreach (var test in testCases)
            {
                var result = Result.BreakingRecords(test.input);

                bool passed = result[0] == test.expected[0] && result[1] == test.expected[1];

                string status = passed ? "PASÓ [OK]" : "FALLÓ [X]";
                Console.WriteLine($"{status} | Input: [{string.Join(", ", test.input)}] | Output: [{result[0]}, {result[1]}]");
            }
        }
    }
}
