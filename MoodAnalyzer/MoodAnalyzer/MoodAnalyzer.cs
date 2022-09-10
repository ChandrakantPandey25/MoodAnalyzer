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
     
    }
}
