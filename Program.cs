using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventAndDelegateHomeWork.InterfaceForStudent;

namespace EventAndDelegateHomeWork

{


    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            InternetFile file = new InternetFile();
            file.Weight = 500;
            file.Name = "'Among Us'";
            int n = 0;
            int a, a1;
            a1 = file.Weight;

            Console.WriteLine($"Что бы скачать файл {file.Name}, размер - {file.Weight}, введите 1.");
            string o = Console.ReadLine();
            if (o == "1")
            {

                file.Start();

                for (int i = 0; n < a1; i++)
                {
                    a = rand.Next(100);
                    file.Error(a);
                    Console.WriteLine("-Скорость-");
                    Console.WriteLine(a);
                    n = n + a;
                    if (n> file.Weight)
                    {

                        n = file.Weight;

                    }
                    Console.WriteLine("-Скачано-");
                    Console.WriteLine(n);
                    file.Complete(n);
                }
            }


            else Console.WriteLine("-Загрузка отменена-");

        }

    }

}