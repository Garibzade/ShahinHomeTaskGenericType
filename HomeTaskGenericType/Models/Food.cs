using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    abstract class Food
    {
        protected Food(int calorie)
        {
              _calorie = calorie;
        }
        private int _calorie;

		public int Calorie
        {
			get { return _calorie; }
			set { _calorie = value; }
		}

	}
}
