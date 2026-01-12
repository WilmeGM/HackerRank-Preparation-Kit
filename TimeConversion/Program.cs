namespace TimeConversion
{
    class Result
    {
        public static string timeConversion(string s)
        {
            string meridian = s[^2..].ToLower();
            string sWOutMeridian = s[..^2];

            string[] hms = sWOutMeridian.Split(":");
            int hour = Convert.ToInt32(hms[0]);
            int min = Convert.ToInt32(hms[1]);
            int sec = Convert.ToInt32(hms[2]);

            if (hour == 12 && meridian == "am")
                return $"{0:D2}:{min:D2}:{sec:D2}";

            if (hour >= 1 && hour <= 11 && meridian == "am") 
                return $"{hour:D2}:{min:D2}:{sec:D2}";

            if (hour == 12 & meridian == "pm")
                return $"{hour:D2}:{min:D2}:{sec:D2}";

            if (hour >= 1 && hour <= 11 && meridian == "pm")
                return $"{hour + 12:D2}:{min:D2}:{sec:D2}";

            return "not valid input date. Example: 07:05:45PM.";
        }

    }

    internal class Program
    {
        static void Main()
        {
            string[] testCases = {
                "12:01:00AM", 
                "07:05:45AM", 
                "11:59:59AM",
                "12:40:22AM",
                "12:00:00PM", 
                "01:00:00PM", 
                "07:05:45PM", 
                "11:59:59PM"  
            };

            Console.WriteLine("Entrada ----> Salida Militar");
            Console.WriteLine("----------------------------");

            foreach (var test in testCases)
            {
                string result = Result.timeConversion(test);
                Console.WriteLine($"{test} ----> {result}");
            }
        }
    }
}