using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Customer
    {
        private ICollection<Bicycle> _bicycles;

        public Customer()
        {
        }

        public virtual int CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual ICollection<Bicycle> Bicycles
        {
            get
            {
                return _bicycles ?? (_bicycles = new HashSet<Bicycle>());
            }
            protected set
            {
                _bicycles = value;
            }
        }
    }
}
