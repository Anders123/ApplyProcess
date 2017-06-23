using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApplyProcess.Models;

namespace ApplyProcess.Components
{
    public class NavBarComponent : ViewComponent
    {
        public async Task<IViewComponentResult>InvokeAsync()
        {
            var navbarItems = new List<NavbarItemViewModel>();
            await Task.Run(() =>
            {
                navbarItems.Add(new NavbarItemViewModel("Action 1", "Home/Action1"));
                navbarItems.Add(new NavbarItemViewModel("Action 2", "Home/Action2"));
                navbarItems.Add(new NavbarItemViewModel("Action 3", "Home/Action3"));
            });
            var viewModel = new NavbarViewModel(navbarItems);
            return View(viewModel);
        }
    }
}
