using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string CheckMoodAnalyzer(string mood)
        {

            if (mood == "Happy" || mood == "happy")
            {
                return "Happy";


            }
            else
            {
                return "Sad";

            }


        }
    }
}
