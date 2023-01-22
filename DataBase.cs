using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home_Accounting
{
    public class DataBase
    {

        public IFormatter formatter { get; set; }

        public string UserFilePath { get; set; }

        public string AccountingFilePath { get; set; }


        public User GetUser(string login, string password)
        {
            List<User> users = null;
            using (FileStream fs = new FileStream(UserFilePath, FileMode.OpenOrCreate))
            {
                if (fs.Length !=0)
                {
                    users = (List<User>)formatter.Deserialize(fs);
                }
            }
            if (users == null)
            {
                throw new ArgumentException("Нет такого пользователя");
            }
            return users.Find(x => x.Login == login && x.Password == password);
        }

        public Accounting GetAccounting(Guid guid)
        {
            List<Accounting> accounts = null;

            using (FileStream fs = new FileStream(AccountingFilePath, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    accounts = (List<Accounting>)formatter.Deserialize(fs);
                }

            }
            if (accounts == null)
            {
                throw new ArgumentException("Такой буxгалтерии нет");
            }
            return accounts.Find(x => x.Id == guid);
        }

        public void AddUser(User user)
        {
            List<User> users = null;
            using (FileStream fs = new FileStream(UserFilePath, FileMode.OpenOrCreate))
            {

                if (fs.Length != 0)
                {
                    users = (List<User>)formatter.Deserialize(fs);
                }
            }
            if (users == null)
            {
                users = new List<User>();
            }

            if (users.Find(x => x.Login == user.Login) == null)
            {
                users.Add(user);
                using (FileStream fs = new FileStream(UserFilePath, FileMode.OpenOrCreate))
                {

                    formatter.Serialize(fs, users);
                }
            }
            else
            {
                throw new ArgumentException("Пользователь с таким логином уже есть");
            }

        }
        public void AddAccounting(Accounting accounting)
        {
            List<Accounting> accounts = null;
            using (FileStream fs = new FileStream(AccountingFilePath, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    accounts = (List<Accounting>)formatter.Deserialize(fs);
                }
            }
            if (accounts == null)
            {
                accounts = new List<Accounting>();
            }
            accounts.Add(accounting);
            using (FileStream fs = new FileStream(AccountingFilePath, FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, accounts);
            }
            
        }
        public void ChangeAccouting(Accounting accounting)
        {
            List<Accounting> accounts = null;
            using (FileStream fs = new FileStream(AccountingFilePath, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                {
                    accounts = (List<Accounting>)formatter.Deserialize(fs);
                }
            }
            if (accounts == null)
            {
                accounts = new List<Accounting>();
            }
           accounts.Remove( accounts.Find(a => a.Id == accounting.Id));
            accounts.Add(accounting);
            using (FileStream fs = new FileStream(AccountingFilePath, FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, accounts);
            }
        }

    }
}
