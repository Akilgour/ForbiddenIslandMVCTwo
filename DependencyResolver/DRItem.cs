using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyResolver
{
    public class DRItem
    {
        public DRItem()
        {

        }

        public DRItem(Type Interface, string ClassName)
            : this(Interface, ClassName, string.Empty)
        {
        }

        public DRItem(Type Interface, string ClassName, string Country)
        {
            this.Interface = Interface;
            this.ClassName = ClassName;
        }

        public Type Interface { get; private set; }

        public string ClassName { get; private set; }
    }
}
