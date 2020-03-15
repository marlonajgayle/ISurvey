using System.Collections.Generic;

namespace ISurvey.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string Question { get; set; }
        public IList<Choice> Choices { get; set; }

        public Survey()
        {
            Choices = new List<Choice>();
        }
    }
}