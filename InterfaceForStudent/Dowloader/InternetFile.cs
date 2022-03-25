using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventAndDelegateHomeWork.InterfaceForStudent
{
    /// <summary>
    /// Должен содержать в поле: Название, размер файла
    /// </summary>
    public class InternetFile : IDowloader
    {
        public delegate void Message(int a, int Buffer, int Weight);
        public event Message MessageEvent;

        private int _buffer = 0;
        private int _weight = 500;
        private string _name = "'Amongus'";
        Random rand = new Random();

        public string Name { get => _name; set => _name = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Buffer { get => _buffer; set => _buffer = value; }

        public void Complete(int n)
        {
            if (n == Weight)
            {
                Console.WriteLine("-Загрузка файла завершена-");
            }
        }

        public void Start()
        {
            for ( int i = 0; _buffer < _weight; i++)
            {
                Thread.Sleep(1000);
                int a = rand.Next(100);
                _buffer = _buffer + a;
                Error(a);
                Complete(_buffer);

                

                MessageEvent.Invoke(a, Buffer, Weight);


            }

}
        public void Error(int speed)
        {
            if (speed < 5)
            {   
                speed = 0;
                Console.WriteLine("-Плохое интернет соединение-");
                
            }
        }
        
    }
}
    
