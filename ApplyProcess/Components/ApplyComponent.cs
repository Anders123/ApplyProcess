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
        private readonly ApplyProcessWebApiSettings _webApiSettings;
    
        public ApplyComponent(IOptions<ApplyProcessWebApiSettings> applyProcessWebApiSettings)
        {
            _webApiSettings = applyProcessWebApiSettings.Value;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            ApplyViewModel viewModel = null;
            await Task.Run(() =>
            {
                 viewModel = new ApplyViewModel();
            });
            return View(viewModel);
        }


    }
}
