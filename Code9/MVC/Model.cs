using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public abstract class Model
    {
        private readonly ICollection<View> Views = new List<View>();

        public void Attach(View view)
        {
            Views.Add(view);
        }
        public void Detach(View view)
        {
            Views.Remove(view);
        }
        public void Notify()
        {
            foreach (var o in Views)
            {
                o.Update();
            }
        }
    }
}
