using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager.PlayWaterLevel();
            GameManager.PlayFireLevel();
        }

        public static class GameManager
        {
            public static void PlayWaterLevel()
            {
                IGoblin waterGoblin = new WaterGoblin();
                IWizard waterWizard = new WaterWizard();
                waterGoblin.DoDamage();
                waterWizard.DoMagic();
                Console.ReadKey();
            }

            public static void PlayFireLevel() 
            {
                IGoblin fireGoblin = new FireGoblin();
                IWizard fireWizard = new FireWizard();
                fireGoblin.DoDamage();
                fireWizard.DoMagic();
                Console.ReadKey();
            }
        }
    }
}
