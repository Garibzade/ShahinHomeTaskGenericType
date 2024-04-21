using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGenericType.Models
{
    internal class ZooCage<T,U> where T : Animal where U : Food
    {
        public ZooCage(T animal,U food)
        {
				_animal = animal;
			    _food = food;
        }
        private T _animal;
		public T Animal
		{
			get { return _animal; }
			set { _animal = value; }
		}
		private U _food;
		public U Food
		{
			get { return _food; }
			set { _food = value; }
		}
	}
}
