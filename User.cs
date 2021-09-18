using System;
using System.Collections.Generic;
using System.Text;

namespace StudiaProject
{
    class User
    {
        public  bool lang = false;
        private int cash;
        private string name;
        private Account userAcc;

        public User(int cash, string name)
        {
            this.cash = cash;
            this.name = name;
            this.userAcc = null;
            lang = false;
        }
        public void setLanguage(bool langs)
        {
            this.lang = langs;
        }
        public int getMoney()
        {
            return cash;
        }
        public void setMoney(int m)
        {
            cash = m;
        }
        public string getName()
        {
            return name;
        }
        public void setUserAccount(Account us)
        {
            this.userAcc = us;
        }
        public Account getUserAccount()
        {
            return this.userAcc;
        }
        public override string ToString()
        {
            if (lang == false)
            {


                if (this.userAcc != null)
                {
                    return $"Name: " + this.name + ", Money: " + this.cash + "$, Account info: Name: " + userAcc.getName() + ", Password: " + userAcc.getPassword();
                }
                else
                {
                    return $"Name: " + this.name + ", Money: " + this.cash + "$, Account info: No account";
                }
            }
            else
            {
                if (this.userAcc != null)
                {
                    return $"Imie: " + this.name + ", Pieniądze: " + this.cash + "$, Informacje o koncie: Nazwa konta: " + userAcc.getName() + ", Hasło: " + userAcc.getPassword();
                }
                else
                {
                    return $"Imie: " + this.name + ", Pieniądze: " + this.cash + "$, Informacje o koncie: Nie posiada";
                }
            }
         
        }

    }
}
