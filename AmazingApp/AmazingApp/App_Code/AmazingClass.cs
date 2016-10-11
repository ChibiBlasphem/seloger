using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingApp
{
    abstract class IAmazingAnimals
    {
        public enum Types
        {
            Cat, Dog, ShiningPoney
        }

        abstract public Types getAnimal();
        abstract public string says();
    }
}
