using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

   

    class Program
    {
        
        static void Main(string[] args)
        {
            bool TaskIsRunning = true;
            string UserText;
            Functional functional = new Functional();
            Console.WriteLine("Enter exit to close program\n");
            Console.WriteLine("Enter your text: ");
            functional.TextCheckerEvent += ShowMessage;

            while (TaskIsRunning)
            {
                UserText = Console.ReadLine();
                if (UserText == "exit")
                {
                    TaskIsRunning = false;
                    break;
                }
                functional.TextCheck(UserText);
                functional.CounterShow();
            }
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
    //Створити консольний додаток який зчитує введений текст з клавіатури, 
    //кожного роазу коли в рядку буде "+", то потрібно щоб counter +1, якщо в рядку буде "-" то зменшувати, 
    //зробити на основі event та додати обробник події(кожен раз коли counter - кратний 3) то виводити про це повідомлення
}

