using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingApp
{
    class OctoPoney : IAmazingAnimals
    {
        string _name;

        public OctoPoney(string name)
        {
            _name = name;
        }

        public override Types getAnimal()
        {
            return Types.ShiningPoney;
        }

        public override string says()
        {
            return "Hello i'm a Shining Poney";
        }
    }
}
