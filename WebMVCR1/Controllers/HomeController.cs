using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
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
            //string res = ExeFactorial(5);
            //string res = ExeTriangle();
            //string res = ExeCircle();
            //string res = ExePolim();
            string res = ExeCollection();
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

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }

        public string ExeCircle() 
        { 
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна: {1:0.##}", cir1.Name, cir1.Area);
            return sq;
        }
        StringBuilder str = new StringBuilder();
        Shape[] sh = {
            new Triangle(1, 2, 3),
            new Circle(5),
            new Triangle(5, 6, 8) };

        public string ExePolim()
        {
            
            foreach (Shape item in sh)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>");
            }
            return str.ToString();
        }
        public string ExeCollection()
        {
            //List<Circle> cirs = new List<Circle>
            //{
            //    new Circle(12),
            //    new Circle(5),
            //    new Circle(15),
            //    new Circle(6)
            //};
            //cirs.Add(new Circle(7));
            //cirs.Sort();

            //StringBuilder str = new StringBuilder();
            //foreach (Shape item in cirs)
                List<Triangle> trgl = new List<Triangle>
            {
                new Triangle(12, 3, 2),
                new Triangle(5, 7, 1),
                new Triangle(15, 10, 15),
                new Triangle(6, 6, 6)
            };
            trgl.Add(new Triangle(7, 6, 2));
            trgl.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in trgl)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "<p>"); 
            }
            return str.ToString();
        }
    }
}