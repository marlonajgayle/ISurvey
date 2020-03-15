using ISurvey.Interfaces;
using ISurvey.Models;
using System.Collections.Generic;

namespace ISurvey.Repositories
{
    public class MockSurveyRepository : ISurveyRepository
    {
        public List<Survey> surveys { get; set; }

        public MockSurveyRepository()
        {
            surveys = new List<Survey>()
            {
                new Survey()
                {
                    SurveyId = 1,
                    Question = "What should we have for lunch?",
                    Choices = new List<Choice>()
                    {
                        new Choice() { ChoiceId = 1, Name = "Chicken Katsu", Votes = 16 },
                        new Choice() { ChoiceId = 1, Name = "Oxtail and Beans", Votes = 8 },
                        new Choice() { ChoiceId = 1, Name = "Curried Goat", Votes = 5 }
                    }
                }
            };
        }

        public Survey GetSurvey(int id)
        {
            return surveys.Find(e => e.SurveyId == id);
        }
    }
}