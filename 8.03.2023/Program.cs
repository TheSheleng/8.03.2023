using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._03._2023
{
    internal class Program
    {
        class Gadget : IEquatable<Gadget>
        { 
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public int Price { get; set; }
            public bool Equals(Gadget other)
            {
                if (other is null)
                    return false;
                return this.Name == other.Name && 
                    Manufacturer == other.Manufacturer &&
                    Price == other.Price;
            }
            public override bool Equals(object obj) => Equals(obj as Gadget);
            public override int GetHashCode() => (Name, Manufacturer, Price).GetHashCode();
        }
        static void Main(string[] args)
        {
            var list_1 = new List<Gadget>() {
                new Gadget() { Name = "Redmi Note 11", Manufacturer = "Xiaomi", Price = 8599 },
                new Gadget() { Name = "Redmi 10C", Manufacturer = "Xiaomi", Price = 5799 },
                new Gadget() { Name = "iPhone 13 Pro", Manufacturer = "Apple", Price = 47799 },
                new Gadget() { Name = "Ace 10 Pro", Manufacturer = "One Plus", Price = 26500 },
                new Gadget() { Name = "Pixel 6", Manufacturer = "Google", Price = 22899 },
            };

            var list_2 = new List<Gadget>() {
                new Gadget() { Name = "Redmi Note 11", Manufacturer = "Xiaomi", Price = 8599 },
                new Gadget() { Name = "Poco F4", Manufacturer = "Xiaomi", Price = 15999 },
                new Gadget() { Name = "Galaxy S21 FE", Manufacturer = "Samsung", Price = 47799 },
                new Gadget() { Name = "Ace 10 Pro", Manufacturer = "One Plus", Price = 26500 },
            };

            foreach (Gadget gadget in list_1.Except(list_2))
            {
                Console.WriteLine($"Name: {gadget.Name};\t\t" +
                    $"Manufacturer: {gadget.Manufacturer};\t\t" +
                    $"Price: {gadget.Price};");
            }
            Console.WriteLine();

            foreach (Gadget gadget in list_1.Intersect(list_2))
            {
                Console.WriteLine($"Name: {gadget.Name};\t\t" +
                    $"Manufacturer: {gadget.Manufacturer};\t\t" +
                    $"Price: {gadget.Price};");
            }
            Console.WriteLine();

            foreach (Gadget gadget in list_1.Union(list_2))
            {
                Console.WriteLine($"Name: {gadget.Name};\t\t" +
                    $"Manufacturer: {gadget.Manufacturer};\t\t" +
                    $"Price: {gadget.Price};");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
