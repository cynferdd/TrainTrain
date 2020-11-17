namespace TrainTrain.Domain.Tests.Contexts
{
    public class ReservationContext
    {
        public Wagon Wagon { get; set; }
        
        public bool ReservationFaite { get; set; }
        public decimal MontantActuel { get; set; }
    }
}