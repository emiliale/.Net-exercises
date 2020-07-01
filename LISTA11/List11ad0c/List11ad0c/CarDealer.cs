using System;
using System.Collections.Generic;
using System.Text;

namespace List11ad0c
{
    class CarDealer
    {

        private  string name;


        public CarDealer(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        // reprezentuje metodę, która obsłuży zdarzenie 'NewCarInfo'
        // zdarzenie dostarcza dane
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void RaiseNewCarInfo(string car)
        {
            Console.WriteLine("\n{0}, nowe auto: {1}, czas: {2}", getName(), car, DateTime.Now);
            // emituj zdarzenie, gdy ktoś czeka! 
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
        }

    }
}
