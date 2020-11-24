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

        public bool Reserver(int nbPlaces, decimal seuil)
        {
            var wagon =
                Wagons.FirstOrDefault(w =>
                    w.NbPlacesOccupees + nbPlaces < seuil);
            
            if (wagon == null)
                return false;

            wagon.Reserver(nbPlaces);
            return true;
        }
    }
}