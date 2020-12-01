using System;

namespace TrainTrain.Domain
{
    public class Voyage
    {
        public Voyage(Train train, DateTime date)
        {
            Train = train;
            Date = date;
        }

        public Train Train { get; }
        public DateTime Date { get; }
    }
}