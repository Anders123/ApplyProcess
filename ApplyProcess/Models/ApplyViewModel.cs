using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyProcess.Models
{
    public class ApplyViewModel
    {
        public int NumberOfQuestions { get; set; } = 3;

        public List<string> Questions = new List<string>
        {
            "Question 1",
            "Question 2",
            "Question 3"
        };
    }
}
