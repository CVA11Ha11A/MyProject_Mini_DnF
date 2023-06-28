using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyProject_Mini_DnF.Properties
{
    public class BattleClass
    {

        CutinClass CS = default;
        AllNumberClass AN = default;

        Random rand = new Random();

        public void AllNumSet(AllNumberClass allnum)
        {
            this.AN =allnum;
        }
        public void CutinSet(CutinClass cutinmethod)
        {
            this.CS = cutinmethod;
        }
        public void MukWoodOutput() //머크우드 출력문
        {
            Console.WriteLine("    .    .;c:;;,.... ....''.'..;c;,'. ...  ...  .. .....;:c;,;:,,,'..,::clc:::.........     .';;'';:'........... ..  ..      ....   . ..'',:;',:::l,.,\r\n         .:c:::c:;'.    .'...,;;c:,'. ........    .....';:::;,;,,,...,;,,cl:::,........    ..';:,','.'...................    ....  ......',:;',c::l;',\r\n        .';,;cclcc:.    .....,;,::,'...... ...   .....';:;;;,',,;,...','';:c::;'......  ..,;,''',....''.......''.......''.    ...  .....',,,'';c:cl;';\r\n        .''.,cccccc'     ...'''.,c:... ... ..   ......,;c:,,'.'::.........',:c:,........;c:;;,..... ..'......'''......,,'.      ........,,,'.';c::l:,:\r\n       ......;:;:cc;. ..  ......':c,..... ...   .....'';c;''''':l:......'.',;ll;......',::,'''....  ............. .'..',....    .. .....';;,,;;::;;;',\r\n       .'....,;,:ll:.....  ..;clccl:. .  ....  ....'',,;;::c:;;,cxd:..'...',;loc,,'..';;;;'....     ................. .......  ... .''..,::;;:;;:;,,',\r\n     ........;;,:llc,..... .,:llclod;. . ....  ...''',,,,:coxddoooxkdccl:',;;:ll;,'..',,'.. ..      ........''........... ....  . .....':cc;,;;,,,..',\r\n     ..    .';;,:ool:,'...',:clc;;lo,.   ....  ...,',;;,',;:ldxxkkxxOOkxko;;;:clc,''..''..         ........',;,,...  .. .....    ......,;:::,,,,,'..',\r\n     ..   ...;:;;oocc:,..';cc:;;,,:;.  . ...   ..''..',;;;:clllodxO00000OOkxxo::lod:'....          ......,...,;;,.     ... ..    .....,:c;;,''',;...''\r\n      ..  ..':c:':oc::,..,;::;,''... ... . .. ...'',;:cccllllooodkOOOkOKX0kxkx:,lKO:''..           ......'...':,''.    ..  ..   .....',:c;,'..',,.....\r\n     .'.   .;cl:''cc;;,.':c::,''.... ...  ... ..',clllcllooooollldddllkKkc:clddllxd,....           ..........,c;,,.   ......   .....'',::,''..'.''....\r\n     .,'   .;:cc'.,;,'..':c::;;'... ..... ......,;;::clooooooolc:::,';lddl;,;coc;;,..''.           ..........;cc,'.   . .....  ...''',,,'.',,,'.,,'.  \r\n     .:,.  .';::...,;....:ccll;.... ...'. ..'..,;clooooooooooll;...',,,:lc;,,;:c:,...,;'.          ...'..,;;;::;,.    . .....  ...',,;;,....,,,,;,.   \r\n  . .'c:.   ..',,..::'...:cclc,.... ...'......,:loooooollc:;;;;;,'....',:cc:::,',,''.,''..          ..,,',:looc;.        ...  ...',',:;;,...',;;,..   \r\n ....,c:.   ...';,,ll;,..:lcc,. ....  .'. ...':looooooooool:',;;;,,'...',cl;;,,:c:::;,;;,'..        ..,,,,:coll:'     .. ..   ..''...,;;;,'..',,,'.   \r\n ...',:c'.   ...::,:l::'.:llc'.   ...  ...',,;cooooooooollccc:;,.......''od::::;'',;;;cc,.,.        ..'''';;:c:;.    ... .... ..'.....,;;;,...';,.    \r\n ...'';:,.     .,c;;cc:'.:clc..   .. ....,:clcclcclllll:;;:clllc;'','....','';:;,;::;;::...'.        .'..',',;;,.   ....  ... ....';;,',:::'..,:'     \r\n.....',;'.      ':;,;c:,',,;'.... .. .'',:clolc:;;,;;,'.,:::ccclc:c:,..   .....,,;:;;;,,'. ...       ...''''',;;,'....... ..  .....';;'':c:,',;,.     \r\n .....''.       .:;',::,.........    ..,lolllloo:'''.',''';:::;;,;,'..         .',;,',,;;. ...      . .....',;;;;;'...''. .   ... .;:;,,;::;;,'.      \r\n.........  ......,,,'','.........     .,clllccc;,,,,'',,''.......';:;.          ...';,;c:'  .''..   ......,;,,,'... ...'...   .'..,::,,;;:c:;;.       \r\n.................''.............     .';:ccol,..,;,'',,'''.....',;col:....        .',,;:c,.   ........'...,;'','....  ...     .'.',;;,;;;:::,'.       \r\n...............................      .';::cll:'';;,,,,,',. .....',;:loc,..       ...,,,;:,... ............,,'......... .      .'',,,;::::'',''.       \r\n.............................. ........';clll:';l:,',,,,,'........'',:ll;.      ....''';:,................''..........        ..'',,;:cc;....,'       \r\n.................................... ....;lol:,col:,,,;,,,,'. ..'....,lol:'....  ......','...............'............        ...'::;:c:.. .';,.      \r\n.......''...............................':lol:,:llc;',,;;,,;;'......,loollc:;........................................        ....':c:::;.. ..;:'.     \r\n.......''''.............................':clollccc::;..'''.,:cc;....;c:,';lol:....................  ......'..........  ..    ....';c:;;;'.  .,;,..    \r\n........'''.............................,:cloooolc:;;'....':cclol:,..,::;cc:,............'...............................     ...';::;,;'  ...',.... .\r\n........''..............................:lccllllc,;;,'....,;:lloool;..,:c,.................. ......'.......................   ....,:;,,;. ....','.. ..\r\n........................................;:;clcll:'.''.......';:clllo:...................... ...'......'....... ...................';,,;;. .....,'.....\r\n....''..................''''..........''....,'',,'','...........'',::'....................  ................   ....... ...........'''';;. ... .''.....\r\n.....''.................,,'''..........'........''''............................... ....... ...  ..'....  .  ....  ..  .............'';;..''.. .....''\r\n..........'.............'',;'..'.......'.....................................  ....   ..  ......... .......... ...... ..............;c:::;:lc,.......'\r\n.........''............'',,,'........',,..................................     ............  .......................................',;;',;,,;'.....''\r\n.........,;,...........',,,'........,,,,.....................',,''............................. ...................................................'''\r\n... ....,;'...........','''...''...,;,,,..........................'.........................'''................................ ....';,............''.\r\n");
        }

        public void GoldCrownOutput()
        {
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMNOKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMOclKWMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMWXOko;:lloxOKWMMMMMMMMMMMMWKKNNNXXNX0x0MMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMNkool:'.,dkx:....':okKWMMMMMMMMNo,;;;;:cll:oXMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMNOo;.......,dko,........'ldx0NMMWXd;',,'....,:::xNMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMNk:......''...:l:'.'......'lxdcoXW0c,,,,;clc'...,;'oNMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWO:.......,;,...,::;;;;;;;'.cOKk:'xXl'.'''..:d:....';lk0XWMMMMMMMMMMMM\r\nMMMMMMMMMWx....,;,...,'..,:c:'','',;'.cxxl'.dk:,,,'.. .cl..,,;:;cd0WMMMMMMMMMMMM\r\nMMMMMMMMMk...,;;,''.......',,......'..,:c,..,,'',,.....cc'.';c;.dWMMMMMMMMMMMMMM\r\nMMMMMMMNk,..:;,;,'......'...'.........',,'...''......;:c'...;:',OMMMMMMMMMMMMMMM\r\nMMMMMMM0;..,;',,...'lxkdc,..',;:,',;;,;;,;lolc:;'';;,'......;,.cXMMMMMMMMMMMMMMM\r\nMMMMMMM0,.'',,,'..,ONO:'....''';cc:::;,,''':ccc:,,::,.........'kWMMMMMMMMMMMMMMM\r\nMMMMMMMO,......':oOWO;;;''cdxo:.;lc'.',''.....';:;'.....,;c:'.oNMMMMMMMMMMMMMMMM\r\nMMMMMMMO,.....;0WMMNl;:,:xK0xdl'.:dl:;:;;;,;cc,,;'......,:;,'cKMMMMMMMMMMMMMMMMM\r\nMMMMMMMK;.....kMMMMK:',;loc;,,;;',dkdoccclc,',. ..,c:,. ':,.;0MMMMMMMMMMMMMMMMMM\r\nMMMMMMMWd....:XMMMM0:',;:odxkOkOl.;:,,;ldxkkdc,,,:ll:'...,;;lk0NMMMMMMMMMMMMMMMM\r\nMMMMMMMM0,...dWMMMMKc.,;ldooollc,.lxo'.cxkOOkdoodddol;'...,:ldd0MMMMMMMMMMMMMMMM\r\nMMMMMMMMXo..'OMMMMMWx:''lkxol;,'..,ll'.cxxo:;:cddo:;c:...';,:dOXMMMMMMMMMMMMMMMM\r\nMMMMMMMMMNd.'kWMMMMMWk,..,cdkdc'........''....,lc'.......;,;kWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMNd,.:KMMMMMWo.,;'..',.........;:;'.,,...     .';clokNMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMK:..'kMMMMWO;.....  .. ........'';xXN0o' ...,ldoc:lONMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMW0c'dNMMWXOc......   ....',...'..oNMMMWx,'.'oOXNXXNMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWkco0WWxc:',,........,;;,;,.,;,;lxONMMNkc,,c;,dXMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMW0c,.cXNd,,;:... .'c;.''',;'.,;''..,xXWMWo.':l;'oNMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMWO:'kWNl.,dl....l0K:.......... .....,lONk..'',..dWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMWWWXOO0o,.dK:..;OWXc......  .,. ...''...::':xxc;::lkkdOXMMMMMMMMMMMMMMM\r\nMMMMMMMMNKXKd;..'okKd..cKMNd'',..,;..lXd,...........'ck0kOO;...':dkO0NWWNNWMMMMM\r\nMMMMMMWOlxKd,,,..xWK:.cKWMWXd,,:;dx..kMKx;.........cOl,clll,...::'',::;cokKNWMMM\r\nMMMMMWO;.,::clc;,xOl,:OWMMM0c.,kKKK;:XMWNx. ......,0WOOOldd;'',:llllo:':kXXKNMMM\r\nMMMMMNo.',:dxl;''';;cKWMMNO;...cKWWolNMWNO;...''.'l000NWNWWXx,':ddlll:,'lKWMMMMM\r\nMMMMMMd...;oc'''clodxWWXNO:...':OWM0kNNxcc,.'oKK0KNO:lKMMMMMKc';:;,;c;'..cNMMMMM\r\nMMMMMXl...,c;',c0KKNNWkcdKXc.,lKWMMWNOc,,;,.,oxkkkko,;0MMMMMWKd:,'''...od:kWMMMM\r\nMMMMKlcx:.'',ckNMMMMMNl'lkx:'';dXMMMNc...,'....,;::,..cXMMMMMMWX0l.;l,:KNOxKMMMM\r\nMMMMKk0Kl;x;,0WMMMMMNd..lol::..;0MMMWk:;;;,:d:........'xWMMMMMWN0llKKdlONKKWMMMM\r\nMMMMWKKKdxXOcdKXNMMK:...'''..'cdKMMMMMWNNWWWMN0OOOOOOO0NMMMMMMWNKOXWNKKNMWWMMMMM\r\nMMMMMMMWNXXWNXNXWMMXd:,,,,;:l0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMMMMMMM\r\nMMMMMMMMMWWMMMMMMMMMMMWNNNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
        }

        public void AstarosOutput()
        {
            Console.WriteLine("                                                                                                    \r\n                                                                                                    \r\n                                          .,,.                                                      \r\n                                        .*==$=**!                                                   \r\n                                      .:#==*$===#*,-     ,,-                                        \r\n                                      :$==$$#$==$$$$! ;==#@@==.          ;=*!                       \r\n                                     -#=$$$=--$$#$*=#@@@####@#$.          *@#;                      \r\n                      .              *$$$~.   .,*$*=$#@@:;=###@:           =##!                     \r\n                      .             :##;        .*$==$$##$*=$$#@,        .,*#$$-                    \r\n                      .            ,$$$.        ;$@#==$#$!* -$$@,        .$$#$=-                    \r\n                      ~            ~##~        :$;!$$=#=;*- -$$$,.        ,$$=*~                    \r\n                      -           ~=#*       -=:,-:-:=$!!$$*#$#:!:        .$=#!*;                   \r\n                     --.    ~=@~,:#$*. -$@;-*@;,,-..,:=*$$#####$=        :##=$$!*:                  \r\n                     --.      !@#$#=.    :@#**:-~,,,;;!=**$##$=#,    :!!! ~@=$$==$!                 \r\n                     ,,        ,==~       .==!;!-,,;;:;;:;=$=*$~    .-,=*:-##$#$=$=                 \r\n                    .--                    ,!**~..-=*!:!!:!$@;,     .!*--=-#$##$#$=                 \r\n                    .~!                   .;!;!~,,,*=$***:;~       .!*;*=*,$$$#@##                  \r\n                    .:!            ~      ~;~---,-,,~;!$*;:-       . :*==~ .$####*:                 \r\n                    ~:!           ,;     -;:,.-~.;*!;;;=*!;~        -*;!*#. ##@##*!                 \r\n                    -=!           :!    -;:-..-;,:=!*==***;-        , .=!$.:######*!:               \r\n                   .,$;          ,$*   -;~,,,-;:~:$=****~-:~         *=;*$ *##@#$@!;                \r\n                   --$;          **,  -:,,.,~:;-~***=***!.~.        ;-~$$:,$##@#$@::                \r\n                   -~#;         .=*. ,~.,--:::--*$==****. ~ !         -=*-$$$###$#!~.               \r\n                  ,,;#$.        ~$=!.,,~~:::~,.:*!**=$$:   ~=         ==$*#@#@##$$=~-               \r\n                  .-!$#,        ;#$=-;;~~---.~**;**!!==$=, ;$         *=$#@@@@###$$;-,              \r\n                  .,!$#,      ..;$##!~---~;,:!::::!==!=*$*=$$         =$#####@###$$=-,-             \r\n                  ~-#$#,     .,~=#$*$~-~;!;;*!~:::;=*;:!!=##@###-    !$$#$##@@###$$=$~-.            \r\n                 --~#$$,     ,- -~*==-~:*=*!!*;*;;:=$*;::;!=#@#-,    ;$=#####@@##$$$$=!;;.          \r\n                 ~-;#$$,    -, -:.!$=~~:!=***=;*=**==*!:::~:!=$:   . !$=*#=*=@=##$$$$*!!:           \r\n                .~~:*=$!   -:.,~,,!#!~:;$$==##$$$#$$$!*!:;::;!*$.  ;*#$@,*$*=@-$#$$$$*;-            \r\n                ,;:;!$$=   ~~.-,.~@*:::!$=$###@@#####*:!=$!!;;*$$.  =$=$ !$$#$ *#$$$$;;,            \r\n                   ;:$$$: .:~:~.,=#=::!*=$####@###$=$$!*$$==**=$#$,*$#=!*$##$. *#$$$=:~             \r\n                    :;$$; ~;~~,-*#$=:!==$$####@###==$$=*$$$==$$$@@##$$$$##$$$.  #$$$=~~             \r\n                   .;:#$: ;;~..;@##=:*=$=$#$####$=$=$#$==$$$####@@#$=*=-==*=$-  $$$$;~:             \r\n                   .;-$$$-;~,..,*$=$===*$@#$##$$$==$=$##$##$$#=@$##$=$! ==*=$;  $$$$:~~             \r\n                    --;#$:~,.,,-:$$##$=$$######=##==$@###$==*#,,=##$$$. =$*$#$  $$$$~:              \r\n                    ,~:=$$,...--:$#$!*$$=#@###$****$###$$$=$=:  .=$$=$-,$#$=,== $$$#~:              \r\n                    ,~-=$= ...;*$$$$!*==#@###=$$****#$*=$$$==~    ,,~$$$@$#~ ., $$$*~;              \r\n                     --$$$!.,-,==*!$$***$#$@$*===***===$$$$$=:        *@#$$-    $$$!~:              \r\n                     :-!$$!.-,,~*#=#$**=#$$#=***=***##$*=$#=#:        ,#$#=    :$$=:~               \r\n                     ~~~$$$-,,,~!@$#===$#$$$****=**$$$=**$$=#:    ,:  ,===$~   !$$=~~               \r\n                      :~#$$-,,,~:$$#@#$#$$$$****==$$$*;*$$#$#:    ,$*-,#$$#=   !$$=~;               \r\n                     .:~$$$=.,-:*#=$=*==#$#=****=$$**!!*$$#$$:     :#$##$$.    !$$:~~               \r\n                    .~:,!$$$:~=!==*#$*=$$=#=****=$#$#$==$##$#:      ,*@##~     !$$~~                \r\n                    ,-:-;$=$*-!#=!*$#==#$$$=***==###$$#$$##$$~        ==#~     !$$,~                \r\n                   -~.~-~=$$$:~*#$$=$$===$==***=$##$==$$$##$$        :#$#-    .=$$-:                \r\n                  -;,,-~-=$$$$-:=$#$#$$#$$$=***=#$$===*!*###*        !#@==    ,$$#-:                \r\n                 ~!~.,-~,=$$$#!;=@#$#==$=$==**$###$$$=*!*=#@,       .##!      ,$$#-:                \r\n               ~:.,,,.-~,=$$$$#**#$$#=*#=$***=###$#$$$!!;!=#~       $#*       ,$$#,:                \r\n                  -,,.--,$$$$$##$#=*$#=#$$**=$$##$$$$=*!!*=$*      :$#.       ,$$#,~                \r\n                  -,,.--,$$$$$$###$*=$#$==**$#$$#$=$$$=*;!*=#:    ,=$$.       ~$$!,~                \r\n                 -,,,,~,:$#$$$$###=$###$=$$=#=*$#$=$$$==*;!*$#,   ,==$.       #$$!,~                \r\n                 ,,,,-;!**=$$$$###@###$#$#==$**$@#$$$#$=**;!!$~    !@$#=.     #$$;,,~               \r\n                .,,,,,--~!!!=$$$######$###$$***$###$$$$!;=!::=$    !##=       $$$!:;!!              ");
        }
        #region 바칼관련 매서드

        public void BakalHuman()
        {
            Console.Write("@@@@@@@@@@@@@@@@@*******************************************@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                  -                       @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                   :   ,.                 @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                   :~   :                 @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                    *,  ,;                @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                    :!   !.               @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.               -~!*. !;  -!               @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                  ,!=:*~!!=,              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                    * **;==~              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                   -=~==;*=:              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                   ~:=*=;;*;              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.                    !===*:!,              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.          ~ -;     -!;*;*!;.              @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.        --!=*!  ;*;:;:!:~~: .:            @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.       :$!***==*!*!:;!*:~;!-#$!~,         @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.       $=**=*=$*!!;;;;=*;;*==$$=!         @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.      ~$**=**$=!=!!!!;***=*!*==#$.        @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.      ##===*==!**;!!:!;!*==*;*=$$=        @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.      #$***!$=***~!!;;!,!:::::!=*$        @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.     !=$**===!=*;**;-~~:~.,;~~!*=$        @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.  .  *$#=*!$*=**~~~,,,~~~-~~~~~=$$=       @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. .~  *$$*=*$***!!:-~~,,:::~~~,,*=$;       @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. ., -=$$==*=**!*==!;:;:-,~~;-,~*==~  .    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. ..~!=$=*!!;***=====*!!;;;-:;;;==*  .:    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. ,,:!**=:~--!*!==**=!!;;::::;!===!  -!    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.,=-:!;:*::,,::;=====!;;;;::~:;**!$.~!;    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@:-!!;!~:*:;,,~;$$=*==**!****!!!*~:=:=!;    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@:*!!!:~:!;*;;~.*$====*!*=!!****;~:!==**    @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.!!!!~~::*:;,   ;====**=***!***;;;;*!**:   @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.~!,!~:::!!!,    ,====*=*******!;::!;*!;   @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.-! ;;::!:!:~     -$=**=**!****!;:~:=!*=-  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.;*~:;;;!*;:.     -=!**====**==$*~,-!!*=~  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.-*!~:::**~:      :;;~,-~;;!**=$*:--:!;*;  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. :!;-::;;;-     ;*!;:~,--~~-~**=!---;!*-  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. :!;~;**::     .$=$$$*=:!*==!*!=*;-,;**.  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. -!;!!!*:~.     *$$=$===**!*==:;*!~-:*=~  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. ;*!~~*;;:~,    *=**==*!==!;;-~!=*~~~!==  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. .*!-:;!;~-;.  .=*!=!;:~!~~~:!=$$=*:~;==  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. -*;!!:-,,~--  ;$$=*!-,,!**$==$$$==;:;**. @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@. ,,!~;~,,:---. *$$$=;!;!;**=##$$;;*;*;!=  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.  .!;;:,-;~:;.~==*$$;=$-*====$=$~**=$*:!  @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.  .;:~-~~~ **~===*~!!==;$$*;*==$*;;$$*;-- @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.   :;--;~!,*=$===!!!=$$=*!;;*==$:$-$***;:~@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.    !!!*=!$::====!;:;!;!!;;;====:$=====;;~@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.     :!=*=* ;====!:~:;-;!;:!=$=$.~$*==!*;.@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@.       .:.  !===!!;~:!!;!;;*=$=$  ,;!*::. @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@,            *==*;;;;;:~;;;;==$==-   .     @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@,           .===!;;:;;;;;;;!$$$$~;         @@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@,...........~===!;;;;!;;;;;*$$#=:*.........@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@,...........===*!!!;!;;;;;;$#*$:;*.........@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@-..........~=*=*!!!!::!;!;!$$***!*,........@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@-,,,,,,,,,~==****!;:;!!!!!==**!*=;,,,,,,,,,@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@~,,,,,,,,-==*****;;;!!!!!!$**=*=$-,,,,,,,,,@@@@@@@@@@@@@@@@@@@\r\n");
        }

        public void BakalDragon()
        {
            Console.Write("                                 ;*          ,=-                                \r\n                                 :=-         -=-                                \r\n                                 :*=         *=-                                \r\n                                 ;*=         *=-                                \r\n:....                            :*;!   .   =**-                             ...\r\n==$#=-~, ;~-~    .                !;=,  !  -$!:                     ,--~- ,-~*$$\r\n*=====$**#=*$::. ::,              *:$! :*-.*$!;              ,;~  ,;*==#$;*=$===\r\n$$=====$##$**=#$:.$!:             .*;$:!;;!$~;             .:!=.:=$#=*=###$====*\r\n$#$$$$######$===$##=**$-.        :~=**=$;=$#*!:,        .,$**=@#$$==$##########$\r\n*=***$==*=######@###=*=**~       -*-**=*!===~:*.      .:=*=**##########$***==*!=\r\n*===*$==*$$$$####@@#$$#$$$!       !*!;**;=!!!=:      ,*$$$#$$#@#####$$$$**=$***=\r\n!*=***=**$####=#@##$$**....       .=$*=*!!!=$!        ...**$$$#@@$=###$$===*****\r\n*==*====#@##@#@###$:                $****=**#                !####@@####$==$$=*=\r\n====##@@###$$#@##@;                ;$**=*=:*#:                *###@#$$##@####=**\r\n$$##@@@@#$$##@#$#:                :$!**;=;**!=-               .$#$#@#$$$##@@@#$$\r\n@@@@@$=*$$$#@@##:               -=:$~;!!=***~;;!               -###@@#$$$=#@@@@@\r\n@@##$==*$####@#:                :$!~;*=*==**~~;$,               ~#@@#@#$=*$*$#@@\r\n$===$====@@#@@*              . -$;~;;***;!*!::~!$                :#@##@#====$=$$\r\n*****==$#@####-              :;=;;:~~~~~;~~~-~:!;;;,              ~@##@@$=$==***\r\n*****=##@@#$#.             :.;*=:-~~~~!*==;~~~~~;$=;=              ##$#@@#$=****\r\n****=#@@#$=$#        .=   !=;=#;;~---;**==**~---;=$*;*   =.        ,#$=#@@@#****\r\n***=#@##$==$@       ,=;  .!:!$=:!!!;;;!!=*!;;;!!!=$=!:;.  #;.      ,@==$##@@#=**\r\n**=#@#$==*=$@      ,*#  ,;:!$$==**!**=======*;;;**$$*;;;. !$!      ,#$**=$#@@$=*\r\n*=#@#******$@     .$## .;*!##!==$=*==============;*#$*!*, ,##*     ,#=*****$@@#*\r\n=#@#****;!*$#.. ..@##~ .!=$@#=**===**!*==**!**==$*=#@#=*, .@##=.  .##=*!****=#@#\r\n#@#*!;;;;!*$#@=!#@###:~:=$###=*$===;;;;*=*;;;!=====$#$#=*~:@@#@#!~#@$=*;;!!!*=#@\r\n@#=!;;;;;;!$#@@########$=$$$#$$$!*=*;;;*=*;;;*=*;$$$=*=*=###########$*!;;;;;!*=#\r\n#*!;;;;;;;;$@*=$=*=###==!*==##$=***=***=!===*===!$$#=;!!**####**=#*#$!;;;;;;;!*$\r\n$!;;;;;;;;;;;!*****###*!:*;!#@#=!!=============!!$###===;!$#@#*****!;;;;;;;;;;;*\r\n!;;;;;;;;;;;!*****=###*;==**##===!*============!$=$@##$==:=#@$=*****;;;;;;;;;;;;\r\n;;;;;;;;;;;!******=$=$;*===$#@=*$=============*===#@@##$=*!=#$******!;;;;;;;;;;;\r\n;;;;;;;;;;!!*******$$!*===#####$==!==========*;=*###@@#$==*=#=******=*;;;;;;;;;;\r\n;;;;;;;;;!***!!!**=$#*==$###@##====!====!====!*=*####@##$==*#==*!!!**$!;;;;;;;;;\r\n~~::;:::!$$=$=!!!=$$#*==########**======*====*=**########===#$=*!!!!$$$*;:::;::~\r\n:~:;!!!*$$$#$#!;!$###$=$########====$==*=**====*=######@#$=####=;;;$##$$*!!!!;::\r\n:;;;;!*$$*=###=;=##$$$##@@@###,!#$$*========$*==#$;###@@@##$$$$#*;!##@#*$=!;;;;:\r\n::;!!=$$#=#######======$$##@=,  $#==**=====***=#$  !@##$$$======$=#$==##=$$!!!;:\r\n!!*=$$$##@$==$$$##$====$$$$$*,  ,=$$*==*=======*   ~$$$$$======$#=====#@#$$$==*!\r\n$$$$;~~=##$==*==#$====$$$$$$$~   ,*$========$=;     *$$$$$=====$$=====$@#!~;$$$=\r\n$...   .#$======$$====$$$$$#!     *$=========#:     :$$$$$$$==$#$======$*   ..,:\r\n     .-=#$=====$#@####$$$$=.     .=@#$======##!.     ,=$$$#####$======$$!.      \r\n .~~-===$$=======$#$$$$!;:     :.*####$===$####: :;   .;*$#$$#=======$#$==:-~-. \r\n ~##=$=$$#$======*#####:       =*$#####$==#####$!=-    -*####$=======$#$$==*#$, \r\n  !#$####$$=======$##@##~      $==$####$=$####$$#*      :####$$$==#$===####$#$, \r\n");
        }
        #endregion

        public void DungeonIn()
        {
            if (AN.playerPos_Y == AN.dungeon_1Pos_Y && AN.playerPos_X == AN.dungeon_1Pos_X)
            {
                Dungeon1_In();
            }
            if (AN.playerPos_Y == AN.dungeon_2Pos_Y && AN.playerPos_X == AN.dungeon_2Pos_X)
            {
                Dungeon2_In();
            }
            if (AN.playerPos_Y == AN.dungeon_3Pos_Y && AN.playerPos_X == AN.dungeon_3Pos_X)
            {
                Dungeon3_In();
            }
            if (AN.playerPos_Y == AN.bakalHousePos_Y && AN.playerPos_X == AN.bakalHousePos_X)
            {
                RaidIn();
            }

        }



        public void Dungeon1_In() //던전 1 입장시 배틀 로직
        {
            if (AN.userClass == 1)
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
                    Console.Write("Q = 일반공격    E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);
                    Console.SetCursorPosition(1, 36);
                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 37);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            CS.WeaponNomalAttack();
                            Thread.Sleep(300);

                            AN.mukwoodHp = AN.mukwoodHp - AN.playerDamege;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 38);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 39);
                            Console.Write("타우비스트는 체력이 {0} 만큼 남았다!", AN.mukwoodHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound =2;
                            CS.WeaponSkillSoundTrack();
                            CS.WeaponCutin();
                            AN.mukwoodHp = AN.mukwoodHp - (AN.playerDamege * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

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
                    Thread.Sleep(300);
                    //Console.ReadLine(); //입력후 넘기기

                    AN.playerHp = AN.playerHp - AN.mukwoodDamage;
                    Console.SetCursorPosition(1, 38);
                    Console.Write("타우비스트는 {0} 만큼 데미지를 주었다!", AN.mukwoodDamage);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    Console.SetCursorPosition(1, 39);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

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
            }  //여기까지가 웨펀 전투로직

            //여기부터 스핏 전투로직
            if (AN.userClass == 2)
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
                    Console.Write("Q = 일반공격    E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);
                    Console.SetCursorPosition(1, 36);
                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 37);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            AN.mukwoodHp = AN.mukwoodHp - AN.player2Damage;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 38);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.player2Damage);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 39);
                            Console.Write("타우비스트는 체력이 {0} 만큼 남았다!", AN.mukwoodHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound = 10;
                            CS.SpitFireSkill();
                            CS.SpitFireCutin();
                            AN.mukwoodHp = AN.mukwoodHp - (AN.player2Damage * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

                    if (AN.mukwoodHp <= 0) //플레이어가 이겼을 시
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 37);
                        Console.Write("타우비스트는 쓰러졌다!");
                        Thread.Sleep(300);
                        Console.Clear();
                        Console.SetCursorPosition(1, 37);
                        Console.Write("보상으로 공격력 10증가!\n보상으로 최대체력 30증가! ");
                        AN.player2Damage = AN.player2Damage + 10;
                        AN.player2DamageReset = AN.player2DamageReset + 10;
                        AN.player2Hp = AN.player2Hp + 30;
                        AN.player2MaxHp = AN.player2MaxHp + 30;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.mukwoodHp = 200; //다시 채력 채워주기
                        AN.playerPos_X +=1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;
                    }

                    Console.Clear();
                    MukWoodOutput();
                    Console.SetCursorPosition(1, 37);
                    Console.Write("타우비스트의 공격!");
                    Thread.Sleep(300);
                    //Console.ReadLine(); //입력후 넘기기

                    AN.player2Hp = AN.player2Hp - AN.mukwoodDamage;
                    Console.SetCursorPosition(1, 38);
                    Console.Write("타우비스트는 {0} 만큼 데미지를 주었다!", AN.mukwoodDamage);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    Console.SetCursorPosition(1, 39);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.player2Hp);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    if (AN.player2Hp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.mukwoodHp = 200; //다시 채력 채워주기
                        Console.ReadLine();
                        break;
                    }
                }
            }  //여기까지가 스핏 전투로직



        }


        public void Dungeon2_In() //던전 2 입장시 배틀 로직
        {
            if (AN.userClass == 1)
            {
                Console.SetCursorPosition(50, 20);
                Console.Write("골드 크라운이 지켜보고 있다.");
                Thread.Sleep(500);
                Console.Clear();

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

                    Console.SetCursorPosition(1, 43);
                    Console.Write("Q = 일반공격    E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 44);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            CS.WeaponNomalAttack();
                            Thread.Sleep(300);
                            AN.goldCrownHp = AN.goldCrownHp - AN.playerDamege;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 45);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 46);
                            Console.Write("골드크라운는 체력이 {0} 만큼 남았다!", AN.goldCrownHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound =2;
                            CS.WeaponSkillSoundTrack();
                            CS.WeaponCutin();
                            AN.goldCrownHp = AN.goldCrownHp - (AN.playerDamege * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

                    if (AN.goldCrownHp <= 0) //플레이어가 이겼을 시
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 43);
                        Console.Write("골드 크라운은 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 44);
                        Console.WriteLine("골드 크라운 : 드디어... 해방.. 되었..ㅇ..");
                        Console.Clear();
                        Console.SetCursorPosition(1, 45);
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
                    Console.SetCursorPosition(1, 43);
                    Console.Write("골드크라운의 공격!");
                    Console.ReadLine(); //입력후 넘기기

                    AN.playerHp = AN.playerHp - AN.goldCrownDamage;
                    Console.SetCursorPosition(1, 44);
                    Console.Write("골드크라운는 {0} 만큼 데미지를 주었다!", AN.goldCrownDamage);
                    Console.ReadLine(); //입력후 넘기기

                    Console.SetCursorPosition(1, 45);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                    Console.ReadLine(); //입력후 넘기기

                    if (AN.playerHp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.goldCrownHp = 500; //다시 채력 채워주기
                        Console.ReadLine();
                        break;
                    }
                }
            }



            //위에는 웨펀 전투 이 아래부터 스핏 전투로직

            if (AN.userClass == 2)
            {
                Console.SetCursorPosition(50, 20);
                Console.Write("골드 크라운이 지켜보고 있다.");
                Thread.Sleep(500);
                Console.Clear();

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

                    Console.SetCursorPosition(1, 43);
                    Console.Write("Q = 일반공격    E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 44);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            AN.goldCrownHp = AN.goldCrownHp - AN.player2Damage;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 45);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.player2Damage);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 46);
                            Console.Write("골드크라운는 체력이 {0} 만큼 남았다!", AN.goldCrownHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound = 10;
                            CS.SpitFireSkill();
                            CS.SpitFireCutin();
                            AN.goldCrownHp = AN.goldCrownHp - (AN.player2Damage * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

                    if (AN.goldCrownHp <= 0) //플레이어가 이겼을 시
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 43);
                        Console.Write("골드 크라운은 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 44);
                        Console.WriteLine("골드 크라운 : 드디어... 해방.. 되었..ㅇ..");
                        Console.Clear();
                        Console.SetCursorPosition(1, 45);
                        Console.Write("보상으로 공격력 30증가!\n보상으로 최대체력 80증가! ");
                        AN.player2Damage = AN.player2Damage + 30;
                        AN.player2DamageReset = AN.player2DamageReset + 30;
                        AN.player2Hp = AN.player2Hp + 80;
                        AN.player2MaxHp = AN.player2MaxHp + 80;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.goldCrownHp = 500; //다시 채력 채워주기
                        AN.playerPos_Y -=1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;
                    }

                    Console.Clear();
                    GoldCrownOutput();
                    Console.SetCursorPosition(1, 43);
                    Console.Write("골드크라운의 공격!");
                    Console.ReadLine(); //입력후 넘기기

                    AN.player2Hp = AN.player2Hp - AN.goldCrownDamage;
                    Console.SetCursorPosition(1, 44);
                    Console.Write("골드크라운는 {0} 만큼 데미지를 주었다!", AN.goldCrownDamage);
                    Console.ReadLine(); //입력후 넘기기

                    Console.SetCursorPosition(1, 45);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.player2Hp);
                    Console.ReadLine(); //입력후 넘기기

                    if (AN.player2Hp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.goldCrownHp = 500; //다시 채력 채워주기
                        Console.ReadLine();
                        break;
                    }
                }
            }       //스핏 골크 전투로직 끝


        }


        public void Dungeon3_In() //던전 3 입장시 배틀 로직
        {
            Console.SetCursorPosition(50, 20);
            Console.Write("갑자기 차원이 찢어지며 아스타로스가 나타단다");
            Thread.Sleep(500);
            Console.Clear();

            Console.SetCursorPosition(50, 21);
            Console.WriteLine("아스타로스 : 나의 왕을 뵙기까지 얼마 남지않았구나....");
            Thread.Sleep(1500);
            AstarosOutput();

            Console.SetCursorPosition(0, 0);

            Console.Clear();

            if (AN.userClass == 1)
            {

                while (true)
                {
                    Console.Clear();
                    AstarosOutput();

                    Console.SetCursorPosition(1, 53);
                    Console.Write("Q = 일반공격  E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 54);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            CS.WeaponNomalAttack();
                            Thread.Sleep(300);

                            AN.astarosHp = AN.astarosHp - AN.playerDamege;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 56);
                            Console.Write("골드크라운는 체력이 {0} 만큼 남았다!", AN.astarosHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound =2;
                            CS.WeaponSkillSoundTrack();
                            CS.WeaponCutin();
                            AN.astarosHp = AN.astarosHp - (AN.playerDamege * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

                    if (AN.astarosHp <= 0) //플레이어가 이겼을 시
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 54);
                        Console.Write("아스타로스가 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 55);
                        Console.WriteLine("아스타로스 : 혼돈의... 왕이시여...");
                        Console.Clear();
                        Console.SetCursorPosition(1, 56);
                        Console.Write("보상으로 공격력 100증가!\n보상으로 최대체력 200증가! ");
                        AN.playerDamege = AN.playerDamege + 100;
                        AN.playerDamegeReset = AN.playerDamegeReset + 100;
                        AN.playerHp = AN.playerHp + 200;
                        AN.playerMaxHp = AN.playerMaxHp + 200;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.astarosHp = 2000; //다시 채력 채워주기
                        AN.playerPos_X -=1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;
                    }

                    Console.Clear();
                    AstarosOutput();
                    Console.SetCursorPosition(1, 54);
                    Console.Write("아스타로스의 공격!");
                    Thread.Sleep(300);
                    //Console.ReadLine(); //입력후 넘기기

                    AN.playerHp = AN.playerHp - AN.astarosDamage;
                    Console.SetCursorPosition(1, 55);
                    Console.Write("아스타로스는 {0} 만큼 데미지를 주었다!", AN.astarosDamage);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    Console.SetCursorPosition(1, 56);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    if (AN.playerHp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.astarosHp = 2000; //다시 채력 채워주기
                        Console.ReadLine();
                        break;
                    }
                }
            }       //여기까지가 웨펀 전투로직


            if (AN.userClass == 2) //스핏 아스타로스 전투 로직
            {

                while (true)
                {
                    Console.Clear();
                    AstarosOutput();

                    Console.SetCursorPosition(1, 53);
                    Console.Write("Q = 일반공격  E = 필살기");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 54);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            AN.astarosHp = AN.astarosHp - AN.player2Damage;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.player2Damage);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 56);
                            Console.Write("골드크라운는 체력이 {0} 만큼 남았다!", AN.astarosHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();                            
                            AN.nowSound = 10;
                            CS.SpitFireSkill();
                            CS.SpitFireCutin();
                            AN.astarosHp = AN.astarosHp - (AN.player2Damage * 3);
                            AN.nowSound = 0;
                            break;

                        default:
                            Console.Write("잘못된 입력값입니다.");
                            continue;
                    }

                    if (AN.astarosHp <= 0) //플레이어가 이겼을 시
                    {
                        Console.Clear();
                        Console.SetCursorPosition(1, 54);
                        Console.Write("아스타로스가 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 55);
                        Console.WriteLine("아스타로스 : 혼돈의... 왕이시여...");
                        Console.Clear();
                        Console.SetCursorPosition(1, 56);
                        Console.Write("보상으로 공격력 100증가!\n보상으로 최대체력 200증가! ");
                        AN.player2Damage = AN.player2Damage + 100;
                        AN.player2DamageReset = AN.player2DamageReset + 100;
                        AN.player2Hp = AN.player2Hp + 200;
                        AN.player2MaxHp = AN.player2MaxHp + 200;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.astarosHp = 2000; //다시 채력 채워주기
                        AN.playerPos_X -=1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;
                    }

                    Console.Clear();
                    AstarosOutput();
                    Console.SetCursorPosition(1, 54);
                    Console.Write("아스타로스의 공격!");
                    Thread.Sleep(300);
                    //Console.ReadLine(); //입력후 넘기기

                    AN.player2Hp = AN.player2Hp - AN.astarosDamage;
                    Console.SetCursorPosition(1, 55);
                    Console.Write("아스타로스는 {0} 만큼 데미지를 주었다!", AN.astarosDamage);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    Console.SetCursorPosition(1, 56);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.player2Hp);
                    //Console.ReadLine(); //입력후 넘기기
                    Thread.Sleep(300);

                    if (AN.player2Hp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.astarosHp = 2000; //다시 채력 채워주기
                        Console.ReadLine();
                        break;
                    }
                }
            }




        }

        public void RaidIn() //바칼레이드 전투 로직
        {
            Console.SetCursorPosition(1, 55);
            AN.themeCount = 1;
            CS.BakalMainTheme();
            AN.themeCount = 2;
            Console.Write("엄청난 열기에 숨이 차기 시작합니다...");
            Thread.Sleep(2000);
            Console.SetCursorPosition(1, 1);
            if (AN.bakalMeet == 0) //바칼 첫조우 연출
            {
                AN.bakalMeet +=1;
                CS.BakalFirstMeet();
                CS.BakalIntro();
            }

            if (AN.userClass == 1)
            {

                while (AN.bakalPhase == 1)
                {
                    AN.playerDamege = AN.playerDamegeReset;
                    Console.Clear();
                    BakalHuman();

                    Console.SetCursorPosition(1, 54);
                    Console.Write("Q = 일반공격  E = 필살기  Z : 플로  X : 이리네");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            CS.WeaponNomalAttack();
                            Thread.Sleep(300);

                            AN.bakalHp = AN.bakalHp - AN.playerDamege;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 56);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 57);
                            Console.Write("바칼는 체력이 {0} 만큼 남았다!", AN.bakalHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound =2;
                            CS.WeaponSkillSoundTrack();
                            CS.WeaponCutin();
                            AN.bakalHp = AN.bakalHp - (AN.playerDamege * 3);
                            AN.nowSound = 0;
                            BakalHuman();

                            break;

                        case ConsoleKey.Z:
                            Console.Clear();
                            AN.nowSound = 1;
                            CS.FloSoundTrack();
                            CS.FloCutin();
                            AN.playerDamege = AN.playerDamege *2;
                            Console.Clear();
                            BakalHuman();
                            AN.nowSound = 0;
                            continue;

                        case ConsoleKey.X:
                            Console.Clear();
                            AN.nowSound = 3;
                            CS.IrineSoundTrack();
                            CS.IrineCutin();
                            AN.playerHp = AN.playerMaxHp;
                            Console.Clear();
                            BakalHuman();
                            AN.nowSound = 0;
                            continue;

                    }

                    if (AN.bakalHp <= 5000 && AN.bakalPhase ==1)
                    {
                        AN.bakalPhase = 2;
                        CS.BakalPhase2Meet();
                        CS.BakalPhase2Intro();
                        continue;
                    }


                    Console.Clear();
                    BakalHuman();
                    Console.SetCursorPosition(1, 55);
                    Console.Write("바칼의 공격!");
                    Thread.Sleep(300);

                    CS.BakalNomalAttack();
                    Thread.Sleep(100);

                    AN.playerHp = AN.playerHp - AN.bakalDamage;
                    Console.SetCursorPosition(1, 56);
                    Console.Write("바칼은 {0} 만큼 데미지를 주었다!", AN.bakalDamage);
                    Thread.Sleep(300);

                    Console.SetCursorPosition(1, 57);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                    Thread.Sleep(300);

                    if (AN.playerHp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.playerDamege = AN.playerDamegeReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine();
                        break;
                    }



                } //1페 바칼과의 전투

                while (AN.bakalPhase == 2) //2페이즈 바칼과의 전투
                {
                    Console.Clear();
                    BakalDragon();
                    AN.bakalphase2Atk = rand.Next(0, 100);
                    if (AN.bakalHp <= 0) //바칼 처치시
                    {

                        Console.Clear();
                        Console.SetCursorPosition(1, 54);
                        Console.Write("바칼이 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 55);
                        Console.Write("바칼 : 날카롭구나....");
                        Console.SetCursorPosition(1, 56);
                        Console.Write("바칼 : 이제 그 칼날로 힐더를 꿰뚫어라!");
                        Console.Clear();
                        Console.SetCursorPosition(1, 56);
                        Console.Write("보상으로 공격력 3000증가!\n보상으로 최대체력 5000증가! ");
                        AN.playerDamege = AN.playerDamege + 3000;
                        AN.playerDamegeReset = AN.playerDamegeReset + 3000;
                        AN.playerHp = AN.playerHp + 5000;
                        AN.playerMaxHp = AN.playerMaxHp + 5000;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.playerDamege = AN.playerDamegeReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;

                    }

                    Console.SetCursorPosition(1, 54);
                    Console.Write("Q = 일반공격    E = 필살기  Z : 플로  X : 이리네");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            CS.WeaponNomalAttack();
                            Thread.Sleep(300);

                            AN.bakalHp = AN.bakalHp - AN.playerDamege;
                            Thread.Sleep(300);
                            AN.playerDamege = AN.playerDamegeReset;
                            Console.SetCursorPosition(1, 56);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.playerDamege);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 57);
                            Console.Write("바칼는 체력이 {0} 만큼 남았다!", AN.bakalHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound =2;
                            CS.WeaponSkillSoundTrack();
                            CS.WeaponCutin();
                            AN.bakalHp = AN.bakalHp - (AN.playerDamege * 3);
                            AN.playerDamege = AN.playerDamegeReset;
                            AN.nowSound = 0;
                            break;

                        case ConsoleKey.Z:
                            Console.Clear();
                            AN.nowSound = 1;
                            CS.FloSoundTrack();
                            CS.FloCutin();
                            AN.playerDamege = AN.playerDamege *2;
                            Console.Clear();
                            BakalDragon();
                            AN.nowSound = 0;
                            continue;

                        case ConsoleKey.X:
                            Console.Clear();
                            AN.nowSound = 3;
                            CS.IrineSoundTrack();
                            CS.IrineCutin();
                            AN.playerHp = AN.playerMaxHp;
                            Console.Clear();
                            BakalDragon();
                            AN.nowSound = 0;
                            continue;

                    }


                    if (AN.bakalphase2Atk < 50) //if(AN.bakalphase2Atk < 97)  //test if(AN.bakalphase2Atk < 50)
                    {
                        //바칼이 공격할턴
                        Console.Clear();
                        BakalDragon();
                        Console.SetCursorPosition(1, 55);
                        Console.Write("바칼의 공격!");
                        Thread.Sleep(300);

                        CS.BakalPhase2NomalAttack();
                        Thread.Sleep(300);

                        AN.playerHp = AN.playerHp - AN.bakalDamage;
                        Console.SetCursorPosition(1, 56);
                        Console.Write("바칼은 {0} 만큼 데미지를 주었다!", AN.bakalDamage);
                        //Console.ReadLine(); //입력후 넘기기
                        Thread.Sleep(300);

                        Console.SetCursorPosition(1, 57);
                        Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.playerHp);
                        //Console.ReadLine(); //입력후 넘기기
                        Thread.Sleep(300);
                    }

                    if (AN.bakalphase2Atk >= 50) //바칼 필살기  //if(AN.bakalphase2Atk >= 98)  //test  if(AN.bakalphase2Atk >= 50)
                    {
                        Console.Clear();
                        CS.BakalSkilltrack();
                        CS.BakalPhase2Skill();
                        Console.Clear();
                        AN.playerHp = AN.playerHp - (AN.bakalDamage *2);
                        Thread.Sleep(1000);
                        BakalDragon();


                    }

                    if (AN.playerHp <= 0) //패배조건
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.playerHp = AN.playerMaxHp; //플레이어 체력 회복
                        AN.playerDamege = AN.playerDamegeReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine();
                        break;
                    }


                }   //바칼 2페 while끝


   
            }

            //여기부터 스핏 바칼 전투로직

            if (AN.userClass == 2)
            {

                while (AN.bakalPhase == 1)
                {
                    AN.player2Damage = AN.player2DamageReset;
                    Console.Clear();
                    BakalHuman();

                    Console.SetCursorPosition(1, 54);
                    Console.Write("Q = 일반공격  E = 필살기  Z : 플로  X : 이리네");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            AN.bakalHp = AN.bakalHp - AN.player2Damage;
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 56);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.player2Damage);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 57);
                            Console.Write("바칼는 체력이 {0} 만큼 남았다!", AN.bakalHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();
                            AN.nowSound = 10;
                            CS.SpitFireSkill();
                            CS.SpitFireCutin();
                            AN.bakalHp = AN.bakalHp - (AN.player2Damage * 3);
                            AN.nowSound = 0;
                            BakalHuman();

                            break;

                        case ConsoleKey.Z:
                            Console.Clear();
                            AN.nowSound = 1;
                            CS.FloSoundTrack();
                            CS.FloCutin();
                            AN.player2Damage = AN.player2Damage *2;
                            Console.Clear();
                            BakalHuman();
                            AN.nowSound = 0;
                            continue;

                        case ConsoleKey.X:
                            Console.Clear();
                            AN.nowSound = 3;
                            CS.IrineSoundTrack();
                            CS.IrineCutin();
                            AN.player2Hp = AN.player2MaxHp;
                            Console.Clear();
                            BakalHuman();
                            AN.nowSound = 0;
                            continue;

                    }

                    if (AN.bakalHp <= 5000 && AN.bakalPhase ==1)
                    {
                        AN.bakalPhase = 2;
                        CS.BakalPhase2Meet();
                        CS.BakalPhase2Intro();
                        continue;
                    }


                    Console.Clear();
                    BakalHuman();
                    Console.SetCursorPosition(1, 55);


                    Console.Write("바칼의 공격!");
                    Thread.Sleep(300);             

                    CS.BakalNomalAttack();
                    Thread.Sleep(100);

                    AN.player2Hp = AN.player2Hp - AN.bakalDamage;
                    Console.SetCursorPosition(1, 56);
                    Console.Write("바칼은 {0} 만큼 데미지를 주었다!", AN.bakalDamage);                    
                    Thread.Sleep(300);
                    Console.SetCursorPosition(1, 57);
                    Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.player2Hp);
                    
                    Thread.Sleep(300);

                    if (AN.player2Hp <= 0)
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.player2Damage = AN.player2DamageReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine();
                        break;
                    }



                } //1페 바칼과의 전투

                while (AN.bakalPhase == 2) //2페이즈 바칼과의 전투
                {
                    Console.Clear();
                    BakalDragon();
                    AN.bakalphase2Atk = rand.Next(0, 100);
                    if (AN.bakalHp <= 0) //바칼 처치시
                    {

                        Console.Clear();
                        Console.SetCursorPosition(1, 54);
                        Console.Write("바칼이 쓰러졌다!");
                        Thread.Sleep(500);

                        Console.SetCursorPosition(1, 55);
                        Console.Write("바칼 : 날카롭구나....");
                        Console.SetCursorPosition(1, 56);
                        Console.Write("바칼 : 이제 그 칼날로 힐더를 꿰뚫어라!");
                        Thread.Sleep(2000);  
                        Console.Clear();
                        Console.SetCursorPosition(1, 56);
                        Console.Write("보상으로 공격력 3000증가!\n보상으로 최대체력 5000증가! ");
                        AN.player2Damage = AN.player2Damage + 3000;
                        AN.player2DamageReset = AN.player2DamageReset + 3000;
                        AN.player2Hp = AN.player2Hp + 5000;
                        AN.player2MaxHp = AN.player2MaxHp + 5000;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.player2Damage = AN.player2DamageReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine(); //입력후 반복문 탈출
                        break;

                    }

                    Console.SetCursorPosition(1, 54);
                    Console.Write("Q = 일반공격    E = 필살기  Z : 플로  X : 이리네");
                    AN.playerBattleInput = Console.ReadKey(true);


                    switch (AN.playerBattleInput.Key)
                    {
                        case ConsoleKey.Q:
                            Console.SetCursorPosition(1, 55);
                            Console.Write("플레이어의 공격!");
                            AN.playerRageCount +=1;

                            
                            AN.bakalHp = AN.bakalHp - AN.player2Damage;
                            Thread.Sleep(300);
                            AN.player2Damage = AN.player2DamageReset;
                            Console.SetCursorPosition(1, 56);
                            Console.Write("플레이어는 {0} 만큼 데미지를 주었다!", AN.player2Damage);
                            //입력후 넘기기
                            Thread.Sleep(300);

                            Console.SetCursorPosition(1, 57);
                            Console.Write("바칼는 체력이 {0} 만큼 남았다!", AN.bakalHp);
                            //Console.ReadLine(); //입력후 넘기기
                            Console.SetCursorPosition(1, 1);
                            Thread.Sleep(300);
                            break;

                        case ConsoleKey.E:
                            Console.Clear();                            
                            AN.nowSound = 10;
                            CS.SpitFireSkill();
                            CS.SpitFireCutin();
                            AN.bakalHp = AN.bakalHp - (AN.player2Damage * 3);
                            AN.player2Damage = AN.player2DamageReset;
                            AN.nowSound = 0;
                            break;

                        case ConsoleKey.Z:
                            Console.Clear();
                            AN.nowSound = 1;
                            CS.FloSoundTrack();
                            CS.FloCutin();
                            AN.player2Damage = AN.player2Damage *2;
                            Console.Clear();
                            BakalDragon();
                            AN.nowSound = 0;
                            continue;

                        case ConsoleKey.X:
                            Console.Clear();
                            AN.nowSound = 3;
                            CS.IrineSoundTrack();
                            CS.IrineCutin();
                            AN.player2Hp = AN.player2MaxHp;
                            Console.Clear();
                            BakalDragon();
                            AN.nowSound = 0;
                            continue;

                    }


                    if (AN.bakalphase2Atk < 50) //if(AN.bakalphase2Atk < 97)  //test if(AN.bakalphase2Atk < 50)
                    {
                        //바칼일반공격 공격할턴
                        Console.Clear();
                        BakalDragon();
                        Console.SetCursorPosition(1, 55);
                        Console.Write("바칼의 공격!");
                        Thread.Sleep(300);

                        CS.BakalPhase2NomalAttack();
                        Thread.Sleep(300);

                        AN.player2Hp = AN.player2Hp - AN.bakalDamage;
                        Console.SetCursorPosition(1, 56);
                        Console.Write("바칼은 {0} 만큼 데미지를 주었다!", AN.bakalDamage);
                        //Console.ReadLine(); //입력후 넘기기
                        Thread.Sleep(300);

                        Console.SetCursorPosition(1, 57);
                        Console.Write("플레이어는 체력이 {0} 만큼 남았다!", AN.player2Hp);
                        //Console.ReadLine(); //입력후 넘기기
                        Thread.Sleep(300);
                    }

                    if (AN.bakalphase2Atk >= 50) //바칼 필살기  //if(AN.bakalphase2Atk >= 98)  //test  if(AN.bakalphase2Atk >= 50)
                    {
                        Console.Clear();
                        CS.BakalSkilltrack();
                        CS.BakalPhase2Skill();
                        Console.Clear();
                        AN.player2Hp = AN.player2Hp - (AN.bakalDamage *2);
                        Thread.Sleep(1000);
                        BakalDragon();


                    }

                    if (AN.player2Hp <= 0) //패배조건
                    {
                        Console.Clear();

                        Console.WriteLine("당신은 쓰러졌다....");
                        AN.playerPos_X =8;
                        AN.playerPos_Y =8;
                        AN.player2Hp = AN.player2MaxHp; //플레이어 체력 회복
                        AN.player2Damage = AN.player2DamageReset; //공격력수지 정상화
                        AN.bakalHp = 10000; //다시 채력 채워주기
                        AN.bakalMeet = 0;
                        AN.bakalPhase = 1;
                        Console.ReadLine();
                        break;
                    }


                }   //바칼 2페 while끝



            }




        }
    }
}
