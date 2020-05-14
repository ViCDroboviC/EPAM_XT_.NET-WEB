using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class AttackJet : Airplane
    {
        public int emptyWeight;
        public int maxWeight;
        public int payload;
        public AttackJet(string _manufacturer, string _model, int _engineThrust):base(_manufacturer,_model,_engineThrust)
        {         
        }
    }
}
