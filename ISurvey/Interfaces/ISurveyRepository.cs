using ISurvey.Models;

namespace ISurvey.Interfaces
{
   public interface ISurveyRepository
    {
        Survey GetSurvey(int id);
    }
}
