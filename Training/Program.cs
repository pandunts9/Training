using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        public static void Main(string[] args)
        {
            _List _list = new _List();
            _list.Add(14);
            _list.Add(18);
            _list.Add(74);
            _list.Add(17);
            _list.Add(177);
            _list[4] = 588;
            //Console.WriteLine(_list[4]);
            foreach (var item in _list)
            {
                Console.WriteLine(item) ;
            }

            _ListOfWeakDays _days = new _ListOfWeakDays();
            Console.WriteLine("Write the weak day name to see the appropriate number!");
            string day = Console.ReadLine();
            Console.WriteLine( $"{day} is number {_days[day]}. ");
          
            foreach (string item in _days)
            {
                Console.WriteLine(item);
            }
        }
    }         
}