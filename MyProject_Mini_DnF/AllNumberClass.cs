using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Mini_DnF
{
    public class AllNumberClass
    {

        #region 필드 관련 변수
        public string[] lineY = new string[18];
        //0은 커서로 버릴거고 1.1 부터 테두리 2.2부터 찍을 예정 필드 사이즈 15 예상
        public string[,] mainField = new string[17,17]; //메인 필드에 사용할 배열
        
        public int playerPos_Y = 8; //플레이어 좌표
        public int playerPos_X = 8;

        public int dungeon_1Pos_Y = 8; //첫번재 던전 좌표
        public int dungeon_1Pos_X = 2;

        public int dungeon_2Pos_Y = 14; //두번째 던전 좌표
        public int dungeon_2Pos_X = 8;

        public int dungeon_3Pos_Y = 8;//세번째 던전 좌표
        public int dungeon_3Pos_X = 14;

        public int bakalHousePos_Y = 2; //바칼 레이드 좌표
        public int bakalHousePos_X = 8;

        #endregion


        #region 입력 변수들
        public ConsoleKeyInfo playerMoveInput; //이동 할때 받을 변수

        #endregion
        #region 랜덤 변수
        Random rand = new Random();
        int randNum = default;
        #endregion

        #region 플레이어 스텟 변수
        public int playerDamegeReset = 50; //지휘관 버프시 증가한 대미지 돌리는용도
        public int playerDamege = 50;

        public int playerMaxHp = 500; //지휘관 버프시 오버 체력을 다시 돌려줄용도
        public int playerHp = 500;

        public int playerRageCount = 0; //필살기 사용 조건
        #endregion


        #region 몬스터 변수

        //머크우드
        public int mukwoodHp = 100;
        public int mukwoodDamage = 20;

        //골드크라운
        public int goldCrownHp = 500;
        public int goldCrownDamage = 70;

        #endregion
    }
}
