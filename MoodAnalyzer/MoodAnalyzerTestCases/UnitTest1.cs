using NUnit.Framework;
using System;
using MoodAnalyzerTestCases;


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
        [Test]
        public void GivenNull_ReturnCustomException()
        {
            
            string message = null;
            string excepted = "Message cann't be null";
            try
            {                
                MoodAnalyzer moodAnalysis = new MoodAnalyzer(message);
                string actual = moodAnalysis.InvalidEntry();
            }
            catch (MoodAnalyzerException ex)
            {                
                Assert.AreEqual(excepted, ex.Message);
            }
           
        }
        [Test]
        public void GivenEmptyShouldReturnCustomException()
        {            
            string message = "";
            string excepted = "Message cann't be Empty";
            try
            {
                MoodAnalyzer moodAnalysis = new MoodAnalyzer(message);
                string actual = moodAnalysis.InvalidEntry();
            }
            catch (MoodAnalyzerException ex)
            {               
                Assert.AreEqual(excepted, ex.Message);
            }

        }

    }
}