using MyProject_Mini_DnF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_Mini_DnF
{
    public class PlyaerMoveClass
    {
        AllNumberClass AN = default;

        public void AllNumSet(AllNumberClass allnum)
        {
            this.AN =allnum;
        }

        public void PlayerMove() //플레이어 이동 메서드
        {
            
        AN.playerMoveInput = Console.ReadKey(true);

            switch (AN.playerMoveInput.Key)
            {
                case ConsoleKey.A:
                    AN.playerPos_X -=1;
                    if(AN.playerPos_X <= 1)
                    { AN.playerPos_X = +1;}
                    break;

                case ConsoleKey.D:
                    AN.playerPos_X +=1;
                    if (AN.playerPos_X >= 16)
                    { AN.playerPos_X -=1; }
                    break;

                case ConsoleKey.W:
                    AN.playerPos_Y -=1;
                    if(AN.playerPos_Y <= 0)
                    { AN.playerPos_Y +=1; }
                    break;
                case ConsoleKey.S:
                    AN.playerPos_Y +=1;
                    if(AN.playerPos_Y >= 16)
                    { AN.playerPos_Y-=1; }
                    break;
            }

        }




    }
}
