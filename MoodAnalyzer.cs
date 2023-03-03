using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string n;
        public MoodAnalyzer(string name)
        {
            this.n = name;
            Console.WriteLine(n);
        }

        public string mood()
        {
            return this.n;
        }

    }
}