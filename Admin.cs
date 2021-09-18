using System;
using System.Collections.Generic;
using System.Text;

namespace StudiaProject
{
    class Admin
    {
        public bool lang = false;
        private bool active = false, admin = false;
        private string password;
        private string name;






        public Admin(string name, bool admin, string pass)
        {
            this.active = false;
            this.admin = admin;
            this.password = pass;
            this.name = name;
            lang = false;

        }



        public void delAdmin(Admin acc)
        {
            if (acc.getAdmin())
                acc = null;

        }
        public void banAccount(Account banAcc, int howLong, string reason)
        {
            if (banAcc.getActive())
            {
                if (getAdmin())
                {
                    banAcc.setActive(false);
                    banAcc.setHowLong(howLong);
                    banAcc.setBanReason(reason);


                }




            }
        }
        public void setLanguage(bool langs)
        {
            this.lang = langs;
        }
        public void setActive(bool act)
        {
            this.active = act;
        }

        public bool getActive()
        {
            return this.active;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPassword()
        {
            return this.password;
        }
        public bool getAdmin()
        {
            return this.admin;
        }
        public void setAdmin(bool act)
        {
            this.admin = act;
        }

        public override string ToString()
        {

          
            string activ = "";
            if (this.lang == false)
            {
             
                
                if (this.active) activ = "Yes";
                else activ = "No";

                return $"Online: " + activ + ", Admin name: " + this.name; ;
            }
            else
            {
             

                if (this.active) activ = "Tak";
                else activ = "Nie";

                return $"Online: " + activ + ", Nazwa Administratora: " + this.name; ;

            }
        }

    }
}
