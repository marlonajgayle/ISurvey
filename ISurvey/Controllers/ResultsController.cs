using ISurvey.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            return View(surveyRepository.GetSurvey(1));
        }
    }
}