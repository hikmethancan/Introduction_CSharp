using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructors
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }

        //Constructor Tanımı :
        // Constructor metotlar içinde bulunduğu Classın ismini alır.
        //İçinde bulunduğu Classın propertylerini bu Constructor Metodlarına atayabiliriz ve varsayılan olarak bu Class Instance alındığında default olarak bu metoddaki değerler de atanır.

        // Parametre alan Constructor Yapısı
        public Car(string brand, string model , int engine)
        {
            this.Brand = brand;
            this.Model = model;
            this.Engine = engine;
        }

        // Parametresiz Defaul Constructor Yapısı
        public Car()
        {
            Brand = "Ford";
        }
    }
}
