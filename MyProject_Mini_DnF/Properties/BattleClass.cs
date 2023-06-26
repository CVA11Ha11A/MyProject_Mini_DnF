using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject_Mini_DnF.Properties
{
    public class BattleClass
    {
        AllNumberClass AN = default;

        public void AllNumSet(AllNumberClass allnum)
        {
            this.AN =allnum;
        }
        public void MukWoodOutput() //머크우드 출력문
        {
            Console.WriteLine("    .    .;c:;;,.... ....''.'..;c;,'. ...  ...  .. .....;:c;,;:,,,'..,::clc:::.........     .';;'';:'........... ..  ..      ....   . ..'',:;',:::l,.,\r\n         .:c:::c:;'.    .'...,;;c:,'. ........    .....';:::;,;,,,...,;,,cl:::,........    ..';:,','.'...................    ....  ......',:;',c::l;',\r\n        .';,;cclcc:.    .....,;,::,'...... ...   .....';:;;;,',,;,...','';:c::;'......  ..,;,''',....''.......''.......''.    ...  .....',,,'';c:cl;';\r\n        .''.,cccccc'     ...'''.,c:... ... ..   ......,;c:,,'.'::.........',:c:,........;c:;;,..... ..'......'''......,,'.      ........,,,'.';c::l:,:\r\n       ......;:;:cc;. ..  ......':c,..... ...   .....'';c;''''':l:......'.',;ll;......',::,'''....  ............. .'..',....    .. .....';;,,;;::;;;',\r\n       .'....,;,:ll:.....  ..;clccl:. .  ....  ....'',,;;::c:;;,cxd:..'...',;loc,,'..';;;;'....     ................. .......  ... .''..,::;;:;;:;,,',\r\n     ........;;,:llc,..... .,:llclod;. . ....  ...''',,,,:coxddoooxkdccl:',;;:ll;,'..',,'.. ..      ........''........... ....  . .....':cc;,;;,,,..',\r\n     ..    .';;,:ool:,'...',:clc;;lo,.   ....  ...,',;;,',;:ldxxkkxxOOkxko;;;:clc,''..''..         ........',;,,...  .. .....    ......,;:::,,,,,'..',\r\n     ..   ...;:;;oocc:,..';cc:;;,,:;.  . ...   ..''..',;;;:clllodxO00000OOkxxo::lod:'....          ......,...,;;,.     ... ..    .....,:c;;,''',;...''\r\n      ..  ..':c:':oc::,..,;::;,''... ... . .. ...'',;:cccllllooodkOOOkOKX0kxkx:,lKO:''..           ......'...':,''.    ..  ..   .....',:c;,'..',,.....\r\n     .'.   .;cl:''cc;;,.':c::,''.... ...  ... ..',clllcllooooollldddllkKkc:clddllxd,....           ..........,c;,,.   ......   .....'',::,''..'.''....\r\n     .,'   .;:cc'.,;,'..':c::;;'... ..... ......,;;::clooooooolc:::,';lddl;,;coc;;,..''.           ..........;cc,'.   . .....  ...''',,,'.',,,'.,,'.  \r\n     .:,.  .';::...,;....:ccll;.... ...'. ..'..,;clooooooooooll;...',,,:lc;,,;:c:,...,;'.          ...'..,;;;::;,.    . .....  ...',,;;,....,,,,;,.   \r\n  . .'c:.   ..',,..::'...:cclc,.... ...'......,:loooooollc:;;;;;,'....',:cc:::,',,''.,''..          ..,,',:looc;.        ...  ...',',:;;,...',;;,..   \r\n ....,c:.   ...';,,ll;,..:lcc,. ....  .'. ...':looooooooool:',;;;,,'...',cl;;,,:c:::;,;;,'..        ..,,,,:coll:'     .. ..   ..''...,;;;,'..',,,'.   \r\n ...',:c'.   ...::,:l::'.:llc'.   ...  ...',,;cooooooooollccc:;,.......''od::::;'',;;;cc,.,.        ..'''';;:c:;.    ... .... ..'.....,;;;,...';,.    \r\n ...'';:,.     .,c;;cc:'.:clc..   .. ....,:clcclcclllll:;;:clllc;'','....','';:;,;::;;::...'.        .'..',',;;,.   ....  ... ....';;,',:::'..,:'     \r\n.....',;'.      ':;,;c:,',,;'.... .. .'',:clolc:;;,;;,'.,:::ccclc:c:,..   .....,,;:;;;,,'. ...       ...''''',;;,'....... ..  .....';;'':c:,',;,.     \r\n .....''.       .:;',::,.........    ..,lolllloo:'''.',''';:::;;,;,'..         .',;,',,;;. ...      . .....',;;;;;'...''. .   ... .;:;,,;::;;,'.      \r\n.........  ......,,,'','.........     .,clllccc;,,,,'',,''.......';:;.          ...';,;c:'  .''..   ......,;,,,'... ...'...   .'..,::,,;;:c:;;.       \r\n.................''.............     .';:ccol,..,;,'',,'''.....',;col:....        .',,;:c,.   ........'...,;'','....  ...     .'.',;;,;;;:::,'.       \r\n...............................      .';::cll:'';;,,,,,',. .....',;:loc,..       ...,,,;:,... ............,,'......... .      .'',,,;::::'',''.       \r\n.............................. ........';clll:';l:,',,,,,'........'',:ll;.      ....''';:,................''..........        ..'',,;:cc;....,'       \r\n.................................... ....;lol:,col:,,,;,,,,'. ..'....,lol:'....  ......','...............'............        ...'::;:c:.. .';,.      \r\n.......''...............................':lol:,:llc;',,;;,,;;'......,loollc:;........................................        ....':c:::;.. ..;:'.     \r\n.......''''.............................':clollccc::;..'''.,:cc;....;c:,';lol:....................  ......'..........  ..    ....';c:;;;'.  .,;,..    \r\n........'''.............................,:cloooolc:;;'....':cclol:,..,::;cc:,............'...............................     ...';::;,;'  ...',.... .\r\n........''..............................:lccllllc,;;,'....,;:lloool;..,:c,.................. ......'.......................   ....,:;,,;. ....','.. ..\r\n........................................;:;clcll:'.''.......';:clllo:...................... ...'......'....... ...................';,,;;. .....,'.....\r\n....''..................''''..........''....,'',,'','...........'',::'....................  ................   ....... ...........'''';;. ... .''.....\r\n.....''.................,,'''..........'........''''............................... ....... ...  ..'....  .  ....  ..  .............'';;..''.. .....''\r\n..........'.............'',;'..'.......'.....................................  ....   ..  ......... .......... ...... ..............;c:::;:lc,.......'\r\n.........''............'',,,'........',,..................................     ............  .......................................',;;',;,,;'.....''\r\n.........,;,...........',,,'........,,,,.....................',,''............................. ...................................................'''\r\n... ....,;'...........','''...''...,;,,,..........................'.........................'''................................ ....';,............''.\r\n");
        }

        public void GoldCrownOutput()
        {
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMNOKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMOclKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMWXOko;:lloxOKWMMMMMMMMMMMMWKKNNNXXNX0x0MMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMNkool:'.,dkx:....':okKWMMMMMMMMNo,;;;;:cll:oXMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMNOo;.......,dko,........'ldx0NMMWXd;',,'....,:::xNMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMNk:......''...:l:'.'......'lxdcoXW0c,,,,;clc'...,;'oNMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWO:.......,;,...,::;;;;;;;'.cOKk:'xXl'.'''..:d:....';lk0XWMMMMMMMMMMMM\r\nMMMMMMMMMWx....,;,...,'..,:c:'','',;'.cxxl'.dk:,,,'.. .cl..,,;:;cd0WMMMMMMMMMMMM\r\nMMMMMMMMMk...,;;,''.......',,......'..,:c,..,,'',,.....cc'.';c;.dWMMMMMMMMMMMMMM\r\nMMMMMMMNk,..:;,;,'......'...'.........',,'...''......;:c'...;:',OMMMMMMMMMMMMMMM\r\nMMMMMMM0;..,;',,...'lxkdc,..',;:,',;;,;;,;lolc:;'';;,'......;,.cXMMMMMMMMMMMMMMM\r\nMMMMMMM0,.'',,,'..,ONO:'....''';cc:::;,,''':ccc:,,::,.........'kWMMMMMMMMMMMMMMM\r\nMMMMMMMO,......':oOWO;;;''cdxo:.;lc'.',''.....';:;'.....,;c:'.oNMMMMMMMMMMMMMMMM\r\nMMMMMMMO,.....;0WMMNl;:,:xK0xdl'.:dl:;:;;;,;cc,,;'......,:;,'cKMMMMMMMMMMMMMMMMM\r\nMMMMMMMK;.....kMMMMK:',;loc;,,;;',dkdoccclc,',. ..,c:,. ':,.;0MMMMMMMMMMMMMMMMMM\r\nMMMMMMMWd....:XMMMM0:',;:odxkOkOl.;:,,;ldxkkdc,,,:ll:'...,;;lk0NMMMMMMMMMMMMMMMM\r\nMMMMMMMM0,...dWMMMMKc.,;ldooollc,.lxo'.cxkOOkdoodddol;'...,:ldd0MMMMMMMMMMMMMMMM\r\nMMMMMMMMXo..'OMMMMMWx:''lkxol;,'..,ll'.cxxo:;:cddo:;c:...';,:dOXMMMMMMMMMMMMMMMM\r\nMMMMMMMMMNd.'kWMMMMMWk,..,cdkdc'........''....,lc'.......;,;kWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMNd,.:KMMMMMWo.,;'..',.........;:;'.,,...     .';clokNMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMK:..'kMMMMWO;.....  .. ........'';xXN0o' ...,ldoc:lONMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMW0c'dNMMWXOc......   ....',...'..oNMMMWx,'.'oOXNXXNMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWkco0WWxc:',,........,;;,;,.,;,;lxONMMNkc,,c;,dXMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMW0c,.cXNd,,;:... .'c;.''',;'.,;''..,xXWMWo.':l;'oNMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWO:'kWNl.,dl....l0K:.......... .....,lONk..'',..dWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMWWWXOO0o,.dK:..;OWXc......  .,. ...''...::':xxc;::lkkdOXMMMMMMMMMMMMMMM\r\nMMMMMMMMNKXKd;..'okKd..cKMNd'',..,;..lXd,...........'ck0kOO;...':dkO0NWWNNWMMMMM\r\nMMMMMMWOlxKd,,,..xWK:.cKWMWXd,,:;dx..kMKx;.........cOl,clll,...::'',::;cokKNWMMM\r\nMMMMMWO;.,::clc;,xOl,:OWMMM0c.,kKKK;:XMWNx. ......,0WOOOldd;'',:llllo:':kXXKNMMM\r\nMMMMMNo.',:dxl;''';;cKWMMNO;...cKWWolNMWNO;...''.'l000NWNWWXx,':ddlll:,'lKWMMMMM\r\nMMMMMMd...;oc'''clodxWWXNO:...':OWM0kNNxcc,.'oKK0KNO:lKMMMMMKc';:;,;c;'..cNMMMMM\r\nMMMMMXl...,c;',c0KKNNWkcdKXc.,lKWMMWNOc,,;,.,oxkkkko,;0MMMMMWKd:,'''...od:kWMMMM\r\nMMMMKlcx:.'',ckNMMMMMNl'lkx:'';dXMMMNc...,'....,;::,..cXMMMMMMWX0l.;l,:KNOxKMMMM\r\nMMMMKk0Kl;x;,0WMMMMMNd..lol::..;0MMMWk:;;;,:d:........'xWMMMMMWN0llKKdlONKKWMMMM\r\nMMMMWKKKdxXOcdKXNMMK:...'''..'cdKMMMMMWNNWWWMN0OOOOOOO0NMMMMMMWNKOXWNKKNMWWMMMMM\r\nMMMMMMMWNXXWNXNXWMMXd:,,,,;:l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMM\r\nMMMMMMMMMWWMMMMMMMMMMMWNNNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
        }

        public void DungeonIn()
        {
            if (AN.playerPos_Y == AN.dungeon_1Pos_Y && AN.playerPos_X == AN.dungeon_1Pos_X)
            {
               Dungeon1_In();
            }
            if(AN.playerPos_Y == AN.dungeon_2Pos_Y && AN.playerPos_X == AN.dungeon_2Pos_X)
            {
                Dungeon2_In();
            }
        }


        public void Dungeon1_In() //던전 1 입장시 배틀 로직
        {
            Console.Clear();        //X    Y
            Console.SetCursorPosition(50, 20);
            Console.Write("타우비스트 등장");
            Console.SetCursorPosition(0, 0);
            Thread.Sleep(500);
            Console.Clear();

            
           // Console.ReadLine();
            while (true)
            {
                Console.Clear();
                MukWoodOutput();
                Console.SetCursorPosition(1, 37);
                Console.Write("플레이어의 공격!");

               AN.mukwoodHp = AN.mukwoodHp - AN.playerDamege;
                Console.ReadLine();

                Console.SetCursorPosition(1, 38);
                Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                Console.ReadLine(); //입력후 넘기기
                Thread.Sleep(300);

                Console.SetCursorPosition(1, 39);
                Console.Write("타우비스트는 체력이 {0} 만큼 남았다!", AN.mukwoodHp);
                Console.ReadLine(); //입력후 넘기기
                Console.SetCursorPosition(1,1);
                Thread.Sleep(300);

                if (AN.mukwoodHp <= 0) //플레이어가 이겼을 시
                {
                    Console.Clear();
                    Console.SetCursorPosition(1, 37);
                    Console.Write("타우비스트는 쓰러졌다!");
                    Thread.Sleep(300);
                    Console.Clear();
                    Console.SetCursorPosition(1, 37);
                    Console.Write("보상으로 공격력 10증가!\n보상으로 최대체력 30증가! ");
                    AN.playerDamege = AN.playerDamege + 10;
                    AN.playerDamegeReset = AN.playerDamegeReset + 10;
                    AN.playerHp = AN.playerHp + 30;
                    AN.playerMaxHp = AN.playerMaxHp + 30;
                    AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                    AN.mukwoodHp = 200; //다시 채력 채워주기
                    AN.playerPos_X +=1;
                    Console.ReadLine(); //입력후 반복문 탈출
                    break;
                }

                Console.Clear();
                MukWoodOutput();
                Console.SetCursorPosition(1, 37);
                Console.Write("타우비스트의 공격!");
                Console.ReadLine(); //입력후 넘기기

                AN.playerHp = AN.playerHp - AN.mukwoodDamage;
                Console.SetCursorPosition(1, 38);
                Console.Write("타우비스트는 {0} 만큼 데미지를 주었다!",AN.mukwoodDamage);
                Console.ReadLine(); //입력후 넘기기

                Console.SetCursorPosition(1, 39);
                Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                Console.ReadLine(); //입력후 넘기기

                if(AN.playerHp <= 0)
                {
                    Console.Clear();

                    Console.WriteLine("당신은 쓰러졌다....");
                    AN.playerPos_X =8;
                    AN.playerPos_Y =8;
                    AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                    AN.mukwoodHp = 200; //다시 채력 채워주기
                    Console.ReadLine() ;
                    break;
                }
            }
        }


        public void Dungeon2_In() //던전 2 입장시 배틀 로직
        {
            Console.SetCursorPosition(50,20);
            Console.Write("골드 크라운이 지켜보고 있다.");
            Thread.Sleep(500);
            Console.Clear() ;

            Console.SetCursorPosition(50, 21);
            Console.WriteLine("골드 크라운 : 오랜만에 찾아 주셨네요??");
            Thread.Sleep(1500);
            GoldCrownOutput();

            Console.SetCursorPosition(0, 0);
            
            Console.Clear();


            // Console.ReadLine();
            while (true)
            {
                Console.Clear();
                GoldCrownOutput();
                Console.SetCursorPosition(1, 37);
                Console.Write("골드 크라운의 공격!");

                AN.goldCrownHp = AN.goldCrownHp - AN.playerDamege;
                Console.ReadLine();

                Console.SetCursorPosition(1, 38);
                Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                Console.ReadLine(); //입력후 넘기기
                Thread.Sleep(300);

                Console.SetCursorPosition(1, 39);
                Console.Write("골드 크라운의 체력이 {0} 만큼 남았다!", AN.goldCrownHp);
                Console.ReadLine(); //입력후 넘기기
                Console.SetCursorPosition(1, 1);
                Thread.Sleep(300);

                if (AN.mukwoodHp <= 0) //플레이어가 이겼을 시
                {
                    Console.Clear();
                    Console.SetCursorPosition(1, 37);
                    Console.Write("골드 크라운은 쓰러졌다!");
                    Thread.Sleep(500);

                    Console.SetCursorPosition(1, 37);
                    Console.WriteLine("골드 크라운 : 드디어... 해방.. 되었..ㅇ..");
                    Console.Clear();
                    Console.SetCursorPosition(1, 37);
                    Console.Write("보상으로 공격력 30증가!\n보상으로 최대체력 80증가! ");
                    AN.playerDamege = AN.playerDamege + 30;
                    AN.playerDamegeReset = AN.playerDamegeReset + 30;
                    AN.playerHp = AN.playerHp + 80;
                    AN.playerMaxHp = AN.playerMaxHp + 80;
                    AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                    AN.goldCrownHp = 500; //다시 채력 채워주기
                    AN.playerPos_Y -=1;
                    Console.ReadLine(); //입력후 반복문 탈출
                    break;
                }

                Console.Clear();
                GoldCrownOutput();
                Console.SetCursorPosition(1, 37);
                Console.Write("골드크라운의 공격!");
                Console.ReadLine(); //입력후 넘기기

                AN.playerHp = AN.playerHp - AN.mukwoodDamage;
                Console.SetCursorPosition(1, 38);
                Console.Write("골드크라운는 {0} 만큼 데미지를 주었다!", AN.mukwoodDamage);
                Console.ReadLine(); //입력후 넘기기

                Console.SetCursorPosition(1, 39);
                Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                Console.ReadLine(); //입력후 넘기기

                if (AN.playerHp <= 0)
                {
                    Console.Clear();

                    Console.WriteLine("당신은 쓰러졌다....");
                    AN.playerPos_X =8;
                    AN.playerPos_Y =8;
                    AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                    AN.mukwoodHp = 200; //다시 채력 채워주기
                    Console.ReadLine();
                    break;
                }
            }
        }

    }
}
