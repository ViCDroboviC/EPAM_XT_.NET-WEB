using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Airplane
    {
        public string manufacturer { get;  }
        public string model { get; }
        public int engineThrust { get; }
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int payload;
        public int pylonsNumber;

        public Airplane(string _manufacturer, string _model, int _engineThrust, int _payload, int _pylonsNumber)
        {
            manufacturer = _manufacturer;
            model = _model;
            engineThrust = _engineThrust;
            payload = _payload;
            pylonsNumber = _pylonsNumber;
            coordX = 0;
            coordY = 0;

        }
        public void FlyTo (int deltaX, int deltaY)
        {
            coordX = coordX + deltaX;
            coordY = coordY + deltaY;
            Console.WriteLine($"Координаты {model} стали ({coordX},{coordY})");
        }
        
    }
}
