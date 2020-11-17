namespace TrainTrain.Domain.Tests.Contexts
{
    public class ReservationContext
    {
        public int TotalPlaces { get; set; }
        public int OccupiedPlaces { get; set; }
        public int PlacesToReserve { get; set; }

        public bool ReservationFaite { get; set; }
    }
}