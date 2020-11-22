using System.Globalization;

namespace ConferenceApp.Extensions
{
    public static class DateTimeExtension
    {
        public static string IntToMonthName(int value)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(value);
        }
    }
}
