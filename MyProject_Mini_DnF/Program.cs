using MyProject_Mini_DnF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;


namespace MyProject_Mini_DnF
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ThreadPool 

            

            


            //컷인 사운드 삽입중 끝남 프토로타입은 완성됨 
            //현재 Thread방식으로 소리가끝나고 다음이 실행되는것이 아닌 멀티 실행으로 
            //구현예정인데 쓰레드는 한번사용하면 다시선언해서 사용해줘야함 그래서 부를때마다 선언하게 할 예정
            //ThreadPool 사용해야 할것같음

            Console.SetWindowSize(150, 63);

            Console.SetBufferSize(150, 63);


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
            dungeonBattle.CutinSet(cutin); //컷인 배틀클래스 에서 쓸수있게 넘기기
            cutin.AllNumSet(allNumber);
            #endregion

            Console.SetCursorPosition(20, 30);
            Console.SetCursorPosition(1, 1);
       





            Console.Write("당신의 직업을 선택해주세요!");
            Console.SetCursorPosition(20, 31);
            Console.Write("1 = 웨펀마스터     2 = 스핏파이어");
            Console.SetCursorPosition(20, 32);
            allNumber.userClass = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(1, 1);

            Console.Clear();


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
