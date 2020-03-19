using ISurvey.Interfaces;
using ISurvey.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ISurveyTests
{
    public class SurveyTests
    {
       

        [Fact]
        public void TotalVotesTest()
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
            };
            
            SurveyViewModel model = new SurveyViewModel(
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
            );
            Assert.Equal(29, model.TotalVotes);
        }
    }
}
