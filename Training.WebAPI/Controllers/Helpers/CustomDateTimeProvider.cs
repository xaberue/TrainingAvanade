using System;

namespace Training.WebAPI.Controllers.Helpers
{
    public interface ICustomDateTimeProvider
    {
        DateTime GetCurrentSystemDate();
    }

    public class CustomDateTimeProvider : ICustomDateTimeProvider
    {
        public DateTime GetCurrentSystemDate()
        {
            return DateTime.Now;
        }
    }
}
