using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace EventAndDelegateHomeWork.InterfaceForStudent
{
    /// <summary>
    /// Должен содержать в поле: Название, размер файла
    /// </summary>
    public class InternetFile: IDowloader
    {
        private string _name;



        private int _weight;

        Random rand = new Random();



        public string Name { get => _name; set => _name = value; }

        public int Weight { get => _weight; set => _weight = value; }





        public void Complete(int n)

        {

            if (n == Weight)

            {

                Console.WriteLine("-Загрузка файла завершена-");

            }



        }



        public void Error(int speed)

        {

            if (speed < 5)

            {

                Console.WriteLine("-Плохое интернет соединение-");

                speed = 0;

            }

        }



        public void Start()

        {

            Console.WriteLine("-Загрузка началась-");

        }


    }
}