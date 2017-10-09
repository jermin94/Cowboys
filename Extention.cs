namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public static class Extention
    {
        public static string extentionDoubleHeure(this double temps)
            {
            string tempsEnSTring = temps.ToString();
            string PremierIndiceDuTemps1 = string.Empty;
            for (int i = 0; i < 1; i++)
            {
                PremierIndiceDuTemps1 = tempsEnSTring[i].ToString();
            }
            return PremierIndiceDuTemps1;

        }

        public static string extentionMinute(this double temps)
        {
            string tempsEnSTring = temps.ToString();
            string PremierIndiceDuTemps1 = string.Empty;
            for (int i = 2; i < 4; i++)
            {
                PremierIndiceDuTemps1 = tempsEnSTring[i].ToString();
            }
            return PremierIndiceDuTemps1;
        }
    }
}
