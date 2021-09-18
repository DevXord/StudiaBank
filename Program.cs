using System;
using System.Collections.Generic;
using System.Linq;



 


namespace StudiaProject
{
    class Program
    {
        const double TAKE_BANK_PROC_FROM_TANSFER = 0.10;
        const double TAKE_BANK_PROC_FROM_CREDIT = 0.15;
        const int MAX_PROGRAM_LANGUAGE = 10;
        public static bool lang = false;
        public static bool complete = false;
        public static bool complete2 = false;
        public static int accountBankBalance = 1000000;
        private static System.Timers.Timer datatimer;
        public static string data, formatstring ="";


        


        private static void OnTimedEvent(Object source,System.Timers.ElapsedEventArgs e)
        {
            data = "" + DateTime.Now.Day.ToString("D2") + "/" + DateTime.Now.Month.ToString("D2") + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2");
        }



        static void showAccounts(List<Account> acc, bool cler)
        {
            if (cler)
                Console.Clear();
            foreach (Account item in acc)
            {
                item.setLanguage(lang);
                Console.WriteLine(item.ToString());
                complete = true;

            }
            if (complete == true)
            {
                complete = false;
                ChooseLanguage(lang, "", "", false, true, true);
            }
            else
            {
                complete = false;
                ShowErrorMessage(lang, 2, "Accounts not found", "Nie znaleziono kont", cler, true);

            }

        }

        static void showAdmins(List<Admin> adm, bool cler)
        {
            if (cler)
                Console.Clear();
            foreach (Admin item in adm)
            {
                item.setLanguage(lang);
                Console.WriteLine(item.ToString());
                complete = true;
            }
            if (complete == true)
            {
                complete = false;
                ChooseLanguage(lang, "", "", false, true, true);
            }
            else
            {
                complete = false;
                ShowErrorMessage(lang, 2, "Admins not found", "Nie znaleziono Adminnistratorów", cler, true);

            }


        }
        static void showUser(List<User> us, bool cler)
        {
            if (cler)
                Console.Clear();
            foreach (User item in us)
            {
                item.setLanguage(lang);
                Console.WriteLine(item.ToString());
                complete = true;
            }
            if (complete == true)
            {
                complete = false;
                ChooseLanguage(lang, "", "", false, true, true);
            }
            else
            {
                complete = false;
                ShowErrorMessage(lang, 2, "Users not found", "Nie znaleziono Użytkowników", cler, true);

            }

        }
        static void ShowAdminCommand()
        {
         

            ChooseLanguage(lang, "Ban - Banned account", "Ban - Zablokuj konto", false, false, true);
            ChooseLanguage(lang, "Add - Add account", "Add - Dodaj konto", false, false, true);
            ChooseLanguage(lang, "AllAdmin - Check all admin", "AllAdmin - Sprawdź wszystkich administratorów", false, false, true);
            ChooseLanguage(lang, "AllAccount - Check all account", "AllAccount - Sprawdź wszystkie konta", false, false, true);
            ChooseLanguage(lang, "AllUser - Check all user in bank", "AllUser - Sprawdź wszystkich użytkowników w banku", false, false, true);
            ChooseLanguage(lang, "SetAdmin - Set admin", "SetAdmin - Ustaw administratora", false, false, true);
            ChooseLanguage(lang, "SetUser - Set user account", "SetUser - Dodaj użytkownika do konta", false, false, true);
            ChooseLanguage(lang, "DelUser - Delete user account", "DelUser - Usuń użytkownika z konta", false, false, true);
            ChooseLanguage(lang, "Delete - Delete account", "Delete - Usuń konto", false, false, true);
            ChooseLanguage(lang, "AllMoney - Check how much money is in the bank", "AllMoney - Sprawdź ile pieniedzy jest w banku", false, false, true);
            ChooseLanguage(lang, "AllCredit - Check how much money the users has to return", "AllCredit - Sprawdz ilu użytkowników musi spłacić kredyt", false, false, true);
            ChooseLanguage(lang, "AccountCheck - Check how much money has account ", "Accountcheck - Sprawdź jak duzo pieniedzy jest na koncie ", false, false, true);
            ChooseLanguage(lang, "Crediter - Check crediter", "Crediter - Sprawdz dłużnika", false, false, true);
            ChooseLanguage(lang, "LogOut - Log out", "LogOut - Wyloguj się", false, true, true);


        }
        static void ShowUserCommand()
        {
         


            ChooseLanguage(lang, "PayIn - Deposit your money", "PayIn - Wpłać pieniądze", false, false, true);
            ChooseLanguage(lang, "PayOut - Pay out your money", "PayOut - Wypłać pieniądze", false, false, true);
            ChooseLanguage(lang, "CheckHistory - Check the history of operations on the account", "CheckHistory - Sprawdź historię operacji na koncie", false, false, true);
            ChooseLanguage(lang, "PaymentSum -  Check your payment summary", "PaymentSum -  Sprawdź sume wpłat", false, false, true);
            ChooseLanguage(lang, "TakeCredit - Take a loan", "TakeCredit - Weź kredyt", false, false, true);
            ChooseLanguage(lang, "PayOffCredit - Pay of a loan", "PayOffCredit - Spłać kredyt", false, false, true);
            ChooseLanguage(lang, "Transfer - Transfer money to another account", "Transfer - Przelej pieniadze na inne konto", false, false, true);
            ChooseLanguage(lang, "LogOut - Log out", "LogOut - Wyloguj się", false, true, true);


        }
        static void ShowUniversalCommand()
        {


            ChooseLanguage(lang, "ChooseLang - Choose Polish language", "ChooseLang - Zmień jezyk na Angielski", false, false, true);
            ChooseLanguage(lang, "ChooseUser - Choose User", "ChooseUser - Zmień Użytkownika", false, false, true);
            ChooseLanguage(lang, "AdminLogin - Log in as Admin", "AdminLogin - Zaloguj sie jako Administrator", false, false, true);
            ChooseLanguage(lang, "UserLogin - Log in as User", "UserLogin - Zaloguj sie jako Użytkownik", false, false, true);
            ChooseLanguage(lang, "Exit - Exit", "Exit - Wyjdź", false, true, true);


        }

        static void ShowErrorMessage(bool langs, int type, string message1, string message2, bool cler, bool newline)
        {
            if (cler == true)
                Console.Clear();
            switch (type)
            {
                case 0:
                    if (langs == false)
                        Console.WriteLine("|Login error| " + message1);
                    else
                        Console.WriteLine("|Błąd logowania| " + message2);
                    break;

                case 1:
                    if (langs == false)
                        Console.WriteLine("|Search error| " + message1);
                    else
                        Console.WriteLine("|Błąd wyszukiwania| " + message2);
                    break;
                case 2:

                    if (langs == false)
                        Console.WriteLine("|Error| " + message1);
                    else
                        Console.WriteLine("|Błąd| " + message2);
                    break;
                case 3:
                    if (langs == false)
                        Console.WriteLine("|Warning| " + message1);
                    else
                        Console.WriteLine("|Ostrzeżenie| " + message2);

                    break;
                case 4:
                    if (langs == false)
                        Console.WriteLine("|Ban| " + message1);
                    else
                        Console.WriteLine("|Blokada| " + message2);

                    break;
            }
            if (newline == true)
                Console.WriteLine();

        }

        static void ChooseLanguage(bool lnags, string message1, string message2, bool cler, bool newline, bool writeline)
        {
            if (cler == true)
                Console.Clear();
            switch (lnags)
            {
                case true:
                    if (writeline == true)
                        Console.WriteLine(message2);
                    else
                        Console.Write(message2);
                    break;

                case false:
                    if (writeline == true)
                        Console.WriteLine(message1);
                    else
                        Console.Write(message1);
                    break;


            }
            if (newline)
                Console.WriteLine();
        }


        static void Main(string[] args)
        {
            bool isProgramRun = true;
            string readlogin, readpass;
            bool adminlog = false, userlog = false;
            string odp;
            User youis;

            datatimer = new System.Timers.Timer();
            datatimer.Interval = 100;

            datatimer.Elapsed += OnTimedEvent;


            datatimer.AutoReset = true;

            datatimer.Enabled = true;

     


            List<Account> acco = new List<Account>();
            List<Admin> a = new List<Admin>();
            List<User> user = new List<User>();

            user.Add(new User(1000, "Fabian"));
            user.Add(new User(2500, "Kazi"));
            user.Add(new User(1000000, "Geralt"));
            user.Add(new User(1, "Krystian"));

            youis = user[0];
            youis.setLanguage(lang);
            a.Add(new Admin("root", true, "root"));

           
            while (isProgramRun)
            {

                
               
                ChooseLanguage(lang, "Welcome at the StudiaBank!", "Witaj w StudiaBank!", false, true, true);

                 

                ChooseLanguage(lang, "You are:", "Jesteś:", false, false, true);
                ChooseLanguage(lang, youis.ToString(), youis.ToString(), false, true, true);



                ShowUniversalCommand();

                ChooseLanguage(lang, "", "", false, false, true);
                ChooseLanguage(lang, "What you want to do?", "Co chcesz zrobic?", false, false, true);
                ChooseLanguage(lang, ">> ", ">> ", false, false, false);
                odp = Console.ReadLine();
                switch (odp.ToLower())
                {
                    case "chooselang":
                        #region Chose language
                        if (lang)
                            lang = false;
                        else
                            lang = true;
                        youis.setLanguage(lang);
                        Console.Clear();
                        #endregion 
                        break;
                    case "chooseuser":
                        #region Chose user

                        ChooseLanguage(lang, "Users:", "Użytkownicy:", true, true, true);
                        showUser(user, false);

                        ChooseLanguage(lang, "Write name user:", "Wpisz nazwe użytkownika:", false, true, false);
                        ChooseLanguage(lang, ">> ", ">> ", false, false, false);
                        odp = Console.ReadLine();

                        foreach (User item in user)
                        {
                            if (item.getName() == odp)
                            {
                                youis = item;
                                ChooseLanguage(lang, "User set", "Użytkownik ustawiony", true, true, false);
                                break;
                            }

                            if (item.getName() != odp && user.IndexOf(item) == user.IndexOf(user.Last()))
                            {
                                ShowErrorMessage(lang, 1, "User not exists", "Użytkownik nie istnieje", true, true);

                            }
                        }

                        #endregion
                        break;
                    case "adminlogin":
                    #region Login admin
                    
                        Admin itema = null;
                        ChooseLanguage(lang, "", "", true, false, false);
                        ChooseLanguage(lang, "Please write your login and password", "Podaj login i hasło ", false, false, true);

                        ChooseLanguage(lang, "Login: ", "Login: ", false, false, false);
                        readlogin = Console.ReadLine();

                        ChooseLanguage(lang, "Password: ", "Hasło: ", false, false, false);
                        readpass = Console.ReadLine();

                        foreach (Account use in acco)
                        {
                            if (use.getName() == readlogin)
                            {
                                if (use.getPassword() == readpass)
                                {

                                    ShowErrorMessage(lang, 1, "Account don't found", "Nie znaleziono konta", true, true);

                                    complete = true;
                                    break;


                                }

                            }

                        }
                        if (complete == true)
                        {
                            complete = false;
                            break;
                        }



                        foreach (Admin item in a)
                        {
                            if (item.getName() == readlogin)
                            {
                                if (item.getPassword() == readpass)
                                {
                                    if (item.getAdmin() == true)
                                    {
                                        itema = item;

                                        break;
                                    }

                                  
                                }

                            }

                            if(item.getName() == readlogin && item.getPassword() == readpass && !item.getAdmin())
                            {
                                ShowErrorMessage(lang, 2, "Unauthorized access", "Nieautoryzowany dostęp", true, true);

                                complete = true;
                                break;
                            }

                            if (a.IndexOf(item) == a.IndexOf(a.Last()) && complete == false)
                            {
                                ShowErrorMessage(lang, 0, "Login or password are incompatible", "Login lub hasło jest nieprawidłowe", true, true);
                                complete = true;
                                break;
                            }
                        }
                        if (complete == true)
                        {
                            complete = false;
                            break;
                        }



                        if (!itema.getActive())
                            itema.setActive(true);
                        itema.setLanguage(lang);
                        adminlog = true;

                        ChooseLanguage(lang, "Hello " + itema.getName() + " you are Admin", "Witaj " + itema.getName() + " jesteś Administratorem", true, false, true);

                        while (adminlog)
                        {

                            ChooseLanguage(lang, "What you want to do?", "Co chcesz zrobic??", false, true, true);


                            ShowAdminCommand();

                            ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                            odp = Console.ReadLine();






                            switch (odp.ToLower())
                            {
                                case "ban":
                                    #region Ban/unban

                                    string reason, odpint;

                                    ChooseLanguage(lang, "Accounts:", "Konta:", false, true, true);
                                    showAccounts(acco, true);



                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", false, true, true);

                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    odpint = Console.ReadLine();


                                    ChooseLanguage(lang, "Write reason block account", "Wpisz podówd blokady", false, true, true);

                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    reason = Console.ReadLine();





                                    foreach (Account itemi in acco)
                                    {

                                        if (itemi.getName() == odpint)
                                        {
                                            if (!itemi.accountIsBanned())
                                            {
                                                Console.Clear();
                                                Console.WriteLine(itemi.ToString());
                                                Console.WriteLine();

                                                ChooseLanguage(lang, "Do you want banned this account? (yes/no)", "Czy chcesz zbanować te konto? (yes/no)", false, true, true);



                                                ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                                odpint = Console.ReadLine();
                                                if (odpint.ToLower() == "yes")
                                                {
                                                    itemi.accountBanned(true);
                                                    itemi.setBanReason(reason);

                                                    ChooseLanguage(lang, "Account is blocked", "Konto zostało zablokowane", true, true, true);
                                                    break;


                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    break;
                                                }

                                            }
                                            else
                                            {

                                                ShowErrorMessage(lang, 3, "The account is already blocked", "Te konto jest juz zablokowane", true, true);




                                                Console.WriteLine();
                                                Console.WriteLine(itemi.ToString());
                                                Console.WriteLine();
                                                ChooseLanguage(lang, "Do you want to unblock this account? (yes/no)", "Czy chcesz je odblokować? (yes/no)", false, true, true);


                                                ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                                odpint = Console.ReadLine();
                                                if (odpint.ToLower() == "yes")
                                                {

                                                    itemi.accountBanned(false);
                                                    itemi.setBanReason("");
                                                    itemi.setHowLong(0);

                                                    ChooseLanguage(lang, "Account is unlocked", "Konto zostało odblokowane", true, true, true);

                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    break;
                                                }


                                            }

                                        }

                                        if (itemi.getName() != odpint && acco.IndexOf(itemi) == acco.IndexOf(acco.Last()))
                                        {
                                            ShowErrorMessage(lang, 1, "Account not found", "Nie znaleziono konta", true, true);
                                            break;
                                        }






                                    }


                                    break;


                                #endregion

                                case "add":
                                    #region Add account
                                    string accname, accpass;

                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", true, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    accname = Console.ReadLine();

                                    ChooseLanguage(lang, "Write a new account password", "Wprowadź nowe hasło", false, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    accpass = Console.ReadLine();

                                    foreach (Account itemacc in acco)
                                    {
                                        if (itemacc.getName() == accname)
                                        {
                                            ShowErrorMessage(lang, 1, "Account already exists", "Konto już istnieje", true, true);
                                            complete = true;
                                            break;
                                        }
                                    }
                                    if (complete)
                                    {
                                        complete = false;
                                        break;
                                    }

                                    acco.Add(new Account(accname, accpass, 0));
                                    ChooseLanguage(lang, "Account added", "Konto dodano", true, true, true);
                                    Console.WriteLine();

                                    break;
                                #endregion
                                case "alladmin":
                                    #region All admin

                                    showAdmins(a, true);


                                    break;
                                #endregion
                                case "allaccount":
                                    #region All Account

                                    showAccounts(acco, true);


                                    break;
                                #endregion
                                case "alluser":
                                    #region All user

                                    showUser(user, true);


                                    break;
                                #endregion

                                case "setadmin":
                                    #region Set Admin
                                    string admname, admpass;



                                    ChooseLanguage(lang, "Write admin name", "Wpisz nazwe Administratora", true, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    admname = Console.ReadLine();

                                    foreach (Admin adm in a)
                                    {
                                        if (adm.getName() == admname)
                                        {
                                            ChooseLanguage(lang, "This Admin is exists, do you want to delete him? (yes/no)", "Administrator o tej nazwie juz istnieje, czy chcesz go usunać? (yes/no)", false, true, true);
                                            ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                            admname = Console.ReadLine();

                                            if (admname == "yes")
                                            {
                                                ChooseLanguage(lang, "The Admin has been removed", "Administrator został usunięty", true, true, true);
                                                a.Remove(adm);
                                                Console.WriteLine();
                                            }
                                            complete = true;
                                            break;
                                        }

                                    }
                                    if (complete)
                                    {
                                        complete = false;
                                        break;
                                    }

                                    ChooseLanguage(lang, "Write a new account password", "Podaj nowe hasło", false, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    admpass = Console.ReadLine();


                                    ChooseLanguage(lang, "The Admin has been added", "Administrator został dodany", true, true, true);
                                    a.Add(new Admin(admname, true, admpass));
                                    Console.WriteLine();

                                    break;







                                #endregion

                                case "setuser":
                                    #region Set User



                                    string username, accountname, userpassword;
                                    ChooseLanguage(lang, "Accounts:", "Konta:", true, true, true);
                                    showAccounts(acco, false);
                                    ChooseLanguage(lang, "Users:", "Użytkownicy:", false, true, true);
                                    showUser(user, false);

                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", false, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    accountname = Console.ReadLine();

                                    ChooseLanguage(lang, "Write User name", "Podaj nazwe Użytkownika", false, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    username = Console.ReadLine();

                                    foreach (User u in user)
                                    {



                                        if (u.getUserAccount() != null && u.getUserAccount().getName() == accountname)
                                        {
                                            complete = true;
                                            break;
                                        }
                                        if (u.getName() == username)
                                        {
                                            if (u.getUserAccount() != null)
                                            {
                                                complete2 = true;
                                                break;
                                            }
                                        }
                                    }
                                    if(complete2)
                                    {

                                        ShowErrorMessage(lang, 2, "This User is already assigned to the account", "Ten Użytkownika jest juz przypisane do konta", true, true);
                                        complete2 = false;
                                        break;
                                        
                                    }

                                        if (complete)
                                    {
                                        ShowErrorMessage(lang, 2, "This account is already assigned to the User", "Te konto jest juz przypisane do Użytkownika", true, true);
                                        complete = false;
                                        break;
                                    }

                                    foreach (User u in user)
                                    {
                                        if (u.getName() == username)
                                        {
                                            if (u.getUserAccount() != null)
                                            {
                                                if (u.getUserAccount().getName() == accountname)
                                                {
                                                    ShowErrorMessage(lang, 3, "This User already has an account, do you want to delete them? (yes/no)", "Ten Użytkownik posiada juz konto, czy chcesz je usunać? (yes/no)", false, true);
                                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                                    username = Console.ReadLine();

                                                    if (username == "yes")
                                                    {

                                                        ChooseLanguage(lang, "The account User " + u.getName() + " has been delete", "Konto Użytkownika " + u.getName() + " zostało usunięte", true, true, true);


                                                        u.setUserAccount(null);
                                                        complete = true;
                                                        break;
                                                    }
                                                    complete = true;
                                                    break;

                                                }


                                            }


                                        }


                                    }
                                    if (complete)
                                    {
                                        Console.Clear();
                                        complete = false;
                                        break;
                                    }
                                    ChooseLanguage(lang, "Write a new account password", "Podaj nowe hasło", false, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    userpassword = Console.ReadLine();





                                    foreach (User u in user)
                                    {
                                        if (u.getName() == username)
                                        {
                                            if (u.getUserAccount() == null)
                                            {
                                                foreach (Account au in acco)
                                                {

                                                    if (au.getName() == accountname)
                                                    {
                                                        ChooseLanguage(lang, "Account has been added to User " + u.getName(), "Konto zostało dodane do Użytkownika  " + u.getName(), true, true, true);
                                                        u.setUserAccount(au);
                                                        au.setPassword(userpassword);
                                                        Console.WriteLine();
                                                        break;
                                                    }


                                                }
                                                break;


                                            }

                                        }
                                        if (u.getName() != username && user.IndexOf(u) == user.IndexOf(user.Last()))
                                        {


                                            ShowErrorMessage(lang, 1, "This User not exists", "Ten Użytkownik nie istnieje", true, true);
                                            break;

                                        }
                                    }

                                    break;

                                #endregion
                                case "deluser":
                                    #region Delete User
                                    string dusername, daccountname;
                                    ChooseLanguage(lang, "Accounts:", "Konta:", true, true, true);
                                    showAccounts(acco, false);
                                    ChooseLanguage(lang, "Users:", "Użytkownicy:", false, true, true);

                                    foreach (User itemux in user)
                                    {
                                        if (itemux.getUserAccount() != null)
                                        {
                                            itemux.setLanguage(lang);
                                            Console.WriteLine(itemux.ToString());


                                        }
                                    }
                                    ChooseLanguage(lang, "", "", false, true, true);
                                    ChooseLanguage(lang, "Write account name", "Wpisz nazwę konta", false, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    daccountname = Console.ReadLine();
                                    ChooseLanguage(lang, "", "", false, true, true);
                                    ChooseLanguage(lang, "Write User name", "Wpisz nazwę Użytkownika", false, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    dusername = Console.ReadLine();

                                    foreach (User u in user)
                                    {

                                        if(u.getName() == dusername)
                                        {
                                            if (u.getUserAccount() != null && u.getUserAccount().getName() != daccountname)
                                            {
                                                complete = true;
                                                break;
                                            }

                                        }

                                     
                                       


                                    }
                                 

                                    if (complete)
                                    {
                                        ShowErrorMessage(lang, 2, "This account doesn't belong to this User", "Te konto nie należy do tego Użytkownika", true, true);
                                        complete = false;
                                        break;
                                    }



                                    foreach (User u in user)
                                    {
                                        if (u.getName() == dusername)
                                        {
                                            if (u.getUserAccount() != null)
                                            {
                                                foreach (Account au in acco)
                                                {

                                                    if (au.getName() == daccountname)
                                                    {
                                                        ChooseLanguage(lang, "This  User " + u.getName() + " has been removed from the account", "Ten Użytkownik " + u.getName() + " został usunięty z konta", true, true, true);
                                                        u.setUserAccount(null);
                                                       
                                                        Console.WriteLine();
                                                        complete = true;
                                                        break;
                                                    }

                                                    if (au.getName() != daccountname && acco.IndexOf(au) == acco.IndexOf(acco.Last()))
                                                    {
                                                        ShowErrorMessage(lang, 1, "Account not found", "Nie znaleziono konta", true, true);
                                                        break;
                                                    }


                                                }
                                                if (complete == true)
                                                {
                                                    complete = false;
                                                    break;
                                                }

                                            }
                                            if (u.getUserAccount() == null && user.IndexOf(u) == user.IndexOf(user.Last()))
                                            {
                                                ShowErrorMessage(lang, 1, "This user doesn't have an account", "Ten Użytkownik nie ma konta", true, true);
                                                break;
                                            }

                                        }

                                        if (u.getName() != dusername && user.IndexOf(u) == user.IndexOf(user.Last()))
                                        {
                                            ShowErrorMessage(lang, 1, "This user not exists", "Ten Użytkownik nie istnieje", true, true);
                                            break;
                                        }
                                    }

                                    break;



                                #endregion

                                case "delete":
                                    #region delete account
                                    string delname;

                                    ChooseLanguage(lang, "Accounts:", "Konta:", false, true, true);
                                    showAccounts(acco, true);

                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", false, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    delname = Console.ReadLine();




                                    foreach (Account itemax2 in acco)
                                    {
                                        if (itemax2.getName() == delname)
                                        {
                                            
                                            ChooseLanguage(lang, "Account exists:", "Konto istnieje:", true, true, true);

                                            ChooseLanguage(lang, itemax2.ToString(), itemax2.ToString(), false, true, true);




                                            ChooseLanguage(lang, "Do you want delete this account? (yes/no)", "Czy chcesz usunąć konto? (yes/no)", false, true, true);

                                            ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                            odp = Console.ReadLine();

                                            if (odp == "yes")
                                            {
                                                foreach (User itemuserin in user)
                                                {

                                                    if (itemuserin.getUserAccount().getName() == delname)
                                                    {
                                                        itemuserin.setUserAccount(null);
                                                        break;
                                                    }

                                                    
                                                }


                                                    ChooseLanguage(lang, "The account ", "Konto ", true, false, false);

                                                    ChooseLanguage(lang, "has been deleted", "zostało usunięte", false, true, true);


                                                    acco.Remove(itemax2);


                                                    break;

                                            }


                                        }


                                        if (itemax2.getName() != delname && acco.IndexOf(itemax2) == acco.IndexOf(acco.Last()))
                                        {
                                            ShowErrorMessage(lang, 1, "Account not found", "Nie znaleziono konta", true, true);
                                            break;
                                        }

                                    }


                                    break;
                                #endregion
                                case "allmoney":
                                    #region all money
                                    int creditmony = 0;
                                    int credithave = 0;

                                    Console.Clear();
                                    foreach (Account itemax in acco)
                                    {
                                        if (itemax.getCredit() == true)
                                        {

                                            credithave = Convert.ToInt32(Math.Round((itemax.getHowMuchToPay() * TAKE_BANK_PROC_FROM_CREDIT) + itemax.getHowMuchToPay()));


                                            Console.WriteLine(itemax.ToString());
                                            Console.WriteLine(itemax.getHowMuchToPay() + " + " + (TAKE_BANK_PROC_FROM_CREDIT * 100) + "% = " + credithave);
                                            Console.WriteLine();

                                            creditmony = creditmony + credithave;
                                        }
                                    }


                                    ChooseLanguage(lang, "There is now " + accountBankBalance + "$ in the bank", "W banku jest: " + accountBankBalance + "$", false, false, true);
                                    ChooseLanguage(lang, "Total credits " + credithave + "$", "Całośc kredytów wynosi: " + credithave + "$", false, false, true);
                                    ChooseLanguage(lang, "Together " + (credithave + accountBankBalance) + "$", "Razem: " + (credithave + accountBankBalance) + "$ ", false, true, true);


                                    break;
                                #endregion
                                case "allcredit":
                                    #region all credit
                                    int resultct = 0;
                                    int alltopay = 0;

                                    foreach (Account itemax in acco)
                                    {
                                        if (itemax.getCredit())
                                        {

                                            ChooseLanguage(lang, itemax.ToString(), itemax.ToString(), true, false, false);

                                            alltopay = Convert.ToInt32(Math.Round((itemax.getHowMuchToPay() * TAKE_BANK_PROC_FROM_CREDIT) + itemax.getHowMuchToPay()));
                                            resultct += alltopay;
                                            ChooseLanguage(lang, " -> " + itemax.getHowMuchToPay() + "$" + " + " + (TAKE_BANK_PROC_FROM_CREDIT * 100) + "% = " + alltopay, " -> " + itemax.getHowMuchToPay() + "$" + " + " + (TAKE_BANK_PROC_FROM_CREDIT * 100) + "% = " + alltopay + "$", false, false, false);
                                            ChooseLanguage(lang, "", "", false, true, true);
                                            complete = true;
                                        }
                                    }
                                    if (complete == true)
                                    {
                                        complete = false;
                                    }
                                    else
                                    {
                                        ShowErrorMessage(lang, 2, "Crediters not founds", "Nie znaleziono dłuzników", true, true);
                                        complete = false;
                                        break;
                                    }


                                    ChooseLanguage(lang, "Together to pay " + resultct + "$", "Razem do zapłaty " + resultct + "$", false, true, true);


                                    break;
                                #endregion
                                case "accountcheck":
                                    #region account check

                                    ChooseLanguage(lang, "Accounts:", "Konta:", true, true, true);
                                    foreach (Account itemx in acco)
                                    {
                                        ChooseLanguage(lang, itemx.getName() + ", ", itemx.getName() + ", ", false, false, false);

                                    }
                                    ChooseLanguage(lang, "", "", false, true, true);


                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", false, false, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    username = Console.ReadLine();

                                    Console.Clear();
                                    foreach (Account itemax in acco)
                                    {
                                        if (itema.getName() == username)
                                        {
                                            Console.WriteLine(itemax.ToString());
                                            complete = true;
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                    if (complete)
                                    {
                                        complete = false;
                                        break;
                                    }


                                    ShowErrorMessage(lang, 1, "The User don't exists", "Ten Użytkownik nie istnieje", true, true);
                                    break;
                                #endregion
                                case "crediter":
                                    #region Crediter check
                                    string creditername;
                                    int alltopayc = 0;

                                    ChooseLanguage(lang, "Accounts:", "Konta:", true, true, true);
                                    foreach (Account itemx in acco)
                                    {
                                        if (itemx.getCredit() == true)
                                        {
                                            ChooseLanguage(lang, itemx.getName() + ", ", itemx.getName() + ", ", false, false, false);
                                            complete = true;
                                        }
                                    }
                                    if (complete == true)
                                        complete = false;
                                    else
                                    {
                                        complete = false;
                                        ShowErrorMessage(lang, 1, "Crediter not found", "Nie znaleziono dłużnika", true, true);
                                        break;
                                    }
                                    ChooseLanguage(lang, "", "", false, true, true);
                                    ChooseLanguage(lang, "Write account name", "Podaj nazwe konta", false, true, true);
                                    ChooseLanguage(lang, "Admin " + itema.getName() + " >> ", "Admin " + itema.getName() + " >> ", false, false, false);
                                    creditername = Console.ReadLine();


                                    foreach (Account itemax in acco)
                                    {
                                        if (itemax.getName() == creditername)
                                        {
                                            if (itemax.getCredit())
                                            {
                                                alltopayc = Convert.ToInt32(Math.Round((itemax.getHowMuchToPay() * TAKE_BANK_PROC_FROM_CREDIT) + itemax.getHowMuchToPay()));
                                                ChooseLanguage(lang, itemax.ToString(), itemax.ToString(), true, false, false);
                                                ChooseLanguage(lang, " -> " + itemax.getHowMuchToPay() + " + " + (TAKE_BANK_PROC_FROM_CREDIT * 100) + "% = " + alltopayc + "$", " - " + itemax.getHowMuchToPay() + " + " + (TAKE_BANK_PROC_FROM_CREDIT * 100) + "% = " + alltopayc + "$", false, false, true);
                                                ChooseLanguage(lang, "Together to pay " + alltopayc, "Razem do zapłaty " + alltopayc + "$", false, true, true);
                                                complete = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (complete)
                                    {
                                        complete = false;
                                        break;
                                    }

                                    ShowErrorMessage(lang, 1, "Crediter not found", "Nie znaleziono dłużnika", true, true);
                                    break;
                                #endregion
                                case "logout":
                                case "exit":
                                    ChooseLanguage(lang, "|Login out| Goodbye " + itema.getName() + " come back quickly!", "|Wylogowanie| Do widzenia " + itema.getName() + " wracaj szybko!", true, true, true);
                                    adminlog = false;
                                    readlogin = "";
                                    readpass = "";
                                    if (itema.getActive())
                                        itema.setActive(false);
                                    complete = true;
                                    break;

                                default:
 
                                    Console.Clear();
                                    break;




                            }

                           

                        }


                        #endregion
                        break;
                    case "userlogin":
                        #region Login user

                        if (youis == null)
                        {
                            ShowErrorMessage(lang, 1, "Choose User", "Wybierz Użytkownika", true, true);
                            break;
                        }


                        ChooseLanguage(lang, "Please write your login and password", "Podaj login i hasło ", true, true, true);

                        ChooseLanguage(lang, "Login: ", "Login: ", false, false, false);
                        readlogin = Console.ReadLine();

                        ChooseLanguage(lang, "Password: ", "Hasło: ", false, false, false);
                        readpass = Console.ReadLine();


                        foreach (Admin use in a)
                        {
                            if (use.getName() == readlogin)
                            {
                                if (use.getPassword() == readpass)
                                {
                                    
                                        ShowErrorMessage(lang, 2, "Unauthorized access", "Nieautoryzowany dostęp", true, true);

                                        complete = true;
                                        break;
                                  

                                }

                            }

                        }
                        if (complete == true)
                        {
                            complete = false;
                            break;
                        }




                        foreach (Account use in acco)
                        {
                            if (use.getName() == readlogin)
                            {
                                if (use.getPassword() == readpass)
                                {
                                    if (youis.getUserAccount() == null || youis.getUserAccount().getName() != readlogin && youis.getUserAccount().getName() != readpass)
                                    {
                                        ShowErrorMessage(lang, 2, "Unauthorized access", "Nieautoryzowany dostęp", true, true);

                                        complete = true;
                                        break;
                                    }
                                    else
                                        break;

                                }

                            }

                            if (acco.IndexOf(use) == acco.IndexOf(acco.Last()) && complete == false)
                            {
                                ShowErrorMessage(lang, 0, "Login or password are incompatible", "Login lub hasło jest nieprawidłowe", true, true);
                                complete = true;
                                break;
                            }
                        }
                        if (complete == true)
                        {
                            complete = false;
                            break;
                        }




                        if (youis.getUserAccount().getName() == readlogin)
                        {
                            if (youis.getUserAccount().getPassword() == readpass)
                            {
                                youis.getUserAccount().setLanguage(lang);
                                if (youis.getUserAccount().accountIsBanned() == true)
                                {
                                    ShowErrorMessage(lang, 4, "Your account is banned", "Twoje konto jest zablokowane", true, false);
                                    ShowErrorMessage(lang, 4, "Reason: " + youis.getUserAccount().getBanReason(), "Powód: " + youis.getUserAccount().getBanReason(), false, true);
                                    break;
                                }

                                if (!youis.getUserAccount().getActive())
                                    youis.getUserAccount().setActive(true);

                                userlog = true;
                                Console.Clear();
                                ChooseLanguage(lang, "Hello " + youis.getUserAccount().getName() + " at the StudiaBank!", "Witaj " + youis.getUserAccount().getName() + " w StudiaBank!", false, false, true);

                                while (userlog)
                                {
                                    ChooseLanguage(lang, "What you want to do? ", "Co chcesz zrobić?", false, true, true);
                                    ShowUserCommand();
                                    ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);
                                    odp = Console.ReadLine();

                                    switch (odp.ToLower())
                                    {
                                        case "payin":
                                            #region Pay in
                                            int payvalue;
                                            ChooseLanguage(lang, "How much do you want to pay? ", "Ile chcesz wpłacić?", true, false, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);

                                            try
                                            {
                                                payvalue = Convert.ToInt32(Console.ReadLine());
                                            }
                                            catch (Exception)
                                            {
                                                ShowErrorMessage(lang, 2, "The amount must be a number!", "Kwota musi być liczbą!", true, true);
                                                break;
                                            }



                                            if (youis.getMoney() >= payvalue)
                                            {

                                                youis.getUserAccount().setAccountHistoryMoney(payvalue);
                                                youis.setMoney(youis.getMoney() - payvalue);
                                                youis.getUserAccount().setAccountBalance(youis.getUserAccount().getAccountBalance() + payvalue);
                                                ChooseLanguage(lang, "You have " + youis.getMoney() + "$", "Masz przy sobie " + youis.getMoney() + "$", true, false, true);

                                                ChooseLanguage(lang, "Paid into the account " + payvalue + "$", "Wpłacono na konto " + payvalue + "$", false, false, true);
                                                ChooseLanguage(lang, "There is " + youis.getUserAccount().getAccountBalance() + "$ in the account", "Na koncie jest " + youis.getUserAccount().getAccountBalance() + "$", false, true, true);


                                                youis.getUserAccount().setAccountHistory(data + " - " + "Paid into the account " + payvalue + "$");

                                            }
                                            else
                                            {

                                                youis.getUserAccount().setAccountHistoryMoney(youis.getMoney());
                                                youis.getUserAccount().setAccountBalance(youis.getUserAccount().getAccountBalance() + youis.getMoney());
                                                payvalue = youis.getMoney();
                                                youis.setMoney(0);
                                                ChooseLanguage(lang, "You have " + youis.getMoney() + "$", "Masz przy sobie " + youis.getMoney() + "$", true, false, true);

                                                ChooseLanguage(lang, "Paid into the account " + payvalue + "$", "Wpłacono na konto " + payvalue + "$", false, false, true);

                                                ChooseLanguage(lang, "There is " + youis.getUserAccount().getAccountBalance() + "$ in the account", "Na koncie jest " + youis.getUserAccount().getAccountBalance() + "$", false, true, true);
                                                youis.getUserAccount().setAccountHistory(data  + " - " + "Paid into the account " + youis.getMoney() + "$");

                                                break;
                                            }




                                            break;
                                        #endregion
                                        case "payout":
                                            #region Pay out
                                            int payoutvalue;
                                            ChooseLanguage(lang, "How much do you want to pay out? ", "Ile chcesz wypłacić?", true, false, true);
                                            ChooseLanguage(lang, "User " + youis.getName() + " >> ", "Użytkownik " + youis.getName() + " >> ", false, false, false);
                                            try
                                            {
                                                payoutvalue = Convert.ToInt32(Console.ReadLine());
                                            }
                                            catch (Exception)
                                            {
                                                ShowErrorMessage(lang, 2, "The amount must be a number!", "Kwota musi być liczbą!", true, true);
                                                break;
                                            }



                                            if (youis.getUserAccount().getAccountBalance() >= payoutvalue)
                                            {
                                                youis.getUserAccount().setAccountHistoryMoney(-payoutvalue);
                                                youis.getUserAccount().setAccountBalance(youis.getUserAccount().getAccountBalance() - payoutvalue);
                                                youis.setMoney(youis.getMoney() + payoutvalue);
                                                ChooseLanguage(lang, "You have " + youis.getMoney() + "$", "Masz przy sobie " + youis.getMoney() + "$", true, false, true);

                                                ChooseLanguage(lang, "Paid out into the account " + payoutvalue + "$", "Wypłacono z konta " + payoutvalue + "$", false, false, true);
                                                ChooseLanguage(lang, "There is " + youis.getUserAccount().getAccountBalance() + "$ in the account", "Na koncie jest " + youis.getUserAccount().getAccountBalance() + "$", false, true, true);

                                                youis.getUserAccount().setAccountHistory(data + " - " + "Paid out into the account " + payoutvalue + "$");
                                                break;
                                            }
                                            else
                                            {

                                                youis.getUserAccount().setAccountHistoryMoney(-youis.getUserAccount().getAccountBalance());
                                                youis.setMoney(youis.getMoney() + youis.getUserAccount().getAccountBalance());
                                                payoutvalue = youis.getUserAccount().getAccountBalance();
                                                youis.getUserAccount().setAccountBalance(0);
                                                ChooseLanguage(lang, "You have " + youis.getMoney() + "$", "Masz przy sobie " + youis.getMoney() + "$", false, false, true);
                                                ChooseLanguage(lang, "Paid out into the account " + payoutvalue + "$", "Wypłacono z konta " + payoutvalue + "$", false, false, true);
                                                ChooseLanguage(lang, "There is " + youis.getUserAccount().getAccountBalance() + "$ in the account", "Na koncie jest " + youis.getUserAccount().getAccountBalance() + "$", false, true, true);


                                                youis.getUserAccount().setAccountHistory(data + " - " + "Paid out into the account " + youis.getUserAccount().getAccountBalance() + "$");
                                                break;
                                            }




                                        #endregion
                                        case "checkhistory":
                                            #region Check history

                                            Console.Clear();


                                            foreach (string itemstr in youis.getUserAccount().getAccountHistory())
                                            {

                                                Console.WriteLine(itemstr);

                                            }
                                            Console.WriteLine();
                                            break;
                                        #endregion
                                        case "paymentsum":
                                            #region Check history money
                                            int result = 0;
                                            Console.Clear();

                                            foreach (string itemstr in youis.getUserAccount().getAccountHistory())
                                            {

                                                Console.WriteLine(itemstr);

                                            }
                                            foreach (int itemstr in youis.getUserAccount().getAccountHistoryMoney())
                                            {

                                                result = result + itemstr;
                                            }
                                            Console.WriteLine();

                                            ChooseLanguage(lang, "Your payment summary is " + result, "Twoja suma płatności wynosi " + result, false, true, true);
                                            Console.WriteLine();
                                            break;
                                        #endregion
                                        case "takecredit":
                                            #region Take creidt
                                            int credittvalue;

                                            if (youis.getUserAccount().getCredit() == true)
                                            {
                                                ShowErrorMessage(lang, 1, "You already have a loan in the amount of " + youis.getUserAccount().getHowMuchToPay() + "$", "Masz juz kredyt w wysokości " + youis.getUserAccount().getHowMuchToPay() + "$", true, true);

                                            }

                                            ChooseLanguage(lang, "How much do you want to take?", "Jak dużo chcesz wziąć?", true, false, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);
                                            try
                                            {
                                                credittvalue = Convert.ToInt32(Console.ReadLine());
                                            }
                                            catch (Exception)
                                            {
                                                ShowErrorMessage(lang, 2, "The amount must be a number!", "Kwota musi być liczbą!", true, true);
                                                break;
                                            }





                                            youis.getUserAccount().takecredit(youis, credittvalue);



                                            ChooseLanguage(lang, "You took out a loan in the amount of " + credittvalue + "$", "Wziąłes kredyt w wysokości " + credittvalue + "$", true, true, true);
                                            youis.getUserAccount().setAccountHistory(data + " - " + "You took out a loan in the amount of " + credittvalue + "$");
                                            youis.getUserAccount().setAccountHistoryMoney(credittvalue);




                                            break;
                                        #endregion
                                        case "payoffcredit":
                                            #region Pay Off Credit
                                            int alltopay = 0;
                                            string odppay;

                                            if (youis.getUserAccount().getCredit() == false)
                                            {
                                                ShowErrorMessage(lang, 2, "You have not credit", "Nie masz kredytu", true, true);
                                                break;
                                            }
                                            if (youis.getUserAccount().getAccountBalance() < alltopay)
                                            {
                                                ShowErrorMessage(lang, 2, "Lack of account funds", "Brak funduszy na koncie", true, true);
                                            }


                                            alltopay = Convert.ToInt32(Math.Round(alltopay + (youis.getUserAccount().getHowMuchToPay() * TAKE_BANK_PROC_FROM_CREDIT) + youis.getUserAccount().getHowMuchToPay()));
                                            ChooseLanguage(lang, "Together to pay " + alltopay + " do you continue? (yes/no)", "Razem do zapłaty " + alltopay + " chcesz kontynuwać? (yes/no)", true, false, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);
                                            odppay = Console.ReadLine();
                                            if (odppay.ToLower() == "yes")
                                            {



                                                youis.getUserAccount().payoffcredit(youis, alltopay);
                                                accountBankBalance = accountBankBalance + alltopay;
                                                ChooseLanguage(lang, "You pay off credit in the amount of " + alltopay + "$", "Spłaciłes kredyt w kwocie " + alltopay + "$", true, true, true);
                                                youis.getUserAccount().setAccountHistory(data +  " - " + "You pay off credit in the amount of " + alltopay + "$");
                                                youis.getUserAccount().setAccountHistoryMoney(-alltopay);
                                                break;

                                            }



                                            break;
                                        #endregion
                                        case "transfer":
                                            #region Transfer
                                            int transfervalue = 0, procforbank = 0, alltransfv = 0;
                                            string nameacc;
                                            Account uitemx = null;
                                            ChooseLanguage(lang, "Your Account balance: " + youis.getUserAccount().getAccountBalance(), "Na koncie posiadasz: " + youis.getUserAccount().getAccountBalance(), true, true, true);


                                            ChooseLanguage(lang, "Accounts:", "Konta:", false, true, true);
                                            foreach (Account itemx in acco)
                                            {
                                                if (youis.getUserAccount() != itemx)
                                                    ChooseLanguage(lang, itemx.getName() + ", ", itemx.getName() + ", ", false, false, false);

                                            }
                                            ChooseLanguage(lang, "", "", false, true, true);
                                            ChooseLanguage(lang, "Write account name", "Wprowadź nazwe konta", false, false, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);
                                            nameacc = Console.ReadLine();




                                            foreach (Account uitem in acco)
                                            {
                                                if (uitem.getName() == nameacc)
                                                {

                                                    uitemx = uitem;
                                                    ChooseLanguage(lang, "Account found", "Konto znaleziono", true, true, true);
                                                    complete = true;
                                                    break;
                                                }
                                            }
                                            if (complete == true)
                                                complete = false;
                                            else
                                            {

                                                ShowErrorMessage(lang, 2, "Account not found", "Nie znaleziono konta", true, true);
                                                complete = true;
                                                break;
                                            }


                                            ChooseLanguage(lang, "How much do you want to transfer?", "Jak dużo chcesz przelać?", false, false, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);


                                            try
                                            {
                                                transfervalue = Convert.ToInt32(Console.ReadLine());
                                            }
                                            catch (Exception)
                                            {
                                                ShowErrorMessage(lang, 2, "Transfer must be number!", "Transfer musi być kwotą", true, true);
                                                break;
                                            }




                                            ChooseLanguage(lang, "Transfer to " + nameacc + " amount " + transfervalue + "$", "Transfer do " + nameacc + " w kwocie " + transfervalue + "$", true, false, true);

                                            procforbank = Convert.ToInt32(Math.Round(transfervalue * TAKE_BANK_PROC_FROM_TANSFER));
                                            alltransfv = transfervalue + procforbank;
                                            ChooseLanguage(lang, "Together to pay " + alltransfv + "$", "Razem do zapłaty " + alltransfv + "$", false, false, true);
                                            ChooseLanguage(lang, "Do you want to continue? (yes/no)", "Chcesz kontynuwać? (yes/no)", false, true, true);
                                            ChooseLanguage(lang, "User " + youis.getUserAccount().getName() + " >> ", "Użytkownik " + youis.getUserAccount().getName() + " >> ", false, false, false);

                                            nameacc = Console.ReadLine();

                                            if (nameacc.ToLower() == "yes" && youis.getUserAccount().getAccountBalance() < alltransfv)
                                            {
                                                ShowErrorMessage(lang, 1, "You don't have that much on your account", "Nie masz tyle na koncie", true, true);
                                                break;

                                            }


                                            if (nameacc.ToLower() == "yes")
                                            {


                                                ChooseLanguage(lang, "Transfer to " + uitemx.getName() + " amount " + transfervalue + "$", "Transfer do " + uitemx.getName() + " w kwocie " + transfervalue + "$", true, true, true);

                                                uitemx.setAccountBalance(uitemx.getAccountBalance() + transfervalue);
                                                uitemx.setAccountHistoryMoney(transfervalue);
                                                uitemx.setAccountHistory(data +  "Transfer from account " + youis.getUserAccount().getName() + " amount " + transfervalue + "$");
                                                accountBankBalance = accountBankBalance + procforbank;
                                                youis.getUserAccount().setAccountBalance(youis.getUserAccount().getAccountBalance() - alltransfv);
                                                youis.getUserAccount().setAccountHistory(data + " - " + "Transfer to " + uitemx.getName() + " amount " + transfervalue + "$");
                                                youis.getUserAccount().setAccountHistoryMoney(-alltransfv);



                                            }


                                            break;
                                        #endregion
                                        case "logout":
                                        case "exit":
                                            readlogin = "";
                                            readpass = "";
                                            if (youis.getUserAccount().getActive())
                                                youis.getUserAccount().setActive(false);
                                          
                                            ChooseLanguage(lang, "|Login out| Goodbye " + youis.getUserAccount().getName() + " come back quickly!", "|Wylogowanie| Do widzenia " + youis.getUserAccount().getName() + " wracaj szybko!", true, true, true);
                                            userlog = false;
                                            break;
                                        default:
                                            Console.Clear();
                                            break;
                                    }

                                }
                            }

                        }






                        #endregion
                        break;
                    case "exit":
                        #region Exit
                        datatimer.AutoReset = false;
                        datatimer.Enabled = false;
                        datatimer.Stop();
                        datatimer.Dispose();
                        isProgramRun = false;
                        #endregion
                        break;
                    default:
                        Console.Clear();
                        break;

                }





            }

        }
    }
}

