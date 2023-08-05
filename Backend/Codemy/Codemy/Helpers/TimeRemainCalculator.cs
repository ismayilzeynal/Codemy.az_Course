namespace Codemy.Helpers
{
    public class TimeRemainCalculator
    {
        public static string RemainingTimeCalculate(DateTime dt)
        {
            string Result = "";
            TimeSpan timeAgo = DateTime.Now - dt;
            if(timeAgo > TimeSpan.Zero)
            {
                Result =" ago";
            }
            else
            {
                Result = " left";
                timeAgo = timeAgo.Duration();
            }
            return FormatTimeAgo(timeAgo) + Result;
        }

        static string FormatTimeAgo(TimeSpan timeSpan)
        {
            if (timeSpan.TotalSeconds < 60)
            {
                return $"{timeSpan.Seconds} seconds";
            }
            else if (timeSpan.TotalMinutes < 60)
            {
                return $"{timeSpan.Minutes} minutes";
            }
            else if (timeSpan.TotalHours < 24)
            {
                return $"{timeSpan.Hours} hours";
            }
            else if (timeSpan.TotalDays < 30)
            {
                return $"{timeSpan.Days} days";
            }
            else if (timeSpan.TotalDays < 365)
            {
                int months = (int)(timeSpan.TotalDays / 30);
                return $"{months} {(months == 1 ? "month" : "months")}";
            }
            else
            {
                int years = (int)(timeSpan.TotalDays / 365);
                return $"{years} {(years == 1 ? "year" : "years")}";
            }
        }
    }
}
