using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            string s1 = "Happy";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "Happy";

            //Act
            string actualOutput = m1.CheckMoodAnalyzer(s1);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);


        }
    }
}