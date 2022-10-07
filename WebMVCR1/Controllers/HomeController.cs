using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;
using static System.Web.Razor.Parser.SyntaxConstants;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        //////////////////////////////////////Lab1Ex0/////////////////////////////////
        //GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //////////////////////////////////////Lab1Ex1/////////////////////////////////
        //public string Start()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
        //    return Greeting;
        //}
        //////////////////////////////////////Lab1Ex2/////////////////////////////////
        //public string Start(string hel)
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
        //    return Greeting;
        //}
        //////////////////////////////////////Lab1Ex3/////////////////////////////////
        //public string Index(string hel)
        //{
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //}
        //////////////////////////////////////Lab2Ex1.1/////////////////////////////////
        //public string Index()
        //{
        //    string res = ExeEnum();
        //    return res;
        //}
        //////////////////////////////////////Lab2Ex1.2/////////////////////////////////
        public string Index()
        {
            //string res = ExeStruct();
            //string res = StudyCsharp.SetStatus(3);
            //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));
            //string res = StudyCsharp.GetFunction(0, 9);
            string res = ExeFactorial(5);
            return res;
        }
        public string ExeEnum()
        {
            AccountType goldAccount; AccountType platinumAccount;
            goldAccount = AccountType.Checking; platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);

            string res = res1 + "<p>" + res2;
            return res;
        }
        public string ExeStruct()
        {
            BankAccount goldBankAccount;

            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);
            string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
            return res;
        }
        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);
            if (ok) return String.Format("Факториал числа {0} равен {1} ", x, f);
            else return "Невозможно вычислить факториал";
        }
    }
}