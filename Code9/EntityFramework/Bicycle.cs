using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class Bicycle
    {
        public Bicycle()
        {
        }

        public virtual int BicycleId { get; set; }
        public virtual string Manufacturer { get; set; }
        public virtual int Year { get; set; }
    }
}
