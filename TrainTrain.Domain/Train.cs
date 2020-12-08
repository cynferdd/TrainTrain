using System.Collections.Generic;
using System.Linq;

namespace TrainTrain.Domain
{
    public class Train
    {
        public Train(IReadOnlyList<Wagon> wagons)
        {
            Wagons = wagons;
        }

        public IReadOnlyList<Wagon> Wagons { get; }

        public bool ReserverLeWagonLePlusRempli(int nbPlaces, decimal seuil = 1m)
        {
            var wagon =
                Wagons
                    .Where(w => w.NbPlacesOccupees + nbPlaces < seuil * w.NbPlaces)
                    .OrderByDescending(w => w.NbPlacesOccupees)
                    .FirstOrDefault();
            
            if (wagon == null)
                return false;

            wagon.Reserver(nbPlaces);
            return true;
        }
        
        public bool ReserverLeWagonLeMoinsRempli(int nbPlaces, decimal seuil = 1m)
        {
            var wagon =
                Wagons
                    .Where(w => w.NbPlacesOccupees + nbPlaces < seuil * w.NbPlaces)
                    .OrderBy(w => w.NbPlacesOccupees)
                    .FirstOrDefault();
            
            if (wagon == null)
                return false;

            wagon.Reserver(nbPlaces);
            return true;
        }
    }
}