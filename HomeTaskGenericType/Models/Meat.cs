using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    internal class Meat : Food
    {
        public Meat(int calorie,Type type) : base(calorie)
        {
            _type = type;
        }
        public enum Type
        {
            Toyuq,
            Baliq,
            At,
            Inek
        }

        private Type _type;

        public Type MyProperty
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
