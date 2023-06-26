using MyProject_Mini_DnF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Mini_DnF
{
    public class Program
    {
        static void Main(string[] args)
        {
            //웨펀 컷신 9번째장 부터 찍으면됨 CutinClass에서 찍는중에 끝남
            Console.SetWindowSize(230, 63);

            Console.SetBufferSize(230, 63);

            Console.CursorVisible = false;

            #region 클래스선언
            AllNumberClass allNumber = new AllNumberClass(); //모든 변수가 들어있는 클래스
            MainFieldClass mainField = new MainFieldClass();
            PlyaerMoveClass playerMove = new PlyaerMoveClass();
            BattleClass dungeonBattle = new BattleClass();
            CutinClass cutin = new CutinClass();
            #endregion

            #region 인스터트로 변수 넘기기
            mainField.AllNumSet(allNumber); //메인필드 인풋에 넣기
            playerMove.AllNumSet(allNumber);
            dungeonBattle.AllNumSet(allNumber);
            #endregion


            cutin.WeaponCutin();
            Console.WriteLine();


            while (true)
            {
               Console.SetCursorPosition(0, 0);
               mainField.FieldInput();
             mainField.FieldOutput();
             playerMove.PlayerMove();
             dungeonBattle.DungeonIn();
             Console.SetCursorPosition(0, 0);


            }

        }
    }
}
