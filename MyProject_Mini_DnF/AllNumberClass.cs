using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

        public int codenamePos_Y = 4; //코드네임 게이볼그 던전 좌표
        public int codenamePos_X = 4;

        public int bakalHousePos_Y = 2; //바칼 레이드 좌표
        public int bakalHousePos_X = 8;

        #endregion
        

        #region 입력 변수들
        public ConsoleKeyInfo playerMoveInput;//이동 할때 받을 변수
        public ConsoleKeyInfo playerBattleInput;

        public int nowSound = 0;
        public int themeCount = 0;

        #endregion
        #region 랜덤 변수
        Random randNum = new Random();


        #endregion

        #region 플레이어 스텟 변수

        //플레이어가 선택한 직업알려줄 변수

        public int userClass = default;

        //웨펀 마스터
        public int playerDamegeReset = 3500; //지휘관 버프시 증가한 대미지 돌리는용도
        public int playerDamege = 3500;

        public int playerMaxHp = 500; //지휘관 버프시 오버 체력을 다시 돌려줄용도
        public int playerHp = 500;

        public int playerDef = 0;
        public int playerDefReset = 0;


        //스핏파이어
        public int player2DamageReset = 1600;
        public int player2Damage = 1600;

        public int player2Def = 0; //사라 지휘관버프로 한턴 데미지 무효화할때 필요
        public int player2DefReset = 0;

        public int player2MaxHp = 4500;
        public int player2Hp = 4500;

        public int playerRageCount = 0; //필살기 사용 조건
        #endregion



        #region 몬스터 변수

        //머크우드
        public int mukwoodHp = 100;
        public int mukwoodDamage = 20;

        //골드크라운
        public int goldCrownHp = 500;
        public int goldCrownDamage = 70;

        //아스타로스
        public int astarosHp = 2500;
        public int astarosDamage = 150;

        //바칼
        public int bakalHp = 10000;
        public int bakalDamage = 300;
        public int bakalMeet = 0;   //바칼과 첫조우인지볼 변수
        public int bakalPhase = 1; //몇페이즈인지 알려줄 변수
        public int bakalphase2Atk = 0;

        #endregion

        #region 코드네임 게이볼그 관련 변수

        //디리겐트 변수
        public int dirigent​Hp = 1000;
        public int dirigentHpReset = 1000;
        public int dirigentDamage = 100;

        public int dirigentMeet = 0; //디리겐트 첫만남 이벤트를위한변수

        public int dirigentKill = 0; //다음층을 가기위한 변수

        //이덴디테이트 변수
        public int idenditate​Hp = 1500;
        public int idenditateHpReset = 1500;
        public int idenditateDamage = 170;

        public int idenditateMeet = 0; //이덴디테이트 첫만남 이벤트를위한변수
        public int idenditateKill = 0; //다음층을 가기위한 변수

        //지젤변수

        public int gizelHp = 500;
        public int gizelHpMax = 500;
        public int gizelDamage = 50;

        public int gizelMeet = 0;
        public int gizelKill = 0;


        //게이볼그 변수
        public int gaebolgHp = 3000;
        public int gaebolgHpReset = 3000;
        public int gaebolgDamage = 250;

        public int gaebolgMeet = 0;


        #endregion



    }
}
