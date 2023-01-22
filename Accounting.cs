using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Accounting
{
    [Serializable]

    public class Accounting
    {
        public Guid Id { get; set; }

        public Accounting(Guid ID)
        {
            Id = ID;
        }

        Dictionary<string, Dictionary<DateTime, int>> AccountingData = new Dictionary<string, Dictionary<DateTime, int>>();
        /// <summary>
        /// Добавление категории
        /// </summary>
        /// <param name="category"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddCategory(string category)
        {
            if(category == null || category == String.Empty)
            {
                throw new ArgumentException("Категория пустая");
            }
            if (AccountingData.ContainsKey(category))
            {
                throw new ArgumentException("Такая категория уже есть ");
            }
            AccountingData.Add(category, new Dictionary<DateTime, int>());
        }
        /// <summary>
        /// Удаление категории
        /// </summary>
        /// <param name="category"></param>
        /// <exception cref="ArgumentException"></exception>
        public void DeleteCategory(string category)
        {
            if (category == null || category == String.Empty)
            {
                throw new ArgumentException("Категория не выбрана");
            }
            if (AccountingData.ContainsKey(category))
            {
                AccountingData.Remove(category);
            }
            else
            {
                throw new ArgumentException("Такой категории нет");
            }

        }
        /// <summary>
        /// Добавление расхода в данную категорию
        /// </summary>
        /// <param name="category"></param>
        /// <param name="date"></param>
        /// <param name="summ"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddExpenseItem(string category, DateTime date, int summ)
        {
            if (category == null || category == String.Empty || date == null )
            {
                throw new ArgumentException("Заполнены не все данные");
            }
            if (!AccountingData.ContainsKey(category))
            {
                throw new ArgumentException("Такой категории нет");
            }
            AccountingData[category][date] = summ;
        }
        /// <summary>
        /// Получение расхода данной категории за определённый день
        /// </summary>
        /// <param name="category"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int GetExpenseItem(string category,DateTime date)
        {
            if (category == null || category == String.Empty || date == null)
            {
                throw new ArgumentException("Заполнены не все данные");
            }
            if (!AccountingData.ContainsKey(category))
            {
                throw new ArgumentException("Такой категории нет");
            }
            if (!AccountingData[category].ContainsKey(date))
            {
                throw new ArgumentException("За этот день по данной категории расходов нет");
            }

            return AccountingData[category][date];
        }
        /// <summary>
        /// Сумма расходов одной категории за определённый период
        /// </summary>
        /// <param name="category"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int GetSum(string category,DateTime start,DateTime stop)
        {
            if (category == null || category == String.Empty || start  == null || stop == null)
            {
                throw new ArgumentException("Заполнены не все данные");
            }
            if (!AccountingData.ContainsKey(category))
            {
                throw new ArgumentException("Такой категории нет");
            }
            return AccountingData[category].Sum(x => (x.Key >= start && x.Key <= stop) ? x.Value : 0 ) ;

        }
        /// <summary>
        /// Получение всего списка категорий
        /// </summary>
        /// <returns></returns>
        public List<string>GetCategoryList()
        {
            if(AccountingData.Count == 0 )
            { return new List<string>(); }
            return AccountingData.Keys.ToList();
        }

        public AccountingTable GetAccountingTable()
        {
            List<string> categories = GetCategoryList();

            List<DateTime> dates = new List<DateTime>(); 

            foreach(string category in categories)
            {
                foreach(DateTime date in AccountingData[category].Keys)
                {
                    if(!dates.Contains(date)) 
                        dates.Add(date);
                }

            }
            AccountingTable accountingTable = new AccountingTable(categories,dates);

            for(int i = 0;i < categories.Count;i++)
            {
                for(int j = 0;j< dates.Count;j++)
                {
                    if (AccountingData[categories[i]].ContainsKey(dates[j]))
                    {
                        accountingTable.Values[i, j] = AccountingData[categories[i]][dates[j]];
                    }
                }
            }
            return accountingTable;
        }
       

    }
}
