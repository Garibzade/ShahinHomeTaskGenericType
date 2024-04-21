using HomeTaskGenericType.Models;

namespace HomeTaskGenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf shahin = new Wolf(30, Animal.Gender.Male, "Bozgurd", 3000);
            Elephant qerib = new(50,Animal.Gender.Male,"Lokbatan fili",3131);
            Meat et = new(5000,Meat.Type.At);
            Grass ot = new(300,"It burnu");
            var vehsi = new ZooCage<Wolf, Meat>(shahin, et);
            var zeif = new ZooCage<Elephant, Grass>(qerib, ot); 
        }   
    }
}
