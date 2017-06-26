using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ApplyProcess.Models;
using Common;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace ApplyProcess.Components
{
    public class ApplyComponent : ViewComponent
    {
        private readonly ApplyProcessWebApiSettings _webApiSettings;

        public ApplyComponent(IOptions<ApplyProcessWebApiSettings> applyProcessWebApiSettings)
        {
            _webApiSettings = applyProcessWebApiSettings.Value;
        }

        public async Task<IViewComponentResult> InvokeAsync(ApplyViewModel viewModelFromController)
        {
            // No view model yet
            if (viewModelFromController == null)
            {
                var interview = await GetData();

                ApplyViewModel viewModel = null;
                await Task.Run(() =>
                {
                    viewModel = new ApplyViewModel
                    {
                        Interview = interview,
                        CurrentStep = 0
                    };
                });
                return View(viewModel);
            }
            // View model already instantiated
            return View(viewModelFromController);
        }

        public async Task<Interview> GetData()
        {
            // http://localhost:62341/Interview/Create?briefCaseId=1

            using (var client = new HttpClient())
            {
                //  client.BaseAddress = new Uri(_webApiSettings.BaseUrl + "Interview/Create?briefCaseId=1");  //new Uri("http://www.omdbapi.com");
                // client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage response = await client.PostAsync(new Uri(_webApiSettings.BaseUrl + "Interview/Create?briefCaseId=1", UriKind.Absolute), null);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var interview = JsonConvert.DeserializeObject<Interview>(data);
                    return interview;
                }
                else
                {
                    return null;
                }
            }
        }

    }

}
