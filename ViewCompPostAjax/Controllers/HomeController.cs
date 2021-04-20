using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewCompPostAjax.Data;
using ViewCompPostAjax.Models;
using ViewCompPostAjax.ViewModels;

namespace ViewCompPostAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;

        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int? id)
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                SelectedRecords = new List<RecordModel>()
            };
            if (id != null)
            {
                homeViewModel.DataId = (int)id;
            }
            _logger.LogInformation($"Action=Index id={id}");

            return View(homeViewModel);
        }

        [HttpPost]
        public IActionResult GetRange(HomeViewModel vm)
        {            
            if (vm == null)
            {
                return View("Index", new HomeViewModel() { SelectedRecords = new List<RecordModel>() });
            }

            if (vm.DataId == null)
            {
                return View("Index", vm);
            }

            _logger.LogInformation($"Action=GetRange id={vm.DataId} startDate={vm.StartDate} endDate={vm.EndDate}");

            vm.SelectedRecords = _repository.Data
                .FirstOrDefault(x => x.DataId == vm.DataId).Records
                .Where(d => d.DateCreated >= vm.StartDate && d.DateCreated <= vm.EndDate);

            return View("index", vm);
        }
    }
}
