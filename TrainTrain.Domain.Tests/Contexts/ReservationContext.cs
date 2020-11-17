namespace TrainTrain.Domain.Tests.Contexts
{
    public class ReservationContext
    {
        public Wagon Wagon { get; set; }
        
        public int PlacesToReserve { get; set; }
        public bool ReservationFaite { get; set; }
    }
}