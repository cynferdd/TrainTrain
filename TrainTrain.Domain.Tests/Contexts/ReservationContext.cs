using System.Collections.Generic;
using System.Linq;

namespace TrainTrain.Domain.Tests.Contexts
{
    public class ReservationContext
    {
        public Train CreerTrain() => new Train(this.Wagons.ToList());
        public IList<Wagon> Wagons { get; set; } = new List<Wagon>();
        public bool ReservationFaite { get; set; }
        public decimal MontantActuel { get; set; }
        public IReadOnlyCollection<Voyageur> Voyageurs { get; set; }
    }
}