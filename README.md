# BatchGuard
Batch file obfuscation tool made in C#. Features include: string substitution, string splitting, adding UTF-16 byte-order-mark, and more. BatchGuard also has antivirus evasion capabilities for malicious batch files.

Currently incomplete and many optimisations need to be made.

## User interface
![image](https://media.discordapp.net/attachments/955850893113298957/956116234016014366/unknown.png)

## Obfuscation results

Input:
```bat
@echo off
echo hello world
echo hello world > hi.txt
echo %userprofile%
pause
```

Output:
```bat
਍敀档⁯景൦挊獬਍敳汴捯污攠慮汢摥汥祡摥硥慰獮潩൮猊瑥唠穕塗楌癒㵓䩂乇䅆婈䵗䭏塃卖偙啔䑅兌䥒਍敳⁴䙗睹䝫獷䭶礽穮癡灪浫桷牵煣獦杩硢整摯൬猊瑥删瑘婢汲癡㵦㤰㈶㌸ㄵ㐷਍敳⁴戢桪䕧摇䵧㵉圥祆歷睇癳㩋㉾ⰳ┱圥祆歷睇癳㩋ㅾⰲ┱圥祆歷睇癳㩋㉾ⰵ┱圥祆歷睇癳㩋㉾ⰴ┱•☦猠瑥∠捱呓穢硣祕┽䙗睹䝫獷䭶縺㔲ㄬ┥䙗睹䝫獷䭶縺㌲ㄬ‥圥祆歷睇癳㩋㥾ㄬ∥਍敳⁴漢楈晵晔啇㵖圥祆歷睇癳㩋㉾ⰲ┱•☦猠瑥∠楉啊婈故䥭┽䙗睹䝫獷䭶縺㌲ㄬ‥圥祆歷睇癳㩋㉾ⰳ┱圥祆歷睇癳㩋ㅾⰵ┱•☦猠瑥∠婚䅄硯佮浅‽‾圥祆歷睇癳㩋ㅾⰰ┱•☦猠瑥∠杸杣䉹睕兴┽䙗睹䝫獷䭶縺㌲ㄬ┥䙗睹䝫獷䭶縺㈱ㄬ┥䙗睹䝫獷䭶縺㔲ㄬ┥䙗睹䝫獷䭶縺㐲ㄬ∥਍敳⁴䐢癴䡌杮敖㵴┠䙗睹䝫獷䭶縺〱ㄬ┥䙗睹䝫獷䭶縺㈲ㄬ┥䙗睹䝫獷䭶縺㔲ㄬ∥☠…敳⁴刢楮剉换歘㵥圥祆歷睇癳㩋㉾ⰲ┱圥祆歷睇癳㩋ㅾⰳ┱圥祆歷睇癳㩋ㅾⰰ┱圥祆歷睇癳㩋㉾ⰳ┱•☦猠瑥∠杓摌瑨坫䕍┽䙗睹䝫獷䭶縺ㄲㄬ∥਍敳⁴䘢坤杈湗煤㵫圥祆歷睇癳㩋㙾ㄬ┥䙗睹䝫獷䭶縺ⰳ┱圥祆歷睇癳㩋ㅾⰱ┱圥祆歷睇癳㩋ㅾⰶ┱•☦猠瑥∠乺南晩祅污┽䙗睹䝫獷䭶縺㈲ㄬ┥䙗睹䝫獷䭶縺㌱ㄬ┥䙗睹䝫獷䭶縺〱ㄬ┥䙗睹䝫獷䭶縺㌲ㄬ∥☠…敳⁴瀢䭥呴穄䕯㵓圥祆歷睇癳㩋㉾ⰲ┱圥祆歷睇癳㩋ㅾⰳ┱圥祆歷睇癳㩋ㅾⰰ┱圥祆歷睇癳㩋㉾ⰳ┱•☦猠瑥∠慷楱敺歱煩∽਍敳⁴礢敵捖敫慙㵱┠䙗睹䝫獷䭶縺〱ㄬ┥䙗睹䝫獷䭶縺㈲ㄬ┥䙗睹䝫獷䭶縺㔲ㄬ∥਍敳⁴䰢䉣䍧楹牦㵫┠獕剥牰䙯䱉╥ഢ猊瑥∠卢奖橷歪奭┽䙗睹䝫獷䭶縺㜱ㄬ⸥圥祆歷睇癳㩋㉾ⰱ┱圥祆歷睇癳㩋㉾ⰰ┱ഢ猊瑥∠䵐煊異元䉭䀽圥祆歷睇癳㩋㉾ⰲ┱圥祆歷睇癳㩋ㅾⰳ┱圥祆歷睇癳㩋ㅾⰰ┱•☦猠瑥∠偢煁硘桱坲∽☠…敳⁴䜢䝍䑃䕨歙㵭圥祆歷睇癳㩋ㅾⰵ┱•☦猠瑥∠晦剔牐敄䉥┽䙗睹䝫獷䭶縺㔲ㄬ┥䙗睹䝫獷䭶縺㌲ㄬ‥圥祆歷睇癳㩋㥾ㄬ∥਍倥䩍灱䍵浑╂䤥䩩䡕䕚浥╉䜥䝍䑃䕨歙╭਍瀥䭥呴穄䕯╓礥敵捖敫慙╱春呦偒䑲敥╂戥桪䕧摇䵧╉戥䅐塱煸牨╗਍稥坎楓䕦慹╬䐥癴䡌杮敖╴焥卣扔捺啸╹砥捧祧啂瑷║娥䑚潁湸䕏╭戥噓睙橪浫╙匥䱧桤歴䵗╅਍別楮剉换歘╥䰥䉣䍧楹牦╫਍䘥坤杈湗煤╫漥楈晵晔啇╖਍眥煡穩煥楫╱਍਍
```

Output without UTF-16 BOM:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set XirkufKEKZ=FGTUBXKHPRWOEDSCAJVLYNQZIM
set jfIdJnfvIy=zxmaewldhqsuripogbvkytcjfn
set lFUBwuWile=6594180273
set "ivPxswVUCf=%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~22,1%%jfIdJnfvIy:~8,1%%jfIdJnfvIy:~15,1%"
set "tZdHzAskaJ=%jfIdJnfvIy:~6,1%%jfIdJnfvIy:~15,1% %jfIdJnfvIy:~5,1%" && set "beIhUnzHSE=%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~22,1%%jfIdJnfvIy:~8,1%%jfIdJnfvIy:~15,1%" && set "GAVwekmhgh=%jfIdJnfvIy:~24,1%"
set "nFWUsEHkit=" && set "DcMObNBXeq=%jfIdJnfvIy:~15,1%%jfIdJnfvIy:~12,1%%jfIdJnfvIy:~6,1%%jfIdJnfvIy:~7,1%" && set "nTDZnEnpIN=%jfIdJnfvIy:~21,1%" && set "zmFuJOtkQE=%jfIdJnfvIy:~15,1%%jfIdJnfvIy:~12,1%%jfIdJnfvIy:~6,1%%jfIdJnfvIy:~7,1%" && set "xWdwQHhUmz= %UserPROfile%" && set "JbQPhYFbER= > %jfIdJnfvIy:~8,1%"
set "QcTfIwTkqB= %jfIdJnfvIy:~8,1%%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~6,1%"
set "ZhVsjOTmlG=@%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~22,1%%jfIdJnfvIy:~8,1%" && set "YFUSlGqTXs="
set "BhfXJPGyUq=%jfIdJnfvIy:~13,1%.%jfIdJnfvIy:~21,1%%jfIdJnfvIy:~1,1%"
set "vtlHgfLUOK= %jfIdJnfvIy:~8,1%%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~6,1%" && set "IYdeLUTbpU=%jfIdJnfvIy:~15,1% %jfIdJnfvIy:~15,1%%jfIdJnfvIy:~24,1%" && set "KPSalWUoEi=%jfIdJnfvIy:~4,1%%jfIdJnfvIy:~22,1%%jfIdJnfvIy:~8,1%%jfIdJnfvIy:~15,1%"
set "MHaaKwkWfB=%jfIdJnfvIy:~6,1%%jfIdJnfvIy:~15,1% %jfIdJnfvIy:~5,1%" && set "xTKatllkCe=%jfIdJnfvIy:~4,1%"
set "yVAUeRfeUW=%jfIdJnfvIy:~14,1%%jfIdJnfvIy:~3,1%%jfIdJnfvIy:~11,1%%jfIdJnfvIy:~10,1%"
%ZhVsjOTmlG%%IYdeLUTbpU%%GAVwekmhgh%
%KPSalWUoEi%%QcTfIwTkqB%%MHaaKwkWfB%%zmFuJOtkQE%%YFUSlGqTXs%
%beIhUnzHSE%%vtlHgfLUOK%%tZdHzAskaJ%%DcMObNBXeq%%JbQPhYFbER%%BhfXJPGyUq%%nTDZnEnpIN%
%ivPxswVUCf%%xWdwQHhUmz%
%yVAUeRfeUW%%xTKatllkCe%
%nFWUsEHkit%
```

Output with string substitution only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set NoFlYJvmUP=8971042356
set qXBtayGunA=EKNGOVLWYCPZRXMAJSBHQUDFTI
set orWtyNjoDk=pjzfvyaqnsxgwrtoceukblimdh
@%orWtyNjoDk:~17,1%%orWtyNjoDk:~16,1%%orWtyNjoDk:~25,1%%orWtyNjoDk:~15,1% %orWtyNjoDk:~15,1%%orWtyNjoDk:~3,1%%orWtyNjoDk:~3,1%
%orWtyNjoDk:~17,1%%orWtyNjoDk:~16,1%%orWtyNjoDk:~25,1%%orWtyNjoDk:~15,1% %orWtyNjoDk:~25,1%%orWtyNjoDk:~17,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~15,1% %orWtyNjoDk:~12,1%%orWtyNjoDk:~15,1%%orWtyNjoDk:~13,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~24,1%
%orWtyNjoDk:~17,1%%orWtyNjoDk:~16,1%%orWtyNjoDk:~25,1%%orWtyNjoDk:~15,1% %orWtyNjoDk:~25,1%%orWtyNjoDk:~17,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~15,1% %orWtyNjoDk:~12,1%%orWtyNjoDk:~15,1%%orWtyNjoDk:~13,1%%orWtyNjoDk:~21,1%%orWtyNjoDk:~24,1% > %orWtyNjoDk:~25,1%%orWtyNjoDk:~22,1%.%orWtyNjoDk:~14,1%%orWtyNjoDk:~10,1%%orWtyNjoDk:~14,1%
%orWtyNjoDk:~17,1%%orWtyNjoDk:~16,1%%orWtyNjoDk:~25,1%%orWtyNjoDk:~15,1% %uSErprOfIlE%
%orWtyNjoDk:~0,1%%orWtyNjoDk:~6,1%%orWtyNjoDk:~18,1%%orWtyNjoDk:~9,1%%orWtyNjoDk:~17,1%
```

Output with string splitting only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set "CrUOiqVUys= %userprofile%" && set "kfnRPZNtko=@ech" && set "XFnkFVdErS=orld" && set "KpXQyIakDR=i.tx"
set "vxIWhchUqw=o of" && set "WjxvfoUSWT= > h" && set "yvzFmsyLeE= hel" && set "lycJcaSihv=lo w" && set "qJDxunrKaB=echo"
set "yxXazymkOM=echo" && set "ldTIQTEiWv= hel"
set "LjuBAzyEeF=paus" && set "VCNLYdpyEG=" && set "efvnEdwiYL=echo" && set "GCKNXEqPxl=lo w"
set "yqptIREiba=e"
set "pSCAsagkee=t"
set "gIKglsBkmo=f" && set "wxpJwNvoEW=orld"
%kfnRPZNtko%%vxIWhchUqw%%gIKglsBkmo%
%qJDxunrKaB%%ldTIQTEiWv%%GCKNXEqPxl%%wxpJwNvoEW%
%efvnEdwiYL%%yvzFmsyLeE%%lycJcaSihv%%XFnkFVdErS%%WjxvfoUSWT%%KpXQyIakDR%%pSCAsagkee%
%yxXazymkOM%%CrUOiqVUys%
%LjuBAzyEeF%%yqptIREiba%
%VCNLYdpyEG%
```

## Antivirus Evasion Status

A test has been done using a malicious batch script found [here](https://github.com/xiaoxiaoleo/pentest-script/blob/master/PrivilegeEscalation/Windows/jollyfrogs-batch.bat).

Without obfuscation:
![image](https://media.discordapp.net/attachments/955850893113298957/956110042355093545/unknown.png)

With string substitution + string splitting:
![image](https://media.discordapp.net/attachments/955850893113298957/956110326548549632/unknown.png)
Note: Kaspersky consistently flags batch files using string substitution for obfuscation.

With string splitting:
![image](https://media.discordapp.net/attachments/955850893113298957/956110706674110474/unknown.png?width=1440&height=574)

UTF-16 BOM does not affect detection results as it is more or less just an encoding trick to confuse text editors.
