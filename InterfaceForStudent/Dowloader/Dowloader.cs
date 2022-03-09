using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateHomeWork.InterfaceForStudent
{

    internal interface IDowloader
    {


        void Start();

        void Complete(int n);

        void Error(int speed);
    }
}

