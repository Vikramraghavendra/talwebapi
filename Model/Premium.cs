using System.ComponentModel.DataAnnotations;

namespace TALWebAPI.Model
{
    public class Premium
    {
        [Range(1, Int32.MaxValue)]
        public int SumInsured { get; set; }
        [Range(1, Int32.MaxValue)]
        public int OccupationRatingFactor { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
    }
}
