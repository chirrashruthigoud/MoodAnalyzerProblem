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
            //Arrange
            string mood = "Happy";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "Happy";

            //Act 
            string actualOutput = m1.check(mood);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        }
}