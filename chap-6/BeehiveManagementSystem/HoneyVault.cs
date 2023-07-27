using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = .19f;
        const float LOW_LEVEL_WARNING = 10f;
        private static float honey = 25f;
        private static float nectar = 100f;

        public static string StatusReport
        {
            get
            {
                StringBuilder reportBuilder = new();
                reportBuilder.Append($"Vault report:\nHoney: {honey:0.0} units\nNectar: {nectar:0.0} units");

                if (honey < LOW_LEVEL_WARNING)
                {
                    reportBuilder.Append("\nLOW HONEY - ADD A HONEY MANUFACTURER");
                }
                if (nectar < LOW_LEVEL_WARNING)
                {
                    reportBuilder.Append("\nLOW NECTAR - ADD A NECTAR COLLECTOR");
                }

                return reportBuilder.ToString();
            }
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float nectarQuantity)
        {
            nectarQuantity = (nectarQuantity > nectar) ? nectar : nectarQuantity;

            float honeydew = nectarQuantity * NECTAR_CONVERSION_RATIO;
            nectar -= nectarQuantity;
            honey += honeydew;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey < amount)
            {
                return false;
            }
            honey -= amount;
            return true;
        }
    }
}
