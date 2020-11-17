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

        public bool Reserver(int nbPlaces)
        {
            NbPlacesOccupees = nbPlaces;
            return true;
        }

    }
}