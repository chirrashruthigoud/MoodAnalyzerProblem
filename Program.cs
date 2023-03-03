using System.Reflection;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the mood : ");
            string mood = Console.ReadLine();
            try
            {
                MoodAnalyzer m1 = new MoodAnalyzer();
                m1.check(mood);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }   
}
