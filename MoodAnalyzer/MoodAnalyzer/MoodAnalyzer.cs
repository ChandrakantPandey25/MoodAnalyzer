using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerTestCases
{
    public class MoodAnalyzer
    {
        
        public string Message;
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string Message)
        {
            this.Message = Message;
        }

        public string AnalyseMoodWithconstructor(string Message)
        {
            if (Message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
        public string AnalyseMoodWithparameterizedconstructor()
        {
            if (Message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
        public string MoodAnalysis()
        {
            try
            {
                if (Message.ToUpper().Equals("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
        }

        public string InvalidEntry()
        {
            try
            {
                if (Message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (Message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY, "Message cann't be Empty");
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Default Exception: " + ex.Message);
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL, "Message cann't be null");

            }
        }

    }
     
    
}
