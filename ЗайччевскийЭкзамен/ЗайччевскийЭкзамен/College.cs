using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDll
{
    //Класс колледж в котором будет находиться названия колледжа,адресс
    public class College
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public College(string nm, string ad) 
        {
            Name = nm;
            Address = ad;
        }
        public void ShowAll() 
        {
            Console.WriteLine($"Название колледжа:{Name},Адресс колледжа:{Address}");
        }
    }
}
