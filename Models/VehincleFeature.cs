using System.ComponentModel.DataAnnotations.Schema;

namespace ahmad.Models
{
    [Table("VehincleFeatures")]
    public class VehincleFeature
    {
        public int VehincleId { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public Vehincle Vehincle { get; set; }
    }
}