using System;

namespace TrainTrain.Domain
{
    public class Wagon
    {
        public Wagon(int nbPlaces)
        {
            NbPlaces = nbPlaces;
        }

        public int NbPlaces { get; }
        public int NbPlacesOccupees { get; private set; } = 0;

        public void Reserver(int nbPlaces)
        {
            if (NbPlaces < nbPlaces + NbPlacesOccupees)
                throw new InvalidOperationException("Dépassement de capacité");
            
            NbPlacesOccupees += nbPlaces;
        }

    }
}