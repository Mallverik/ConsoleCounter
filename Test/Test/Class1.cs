using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Functional
    {
        public event Action<string> TextCheckerEvent;
        int counter = 0;

        public void TextCheck(string UserText)
        {

            for (int i = 0; i < UserText.Length; i++)
            {
                if (UserText[i] == '+')
                {
                    counter++;
                    if (counter % 3 == 0 && counter != 0)
                    {
                        TextCheckerEvent?.Invoke($"{counter} кратне числу 3");
                    }

                }
                else if (UserText[i] == '-')
                {
                    counter--;
                    if (counter % 3 == 0 && counter != 0)
                    {
                        TextCheckerEvent?.Invoke($"{counter} кратне числу 3");
                    }
                }

            }
        }
        public void CounterShow()
        {
            TextCheckerEvent?.Invoke($"Counter = {counter}");
        }

      
    }
       
}

