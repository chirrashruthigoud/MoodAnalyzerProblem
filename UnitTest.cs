using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyser_Success()
        {
            Console.WriteLine("Enter the Mood : ");
            string mood = Console.ReadLine();
            MoodAnalyzer m1 = new MoodAnalyzer(mood);

            Type t = typeof(MoodAnalyzer);
            ConstructorInfo[] info = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo info2 in info)
            {
                Console.WriteLine(info2.Name);
            }

            /* try
               {
                   MoodAnalyser m1 = new MoodAnalyser();
                   m1.check(mood);
               }
               catch(Exception e) 
               {
                   Console.WriteLine(e.Message);
               } */
        }

    }
}