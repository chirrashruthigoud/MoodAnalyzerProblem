using System.Reflection;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Type t = GetType(m1);
            Type t = typeof(MoodAnalyzer);
            ConstructorInfo[] constructorInfos = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo);
            }
        }
    }   
}
