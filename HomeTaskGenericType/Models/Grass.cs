using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    internal class Grass : Food
    {
        public Grass(int calorie,string name) : base(calorie)
        {
            _name = name;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
