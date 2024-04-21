using HomeTaskGenericType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeTaskGenericType.Models
{
    internal class Wolf : Animal
    {
        public Wolf(int avgLifeTime, Gender gender, string Breed, int HP) : base(avgLifeTime, gender, Breed, HP)
        {
        }
        private bool _isPrideLeader;

        public bool IsPrideLeader
        {
            get { return _isPrideLeader; }
            set { _isPrideLeader = value; }
        }

        private int _attackdamage;

        public int AttackDamage
        {
            get { return _attackdamage; }
            set { _attackdamage = value; }
        }

        public int Hunt<T>(T animal) where T : Animal 
        {
        return Hp -= AttackDamage;
        }

    }
    }

