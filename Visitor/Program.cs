using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liquer

            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            // Perfume

            Perfume per = new Perfume(500);

            Console.WriteLine(per);

            IVisitor OneIlsVisitor = new OneILSSale();

            Console.WriteLine($"Price after tax = {per.Accept(OneIlsVisitor)}");


            // ShopRent

            ShopRent shop = new ShopRent(5000);

            Console.WriteLine(shop);

            Console.WriteLine($"Price after tax = {shop.Accept(endOfYearVisitor)}");

        }
    }
}