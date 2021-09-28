using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            BeerEncapsulator beerEncapsulator = new BeerEncapsulator();

            Console.WriteLine(" Saisir le nombre de bouteilles disponibles : ");
            beerEncapsulator.SetAvalaibleBottles(Convert.ToInt32(Console.ReadLine())); 


            Console.WriteLine(" Saisir le nombre de capsules disponibles : ");
            beerEncapsulator.SetAvalaibleCapsules(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine(" Saisir la quantité de bière à ajouter dans la machine (en cL): ");
            beerEncapsulator.AddBeer(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(" Saisir le nombre de bouteilles complètes souahitées  : ");
            beerEncapsulator.ProduceEncapsulatedBeerBottles(Convert.ToInt32(Console.ReadLine()));


            Console.ReadLine(); 

        }
    }
    }






    





    


