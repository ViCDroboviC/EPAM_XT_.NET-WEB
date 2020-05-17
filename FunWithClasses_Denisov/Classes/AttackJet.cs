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
        
        public AttackJet(string _manufacturer, string _model, int _engineThrust, int _payload, int _pylonsNumber) :base(_manufacturer, _model, _engineThrust,  _payload,  _pylonsNumber)
        {         
        }
        //public static AttackJet operator +(AttackJet attackJet1, AttackJet attackJet2,)
        {

        }
    }
}
