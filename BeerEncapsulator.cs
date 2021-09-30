using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BeerEncapsulator
    {
        double _avalaibleBeerVolume;
        int _avalaibleBottles;
        int _avalaibleCapsules;



        public void SetAvalaibleBottles(int avalaibleBottles)
        {
             if (avalaibleBottles >= 0)
            {
                _avalaibleBottles = avalaibleBottles;
            }
        }

        public void SetAvalaibleCapsules(int avalaibleCapsules)
        {
            if (avalaibleCapsules >= 0)
            {
                _avalaibleCapsules = avalaibleCapsules;
            }
        }

        public double AddBeer (double addedBeerVolume)
        
        {
              return  _avalaibleBeerVolume = addedBeerVolume + _avalaibleBeerVolume;
        }


        public int ProduceEncapsulatedBeerBottles(int nombreDeBouteillesARealiser)
        {              
            int completedBottles = 0;
            int remainedBottles = nombreDeBouteillesARealiser;
            int remainedCapsules = nombreDeBouteillesARealiser;
            int remainedBeerVolumme = nombreDeBouteillesARealiser * 33;

            while (_avalaibleBottles > 0 && _avalaibleCapsules > 0 && _avalaibleBeerVolume > 33)
            {
                _avalaibleBottles = _avalaibleBottles - 1;
                _avalaibleCapsules = _avalaibleCapsules - 1;
                _avalaibleBeerVolume = _avalaibleBeerVolume - 33;
                completedBottles = completedBottles + 1;
                remainedBottles = remainedBottles - 1;
                remainedCapsules = remainedCapsules - 1;
                remainedBeerVolumme = remainedBeerVolumme - 33; 

                if (nombreDeBouteillesARealiser == completedBottles)
                {

                    break;
                }

            }

            if (_avalaibleBottles <= 0 || _avalaibleCapsules <= 0 || _avalaibleBeerVolume <= 33)
            {
                Console.WriteLine(" Le nombre de bouteilles complètes souhaitées est supérieur à ce que peut fournir la machine actuellement. Veuillez recharger la machine");
            }
            
            
            if (_avalaibleBottles <= 0)
            {
                  Console.WriteLine("Pour réaliser " + nombreDeBouteillesARealiser + "bouteilles, il faut : " + (remainedBottles) + " bouteilles en plus.");
            }

            if (_avalaibleCapsules <= 0)
            {
                 Console.WriteLine("Pour réaliser " + nombreDeBouteillesARealiser + "bouteilles, il faut : " + (remainedCapsules) + " capsules en plus. ");
            }

            if (_avalaibleBeerVolume <= 33)
            {
                 Console.WriteLine("Pour réaliser " + nombreDeBouteillesARealiser + "bouteilles, il faut : " + (remainedBeerVolumme) + " cL en plus");
            }
            
                   
            Console.WriteLine("Le nombre de bouteilles complétées est : " + completedBottles);

            return completedBottles;

     
        }
    }
}


/
