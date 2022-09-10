using NUnit.Framework;
using System;


namespace MoodAnalyzerTestCases
{
    public class Tests
    {
        MoodAnalyzer moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyzer();
        }

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSadDefaultConstructor()
        {
            moodAnalyser = new MoodAnalyzer();
            string message = "I am in Sad mood";
            string result = moodAnalyser.AnalyseMoodWithconstructor(message);
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnHappyDefaultConstructor()
        {
            moodAnalyser = new MoodAnalyzer();
            string message = "I am in Any mood";
            string result = moodAnalyser.AnalyseMoodWithconstructor(message);
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterizedConstructor()
        {
            moodAnalyser = new MoodAnalyzer("I am in SAD Mood");
            string message = moodAnalyser.AnalyseMoodWithparameterizedconstructor();
            Assert.AreEqual("SAD", message);
        }
        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappyParameterizedConstructor()
        {
            moodAnalyser = new MoodAnalyzer("I am in Happy Mood");
            string message = moodAnalyser.AnalyseMoodWithparameterizedconstructor();
            Assert.AreEqual("HAPPY", message);
        }
        [Test]
       
        public void Given_Null_Return_Happy()
        {          
            string message = null;
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string excepted = "happy";            
            var actual = mood.MoodAnalysis();            
            Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
        }

    }
}