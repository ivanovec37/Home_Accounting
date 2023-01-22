using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Accounting
{
    public class AccountingTable 
    {
        public string[] Categories { get;private set; }

        public DateTime[] DateTimes { get;private set; }

        public int[,] Values { get; set; }

        public AccountingTable(IEnumerable<string> categories, IEnumerable<DateTime>dates)
        {
            if(categories.Count() == 0|| dates.Count() == 0)
            {
                throw new ArgumentException("Таблица пустая");
            }
            Categories = categories.ToArray();
            DateTimes = dates.ToArray();

            Values = new int[Categories.Length, DateTimes.Length];


        }
    }
}
