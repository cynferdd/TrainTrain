using System.Collections.Generic;
using System.Linq;

namespace TrainTrain.Domain
{
    public class Train
    {
        private readonly IReadOnlyCollection<Wagon> wagons;

        public Train(IReadOnlyCollection<Wagon> wagons)
        {
            this.wagons = wagons;
        }

        public Wagon GetWagon(int index)
        {
            return 
                (this.wagons != null && this.wagons.Count > 0 && index < this.wagons.Count)
                ? this.wagons.ElementAt(index)
                : null;
        }
        
    }
}