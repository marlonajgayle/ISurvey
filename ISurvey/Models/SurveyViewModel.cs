using System.Collections.Generic;

namespace ISurvey.Models
{
    public class SurveyViewModel
    {
        public string Question { get; set; }
        public int TotalVotes { get; set; }
        public IList<Choice> Choices { get; set; }

        public SurveyViewModel(Survey survey)
        {
            Question = survey.Question;
            Choices = new List<Choice>();
            foreach (Choice choice in survey.Choices)
            {
                Choices.Add(choice);
                TotalVotes += choice.Votes;

            }
        }
    }
}
