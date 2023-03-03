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
        public void MoodAnalyser_Success()
        {
            //Arrange
            string s1 = "";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "HAPPY";

            //Act
            string actualOutput = m1.Fun(s1);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}