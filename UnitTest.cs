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
            MoodAnalyzer m1 = new MoodAnalyzer();
            MoodAnalyzer m2 = new MoodAnalyzer();
            object expectedOutput = "Object are Different";

            //Act 
            object actualOutput = m1.Equals(m2);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}