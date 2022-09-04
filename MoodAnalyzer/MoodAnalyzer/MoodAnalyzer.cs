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
            this.Message = Message.ToUpper();
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



    }
}
