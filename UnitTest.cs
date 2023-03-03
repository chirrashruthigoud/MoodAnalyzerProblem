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
            public void Mood_Success()
            {
                //Arrange
                string h = "Sad";
            MoodAnalyzer m1 = new MoodAnalyzer();
                string expectedOutput = "SAD";

                //Act 
                string actualOutput = m1.Mood(h);

            //Assert
              Assert.AreEqual(expectedOutput, actualOutput);


            }
        }
}