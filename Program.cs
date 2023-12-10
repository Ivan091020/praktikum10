using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1
            Console.Write("Введите номер дня недели (от 1 до 7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            string dayName = GetDayOfWeekName(dayNumber);
            Console.WriteLine($"День недели с номером {dayNumber}: {dayName}");
        }
        static string GetDayOfWeekName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 8: return "Воскресенье";
                default: return "Некорректный номер дня недели ";
            }
            ///Задание 2
            Console.Write("Введите номер месяца (от 1 до 12): ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            string monthName = GetMonthName(monthNumber);

            Console.WriteLine($"Месяц с номером {monthNumber}: {monthName}");
        }

        static string GetMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: return "Некорректный номер месяца";
                    ////Задание3
                    int month = 5;
                    string season;

                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                            season = "Зима";
                            break;
                        case 3:
                        case 4:
                        case 5:
                            season = "Весна";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            season = "Лето";
                            break;
                        case 9:
                        case 10:
                        case 11:
                            season = "Осень";
                            break;
                        default:
                            season = "Некорректный номер месяца";
                            break;
                    }

                    Console.WriteLine($"Месяц {month} соответствует времени года: {season}");
                    ////Задание4
                    char input = 'ф';
                    string subject;

                    switch (input)
                    {
                        case 'ф':
                            subject = "Физика";
                            break;
                        case 'м':
                            subject = "Математика";
                            break;
                        case 'и':
                            subject = "История";
                            break;
                        case 'г':
                            subject = "География";
                            break;
                        case 'б':
                            subject = "Биология";
                            break;
                        default:
                            subject = "Предмет не найден";
                            break;
                    }

                    Console.WriteLine($"По введенной букве {input} предмет: {subject}");

            }
        }
    }
}
