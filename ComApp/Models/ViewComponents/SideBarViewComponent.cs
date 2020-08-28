using ComApp.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComApp.Models.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public SideBarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
