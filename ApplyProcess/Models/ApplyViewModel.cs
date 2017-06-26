using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyProcess.Models
{
    public class ApplyViewModel
    {
        public Interview Interview { get; set; }
        public int CurrentStep { get; set; } = 1;
        public bool CanGoBack => (CurrentStep > 1);
        public bool CanGoForward => (CurrentStep < Interview.Questions.Count);

    }
}
