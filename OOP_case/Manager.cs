using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case
{
    public class Manager
    {
        public BoxOffice BoxOffice { get; set; }
        public Manager(BoxOffice boxOffice)
        {
            BoxOffice = boxOffice;
        }
        public void PrintDailyBalance(DateTime date)
        {
            BoxOffice.Balance.Where(x => x.Key.DayOfWeek.Equals(date.DayOfWeek)).Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }
    }
}
