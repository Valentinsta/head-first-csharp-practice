using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        public const float EGGS_PER_SHIFT = 0.45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        private Bee[] workers = Array.Empty<Bee>();
        private float eggs = 0;
        private float unassignedWorkers = 3;

        public override float CostPershift { get; }
        public string StatusReport { get; private set; }

        public Queen() : base("Queen")
        {
            CostPershift = 2.15f;
            StatusReport = string.Empty;
            AssingBee("Nectar Collector");
            AssingBee("Honey Manufacturer");
            AssingBee("Egg Care");
        }

        public void AssingBee(string jobName)
        {
            switch (jobName)
            {
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
                default:
                    throw new ArgumentException("Invalid job name.", nameof(jobName));
            }
            UpdateStatusReport();
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers)
            {
                worker.WorkTheNextShift();
            }
            HoneyVault.ConsumeHoney(unassignedWorkers * HONEY_PER_UNASSIGNED_WORKER);
            UpdateStatusReport();
        }

        /// <summary>
        /// Expand the workers array by one slot and add a Bee reference.
        /// </summary>
        /// <param name="worker">Worker to add to the workers array.</param>
        private void AddWorker(Bee worker)
        {
            if ((int)Math.Round(unassignedWorkers) >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[^1] = worker;
            }
        }

        private void UpdateStatusReport()
        {
            StringBuilder updateBuilder = new();
            updateBuilder.Append(HoneyVault.StatusReport);
            updateBuilder.Append($"\nEgg count: {eggs:0.0}");
            updateBuilder.Append($"\nUnassigned workers: {unassignedWorkers:0.0}");
            updateBuilder.Append($"\n{WorkerStatus("Nectar Collector"):0.0}");
            updateBuilder.Append($"\n{WorkerStatus("Honey Manufacturer"):0.0}");
            updateBuilder.Append($"\n{WorkerStatus("Egg Care"):0.0}");
            updateBuilder.Append($"\nTOTAL WORKERS{workers.Length:0.0}");
            StatusReport = updateBuilder.ToString();
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (Bee worker in workers)
                if (worker.Job == job) count++;
            string s = (count == 1) ? "" : "s";
            return $"{count} {job} bee{s}";
        }
    }
}
