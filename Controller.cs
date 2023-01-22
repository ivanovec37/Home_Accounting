using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Home_Accounting
{
    public class Controller
    {
        private User user { get; set; } = null;

        private Accounting accounting { get; set; } = null;

        private DataBase dataBase { get; set; } = new DataBase();

        public Controller()
        {
            dataBase.formatter = new BinaryFormatter();
            dataBase.UserFilePath = "Users.bin";
            dataBase.AccountingFilePath = "Accounting.bin";
        }

        public string Registration(string login, string password)
        {

            try
            {
                if(login == null || password == null || login == String.Empty || password == String.Empty)
                {
                    throw new ArgumentException("Данные не заполненны");
                }
                User user1 = new User(login, password);
                dataBase.AddUser(user1);
                Accounting accounting1 = new Accounting(user1.Id);
                dataBase.AddAccounting(accounting1);
                user = user1;
                accounting = accounting1;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }
        public string Authorization(string login, string password)
        {
            try
            {
                if (login == null || password == null || login == String.Empty || password == String.Empty)
                {
                    throw new ArgumentException("Данные не заполненны");
                }
                user = dataBase.GetUser(login, password);
                if(user == null)
                {
                    throw new ArgumentException("Такого пользователя нет");
                }
                accounting = dataBase.GetAccounting(user.Id);
                
                
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return null;
        }
        public string AddCategory(string category)
        {
            try
            {
                if (accounting == null)
                {
                    throw new Exception("Нет авторизации");
                }
                accounting.AddCategory(category);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return null;
        }

        public string DeleteCategory(string category)
        {
            try
            {
                if (accounting == null)
                {
                    throw new Exception("Нет авторизации");
                }
                accounting.DeleteCategory(category);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return null;

        }

        public string AddExpenseItem(string category, DateTime date, int summ)
        {
            try
            {
                if (accounting == null)
                {
                    throw new Exception("Нет авторизации");
                }
                accounting.AddExpenseItem(category,date,summ);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return null;
        }
        public string GetSum(string category, DateTime start, DateTime stop,out int summ)
        {
            try
            {
                if (accounting == null)
                {
                    throw new Exception("Нет авторизации");
                }
               summ = accounting.GetSum(category, start,stop);

            }
            catch (Exception ex)
            {
                summ = 0;
                return ex.Message;
            }
            return null;
        }

        public string GetAccountingTable(out AccountingTable accountingTable)
        {
            try
            {
                if (accounting == null)
                {
                    throw new Exception("Нет авторизации");
                }
                accountingTable = accounting.GetAccountingTable();
            }
            catch (Exception ex)
            {
                accountingTable = null;
                return ex.Message;
            }
            return null;
        }
        public List<string> GetCategoryList()
        {
            if(accounting == null)
            {
                return new List<string>();
            }
           return accounting.GetCategoryList();
        }
        public void ChangeAccouting()
        {
            dataBase.ChangeAccouting(accounting);
        }

    }
}
