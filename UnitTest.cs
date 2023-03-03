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
            // Arrange
            //MoodAnalyzer m1 = new MoodAnalyzer("happy");
            MoodAnalyzer m1 = new MoodAnalyzer("Sad");

            // Act
            var result = m1.mood();

            // Assert
            Assert.AreEqual("Sad", result);
        }
    }
}