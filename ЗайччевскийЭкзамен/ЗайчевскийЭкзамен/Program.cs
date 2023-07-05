using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDll;


namespace ЗайчевскийЭкзамен
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College("1-Й МОК","Староватутинский пр.");
            college.ShowAll();

            Teacher t1 = new Teacher("Анатолий Тузовский", "Инстр. средства разработки");
            t1.Show();
            Teacher t2 = new Teacher("Екатерина Вейнгерова", "Внедрение ИС");
            t2.Show();
            Teacher t3 = new Teacher("Анатолий Тузовский", "ТРПО");
            t3.Show();
            Console.ReadKey();
        }
    }
}
