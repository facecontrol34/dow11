using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace andrewq
{
    class Program
    {
        delegate string GetNextDayOfWeek();

        static void Main()
        {

            int currentDayIndex = (int)DateTime.Today.DayOfWeek;
            if (currentDayIndex != 1) currentDayIndex -= 1;

            GetNextDayOfWeek getNextDay = () =>
            {
                currentDayIndex = (currentDayIndex + 1);
                switch (currentDayIndex)
                {
                    case 1:
                        return "Понедельник";
                    case 2:
                        return "Вторник";
                    case 3:
                        return "Среда";
                    case 4:
                        return "Четверг";
                    case 5:
                        return "Пятница";
                    case 6:
                        return "Суббота";
                    case 7:
                        return "Воскресенье";
                    default:
                        currentDayIndex = 1;
                        return "Понедельник";
                }

            };

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(getNextDay());
            }
        }
    }
}
