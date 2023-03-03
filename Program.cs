namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mood : ");
                string x = Console.ReadLine();
                try
                {
                    MoodAnalyzer m1 = new MoodAnalyzer();
                    m1.MoodException(x);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }   
}
