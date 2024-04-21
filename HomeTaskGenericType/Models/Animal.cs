using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    abstract class Animal
    {
        protected Animal(int avgLifeTime,Gender gender, string Breed, int HP)
        {
            _avglifetime = avgLifeTime;
           Genders=gender;
            _breed = Breed;
            _hp = HP;

        }
        private int _avglifetime;

        public int AvgLifeTime
        {
            get { return _avglifetime; }
            set { _avglifetime = value; }
        }

        private string _breed;

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

      public enum Gender
        {
            Male,
            Female,
        }

        private Gender _gender;

        public Gender Genders
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _hp;

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

    }
}
