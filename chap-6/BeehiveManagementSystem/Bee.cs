using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        public string Job { get; private set; }
        public abstract float CostPershift { get; }

        public Bee(string typeName)
        {
            Job = typeName;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPershift))
            {
                DoJob();
                return;
            }
            throw new InvalidOperationException("The bee cannot work");
        }

        protected abstract void DoJob();
    }
}
