using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessment_review.Models.TempConverter;
using Microsoft.AspNetCore.Mvc;

namespace assessment_review.Controllers
{
    public class TempConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormResult(IndexViewModel model)
        {
            var viewModel = new FormResultViewModel();
            viewModel.F = model.Degrees;

            return View(viewModel);
        }
    }
}
