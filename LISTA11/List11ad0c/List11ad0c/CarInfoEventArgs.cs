using System;
using System.Collections.Generic;
using System.Text;

namespace List11ad0c
{
    class CarInfoEventArgs:EventArgs
    { 
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }

        public string Car { get; private set; }

    }
}
