using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateHomeWork
{
  
    public class IDisplay
    {
        public void Show(int a, int _buffer, int _weight) {

            Console.Clear();

            if (_buffer >= _weight)
            {
                _buffer = _weight;

            }

            Console.WriteLine("Скорость-");
            Console.WriteLine(a);
            Console.WriteLine("Скачано-");
            Console.WriteLine(_buffer);
            Console.WriteLine("Вес файла-");
            Console.WriteLine(_weight);
            Console.WriteLine(" ");

        }
    }
}
