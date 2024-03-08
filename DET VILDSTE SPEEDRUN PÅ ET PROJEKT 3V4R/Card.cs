using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET_VILDSTE_SPEEDRUN_PÅ_ET_PROJEKT_3V4R
{
    public class Card
    {
        private string _name;

        public Card(string name)
        {
            _name = name;
        }
        public string Name
        {
            get { return _name; }
        }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
