using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Mini_DnF
{
    public class MainFieldClass
    {
        AllNumberClass AN = default;

        public void AllNumSet(AllNumberClass allnum)
        {
            this.AN =allnum;
        }


        //public void LineIn() //테두리 예정
        //{
        //    for(int y=0; y <17; y++)
        //    {
        //        AN.lineY[y] = "─";
        //    }
        //}

        //public void LineOut()
        //{
        //    for(int y =1; y <; y++)
        //    {
        //        Console.SetCursorPosition(y, 1);
        //        Console.Write("{0}", AN.lineY[y]);
        //    }
        //}


        public void FieldInput() //필드 입력
        { 
            for(int y=0; y < 17; y++)
            {
                for(int x =0; x < 17; x++)
                {
                    if (AN.bakalHousePos_Y == y && AN.bakalHousePos_X == x) //바칼레이드
                    {
                        AN.mainField[y, x] = "B ";
                        continue;
                    }
                    if (AN.playerPos_Y == y && AN.playerPos_X == x) //플레이어
                    {
                        AN.mainField[y, x] = "P ";
                        continue;
                    }
                    if(AN.dungeon_1Pos_Y == y && AN.dungeon_1Pos_X == x) //던전1
                    {
                        AN.mainField[y, x] = "1 ";
                        continue;
                    }
                    if(AN.dungeon_2Pos_Y == y && AN.dungeon_2Pos_X == x) //던전2
                    {
                        AN.mainField[y, x] = "2 ";
                        continue;
                    }
                    if(AN.dungeon_3Pos_Y == y && AN.dungeon_3Pos_X == x) //던전3
                    {
                        AN.mainField[y, x]  = "3 ";
                        continue;
                    }
                   
                    AN.mainField[y, x] = "* "; //필드
                }
            }
        }

        public void FieldOutput() //필드 출력
        {
            for(int y =0; y < 17; y++)
            {
                for(int x = 0; x < 17; x++)
                {
                    //프로토 타입 이후에 커서로 예쁘게 만들기
                    //Console.SetCursorPosition(y+2,x+2);// 커서 위치 조정 예정
                    Console.Write("{0}", AN.mainField[y, x]);
                }
                Console.WriteLine();
            }
        }

    }
}
