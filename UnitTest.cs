using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            string s1 = "Sad";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "Sad";

            //Act
            string actualOutput = m1.CheckMoodAnalyzer(s1);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);


        }
    }
}