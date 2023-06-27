using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundPlayerTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\\bakal_dragon_king_2phase.wav");
            //player.PlaySync();

            System.Media.SoundPlayer irine = new System.Media.SoundPlayer("C:\\flo_apc_dx_22.wav");

            irine.PlaySync();
        }


    }
}
