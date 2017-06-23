using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplyProcess.Models;
using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ApplyProcess.Components
{
    public class ApplyComponent : ViewComponent
    {

        private readonly MySettings settings;

        public ApplyComponent(IOptions<MySettings> mysettings)
        {
            this.settings = mysettings.Value;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
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
