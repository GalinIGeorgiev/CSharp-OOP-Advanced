﻿namespace BashSoft.Repository
{
    using System.Collections.Generic;

    public interface IDataFilter
    {
        void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake);
    }
}
