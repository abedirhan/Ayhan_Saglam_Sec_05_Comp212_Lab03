using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ayhan SAGLAM 
 301059969
 Section_05
 Lab 03 Exercise 2*/
namespace Ayhan_Saglam_Exercise_02
{
    public class Invoice
    {
        //private fields
        private int _partNumber;
        private string _partDescription;
        private int _quantity;
        private Double _price;

        //Properties      
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string PartDescription { get => _partDescription; set => _partDescription = value; }
        public int PartNumber { get => _partNumber; set => _partNumber = value; }

        //Takes zero arguments
        public Invoice()
        {

        }
        // Constructor 
        public Invoice(int partNumber, string partDescription, int quantity, double price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PartNumber,3} {PartDescription,30} {Quantity,10} {Price,10:c}";
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            // Created list object and added items to list
            //  List<Invoice> invoice = new List<Invoice>{
            //Created array and added items to array
            var invoices = new[] {
                new Invoice(partNumber:87,partDescription:"Electric Sander",quantity:7,price:57.98),
                new Invoice(partNumber:24,partDescription:"Power Saw",quantity:18,price:99.99),
                new Invoice(partNumber:7,partDescription:"Sledge Hammer",quantity:11,price:21.50),
                new Invoice(partNumber:77,partDescription:"Hammer",quantity:76,price:11.99),
                new Invoice(partNumber:39,partDescription:"Lawn Mower",quantity:3,price:79.50),
                new Invoice(partNumber:68,partDescription:"Screw Driver",quantity:106,price:6.99),
                new Invoice(partNumber:56,partDescription:"Jig Saw",quantity:21,price:11.00),

        };
            Console.WriteLine("Part Numeber        Part Descroption  Quantity     Price");
            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in invoices)
            {
                Console.WriteLine($"{item}");

            }
            Console.WriteLine("--------------------------------------------------------");

            //a) Solution

            Console.WriteLine("\nItems Value Calculation");
            var values =
                 from e in invoices
                 let invoiceValue = e.Price * e.Quantity
                 orderby invoiceValue ascending
                 select $"{e.PartDescription,16} {e.Quantity,5} {e.Price,8} {e.Price * e.Quantity,10}";
            Console.WriteLine("Part Descrition   Quantity  Price     Value");
            Console.WriteLine("-------------------------------------------");
            foreach (var a in values)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();



            //b) Solution
            //Find highest item quantity
            var highest = invoices.Max(x => (x.Quantity));
            
            // Find Which item has highest inventory quantity
            var itemDes =
                from s in invoices
                where s.Quantity == highest
                select s.PartDescription;
            foreach (var item in itemDes)
            {
                Console.Write($"Maximum item is {item}");
            }
            Console.Write($" and quantity: {highest}");

            //c) Average of parts

            var average = invoices.Average(x => x.Price);
            Console.Write($" \nAverage price of parts: {average:f2}\n");

        }
    }
}
