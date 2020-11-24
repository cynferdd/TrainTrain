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
        
    }
}