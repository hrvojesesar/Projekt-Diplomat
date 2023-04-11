using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
       public EntityStateOption EntityState { get; set; }
       public bool HasChanges { get; set; }
        public bool isNew { get; private set; }

        public bool isValid => Validate();

        public abstract bool Validate();
        

        
    }
}
