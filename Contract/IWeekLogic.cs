namespace Contract
{
    using System;
    using System.Collections.Generic;

    public interface IWeekLogic
    {
        IEnumerable<DayOfWeek> GetWeeks();
    }
}