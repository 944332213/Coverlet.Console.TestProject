namespace Implement
{
    using Contract;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class DateLogic : IDateTimeLogic, IWeekLogic
    {
        private DayOfWeek[] _dayOfWeeks;

        public DayOfWeek GetNowDayOfWeek()
        {
            return DateTimeOffset.Now.DayOfWeek;
        }

        public IEnumerable<DayOfWeek> GetWeeks()
        {
            return _dayOfWeeks ??= Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToArray();
        }
    }
}