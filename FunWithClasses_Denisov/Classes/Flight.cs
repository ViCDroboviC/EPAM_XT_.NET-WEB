using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class  Flight <T>
        //TODO настроить ограничения, чтобы убрать лишние поля в классе Airplane
        where T : Airplane
    {
        int flightTotalPayload;
        int flightTotalPylonsNumber;
        public Flight (T Airplane1, T Airplane2)
        {
            flightTotalPayload = Airplane1.payload + Airplane2.payload;
            flightTotalPylonsNumber = Airplane1.pylonsNumber + Airplane2.pylonsNumber;
        }
    }
}
