using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    public class ConcreteView : View
    {
        private object ViewState;
        private ConcreteModel Model { get; set; }
        public ConcreteView(ConcreteModel model)
        {
            Model = model;
        }
        public override void Update()
        {
            ViewState = Model.ModelState;
        }
    }
}
