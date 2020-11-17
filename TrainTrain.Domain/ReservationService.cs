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
        public int NbPlacesOccupées { get; private set; } = 0;

        public bool Réserver(int nbPlaces)
        {
            return true;
        }

    }
}