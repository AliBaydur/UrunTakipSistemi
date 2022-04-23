using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunTakipSistemi
{
    class ComboBoxValue
    {
        public int Id { get; set; }
        public string Name { get; private set; }

        public ComboBoxValue(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
