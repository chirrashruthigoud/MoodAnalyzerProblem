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
        {// Arrange
            //MoodAnalyser m1 = new MoodAnalyser("happy");
            MoodAnalyzer m1 = new MoodAnalyzer("Sad");

            // Act
            var result = m1.mood();

            // Assert
            Assert.AreEqual("Sad", result);
        }


        }
    }