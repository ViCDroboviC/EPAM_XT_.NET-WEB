using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class FighterJet : Airplane
    {
        public int seatsNumber;
        public FighterJet(string _manufacturer, string _model, int _engineThrust) : base(_manufacturer, _model, _engineThrust)
        {
        }
    }
}
