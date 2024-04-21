using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    internal class Elephant : Animal
    {
        public Elephant(int avgLifeTime, Gender gender, string Breed, int HP) : base(avgLifeTime, gender, Breed, HP)
        {
        }

        private double _weigth;

        public double Weight
        {
            get { return _weigth; }
            set { _weigth = value; }
        }
        private bool _isTrained;

        public bool IsTrained
        {
            get { return _isTrained; }
            set { _isTrained = value; }
        }


    }
}
