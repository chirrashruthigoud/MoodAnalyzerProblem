using System.Reflection;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mood : ");
            string mood = Console.ReadLine();
            MoodAnalyzer m1 = new MoodAnalyzer();
            m1.check(mood);
            /*
                Type t = typeof(MoodAnalyser);
                ConstructorInfo[] info = t.GetConstructors(BindingFlags.Public|BindingFlags.Instance);
                foreach (ConstructorInfo info2 in info)
                {
                    Console.WriteLine(info2.Name);
                } 
            */

        }
    }   
}
