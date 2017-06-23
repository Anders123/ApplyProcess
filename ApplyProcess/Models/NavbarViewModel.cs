using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyProcess.Models
{
    public class NavbarViewModel
    {
        public List<NavbarItemViewModel> NavbarItems { get; set; }

        public NavbarViewModel(List<NavbarItemViewModel> navbarItems)
        {
            NavbarItems = navbarItems;
        }
    }
}
