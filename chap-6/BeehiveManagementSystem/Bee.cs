using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        public string Job { get; set; } = string.Empty;
        public virtual float CostPershift { get; }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPershift))
            {
                DoJob();
                return;
            }
            throw new InvalidOperationException("The bee cannot work");
        }

        protected virtual void DoJob() { }
    }
}
