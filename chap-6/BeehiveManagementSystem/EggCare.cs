using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class EggCare : Bee
    {
        private const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        private Queen queen;

        public override float CostPershift { get; }

        public EggCare(Queen queen) : base("Egg Care")
        {
            CostPershift = 1.35f;
            this.queen = queen;
        }

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
