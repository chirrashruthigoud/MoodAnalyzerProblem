using System;
using System.Collections.Generic;
using System.Linq;
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
            string mood = "";
            MoodAnalyzer m1 = new MoodAnalyzer();
            string expectedOutput = "No Such Class Error";

            //Act
            string actualOutput = m1.check(mood);
            Console.WriteLine(actualOutput);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}