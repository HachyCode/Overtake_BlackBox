using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Overtake
{
    class Program
    {
        static readonly int size = 1000;
        static readonly string filePath = (@"C:\Users\Viktorija Pheonix\Documents\Programing\Level_6\OvertakeData.csv");

        static void Main()
        {
            File.WriteAllLines(filePath, OvertakeInfo(size));

            Console.ReadKey();
        }

        static string[] OvertakeInfo(int amount)
        {
            string[] OvertakeData = new string[amount];

            for (var i = 0; i < amount; i++)
            {
                Blackbox.Overtake.SetRandomAsRepeatable(false);
                var overtake = Blackbox.Overtake.GetNextOvertake();

                OvertakeData[i] = $"{overtake.InitialSeparationM},{overtake.OvertakingSpeedMPS},{overtake.OncomingSpeedMPS},{overtake.Success}";
                Console.WriteLine(OvertakeData[i]);
            }

            return OvertakeData;
        }
    }
}
