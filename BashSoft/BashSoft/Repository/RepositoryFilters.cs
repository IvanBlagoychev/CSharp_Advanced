using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft.Classes
{
    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentsToTake)
        {
            wantedFilter = wantedFilter.ToLower();

            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x=> x>= 5, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => x < 5 && x>= 3.5, studentsToTake);
            }
            else if (wantedFilter == "poor") FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
            else OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
        }
        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;
            foreach (var userName_Points in wantedData)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }
                double AverageScore = userName_Points.Value.Average();
                double percentageOfFullfillments = AverageScore / 100;
                double mark = percentageOfFullfillments * 4 + 2;
                
                if (givenFilter(mark))
                {
                    OutputWriter.DisplayStudent(userName_Points);
                    counterForPrinted++;
                }
            }
        }
    }
}
