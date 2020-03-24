using ISurvey.Interfaces;
using ISurvey.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ISurvey.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ISurveyRepository surveyRepository;

        public ResultsController(ISurveyRepository surveyRepository)
        {
            this.surveyRepository = surveyRepository;
        }

        public IActionResult Index()
        {
            SurveyViewModel model = new SurveyViewModel(surveyRepository.GetSurvey(1));
            return View(model);
        }
    }
}