using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyProcess.Models
{
    public class NavbarItemViewModel
    {
        public string Text { get; set; }
        public string Url { get; set; }

        public NavbarItemViewModel(string text, string url)
        {
            Text = text;
            Url = url;
        }
    }
}
