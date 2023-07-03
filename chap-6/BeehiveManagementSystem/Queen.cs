using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        public readonly string StatusReport = string.Empty;

        public override float CostPershift { get; }

        private Bee[] workers = Array.Empty<Bee>();
        private double EGGS_PER_SHIFT;
        private int unassignedWorkers;

        public void AssingBee()
        {

        }

        public void CareForEggs()
        {

        }

        protected override void DoJob()
        {
            base.DoJob();
            // adds 0.45 eggs to her private eggs field(using a const called EGGS_PER_SHIFT).
            EGGS_PER_SHIFT += 0.45;
            /* The EggCare bee will call her CareForEggs method, which decreases eggs and increases unassignedWorkers.
             * Then it uses a foreach loop to call each worker’s WorkTheNextShift method.
             * It consumes honey for each unassigned worker. The HONEY_PER_UNASSIGNED_WORKER const tracks how much each one consumes per shift.
             * Finally, it calls its UpdateStatusReport method. 
             */

        }

        /// <summary>
        /// Expand the workers array by one slot and add a Bee reference.
        /// </summary>
        /// <param name="worker">Worker to add to the workers array.</param>
        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[^1] = worker;
            }
        }
    }
}
