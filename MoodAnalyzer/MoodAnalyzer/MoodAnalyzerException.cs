using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerTestCases
{
    public class MoodAnalyzerException:Exception
    {
        public ExceptionType type;       
        public enum ExceptionType
        {
            NULL,
            EMPTY
        }        
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
