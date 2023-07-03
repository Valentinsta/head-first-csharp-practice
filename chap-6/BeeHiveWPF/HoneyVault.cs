using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        public static string StatusReport { get; } = string.Empty;
        private static float honey = 25f;
        private static float nectar = 100f;

        public static void CollectNectar()
        {
            nectar += 5f;
        }

        public static void ConvertNectarToHoney(float nectarQuantity)
        {
            float honeydew = nectarQuantity * .25f;
            nectar -= nectarQuantity;
            honey += honeydew;
        }

        public static bool ConsumeHoney(float HoneyQuantity)
        {
            if (honey < HoneyQuantity)
            {
                return false;
            }
            honey -= HoneyQuantity;
            return true;
        }
    }
}
