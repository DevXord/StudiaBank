using System;
using System.Collections.Generic;
using System.Text;

namespace StudiaProject
{



    class Account
    {

        private bool active;
        private string password;
        private string reason;
        private int credit;
        private bool isCredit;
        private int howLong;
        private string name;
        private bool ban;
        private int accountBalance;
        public  bool lang = false;
        List<string> accounthistory = new List<string>();
        List<int> accounthistorymoney = new List<int>();



        public Account(string name, string password, int accountBalance)
        {

            this.lang = false;
            this.active = false;
            this.password = password;
            this.name = name;
            this.reason = "";
            this.howLong = 0;
            this.credit = 0;
            this.isCredit = false;
            this.ban = false;
            this.accountBalance = accountBalance;
            this.accounthistory = new List<string>();
            this.accounthistorymoney = new List<int>();


        }


        public void payoffcredit(User u,int pcredittvalue)
        {
   
            if (u.getUserAccount() != null)
            {
                if (u.getUserAccount().getCredit() == true)
                {
                    if (pcredittvalue >= u.getUserAccount().getHowMuchToPay())
                    {
                        if ((u.getUserAccount().getAccountBalance() >= u.getUserAccount().getHowMuchToPay()))
                        {
                            u.getUserAccount().setCredit(false);
                            u.getUserAccount().setHowMuchToPay(0);
                            u.getUserAccount().setAccountBalance(u.getUserAccount().getAccountBalance() - pcredittvalue);
                        }
                    }




                }
            }
        }
        public void takecredit(User u, int creditvalue)
        {
            if (u.getUserAccount() != null)
            {
                if (u.getUserAccount().getCredit() == false)
                {
                    u.getUserAccount().setCredit(true);
                    u.getUserAccount().setHowMuchToPay(creditvalue);
                    u.getUserAccount().setAccountBalance(u.getUserAccount().getAccountBalance() + creditvalue);
                }
            }
        }

        public void setLanguage(bool langs)
        {
            this.lang = langs;
        }
        public void setAccountHistoryMoney(int ahis)
        {
            this.accounthistorymoney.Add(ahis);
        }
        public List<int> getAccountHistoryMoney()
        {
            return this.accounthistorymoney;
        }

        public void setAccountHistory(string ahis)
        {
            this.accounthistory.Add(ahis);
        }
        public List<string> getAccountHistory()
        {
            return this.accounthistory;
        }

        public void setAccountBalance(int accbala)
        {
            this.accountBalance = accbala;
        }
        public int getAccountBalance()
        {
            return this.accountBalance;
        }
        public void setActive(bool act)
        {
            this.active = act;
        }

        public bool accountIsBanned()
        {
            return this.ban;
        }
        public void accountBanned(bool bane)
        {
            this.ban = bane;
        }

        public bool getActive()
        {
            return this.active;
        }

        public void setCredit(bool act)
        {
            this.isCredit = act;
        }

        public bool getCredit()
        {
            return this.isCredit;
        }

        public int getHowMuchToPay()
        {
            return this.credit;
        }
        public void setHowMuchToPay(int cr)
        {
            this.credit = cr;
        }



        public string getBanReason()
        {
            return this.reason;
        }
        public void setBanReason(string reason)
        {
            this.reason = reason;
        }
        public int getHowLong()
        {
            return this.howLong;
        }
        public void setHowLong(int hlong)
        {
            this.howLong = hlong;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPassword()
        {
            return this.password;
        }
        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public override string ToString()
        {
            string credstr = "";
            string activ = "";
            if (this.lang == false)
            {


                if (this.isCredit == true)
                    credstr = "Yes, " + this.credit + "$";
                else 
                    credstr = "No";
                   
                
                
                if (this.active) activ = "Yes";
                else activ = "No";

                return $"Online: " + activ + ", Accout name: " + this.name + ", Account Balance: " + this.accountBalance + ", Credit: " + credstr + "";
            }
            else
            {
              

                if (this.isCredit == true) credstr = "Tak, " + this.credit+"$";
                else credstr = "nie";
                
                if (this.active) activ = "Tak";
                else activ = "Nie";

                return $"Online: " + activ + ", Nazwa konta: " + this.name + ", Stan konta: " + this.accountBalance + ", Kredyt: " + credstr + "";

            }



        }

    }
}
