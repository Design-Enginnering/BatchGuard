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
਍敀档⁯景൦挊獬਍敳汴捯污攠慮汢摥汥祡摥硥慰獮潩൮猊瑥渠灧汖睍ぶ㵵浮歪晤扳睩潨杣汵穹灱硶敡牴਍敳⁴ㄳ獖䙘䅅啅吽䡋䉅偏光䝁卆婃乒䵌啙坄䩖൘猊瑥ㄠ瑂杳䱅ぇ㴲㘸㤱㈵㐰㜳਍敳⁴圢㤴䄷兔敯㵅┠杮噰䵬癷田縺〱ㄬ┥杮噰䵬癷田縺㌲ㄬ┥杮噰䵬癷田縺㔱ㄬ∥਍敳⁴稢䑧㕙汪啎㵵渥灧汖睍ぶ㩵ㅾⰵ┱渥灧汖睍ぶ㩵ㅾⰱ┱┠杮噰䵬癷田縺ⰹ┱ഢ猊瑥∠婨畳㑉㠷䕃┽杮噰䵬癷田縺㔱ㄬ┥杮噰䵬癷田縺ㄱㄬ‥渥灧汖睍ぶ㩵㥾ㄬ∥਍敳⁴䰢㝘䡵慔䐶㴰╀杮噰䵬癷田縺㌲ㄬ┥杮噰䵬癷田縺㈱ㄬ┥杮噰䵬癷田縺〱ㄬ∥਍敳⁴欢佮䠳䴶堰㴰┠杮噰䵬癷田縺〱ㄬ┥杮噰䵬癷田縺㌲ㄬ┥杮噰䵬癷田縺㔱ㄬ∥਍敳⁴猢牓婣慗䌵㵕渥灧汖睍ぶ㩵㕾ㄬ∥਍敳⁴㤢案㈹桩晨㵫渥灧汖睍ぶ㩵ㅾⰱ┱┠杮噰䵬癷田縺ㄱㄬ┥杮噰䵬癷田縺ⰵ┱ഢ猊瑥∠噎朶瘲㙥歒┽杮噰䵬癷田縺ㄱㄬ┥杮噰䵬癷田縺㔲ㄬ┥杮噰䵬癷田縺㔱ㄬ┥杮噰䵬癷田縺ⰴ┱ഢ猊瑥∠慧捍㍺礷は┽杮噰䵬癷田縺ㄱㄬ┥杮噰䵬癷田縺㔲ㄬ┥杮噰䵬癷田縺㔱ㄬ┥杮噰䵬癷田縺ⰴ┱ഢ猊瑥∠戸㑘㘸婦歎┽杮噰䵬癷田縺㐲ㄬ∥਍敳⁴眢杤䙑獏堸㵅㸠┠杮噰䵬癷田縺〱ㄬ∥਍敳⁴䬢㥏㑲硵唲㵡渥灧汖睍ぶ㩵㉾ⰳ┱渥灧汖睍ぶ㩵ㅾⰲ┱渥灧汖睍ぶ㩵ㅾⰰ┱渥灧汖睍ぶ㩵ㅾⰱ┱ഢ猊瑥∠㙚㙭㑰歱㕋┽杮噰䵬癷田縺㌲ㄬ┥杮噰䵬癷田縺㈱ㄬ┥杮噰䵬癷田縺〱ㄬ┥杮噰䵬癷田縺ㄱㄬ∥਍敳⁴戢捋䱢䡢打㵕渥灧汖睍ぶ㩵ㅾⰹ┱渥灧汖睍ぶ㩵㉾ⰲ┱渥灧汖睍ぶ㩵ㅾⰴ┱渥灧汖睍ぶ㩵㙾ㄬ∥਍敳⁴瀢⼴卷丯ㅶ㵅ഢ猊瑥∠㡒䄰唸㡁〸┽杮噰䵬癷田縺㌲ㄬ∥਍敳⁴⼢䉅㡬䵺乬㵅┠单剥牐䙯䱉╅ഢ猊瑥∠㉮㡏券䵧䕌┽杮噰䵬癷田縺ⰸ┱┮杮噰䵬癷田縺㐲ㄬ┥杮噰䵬癷田縺ㄲㄬ∥਍敳⁴㐢䵄呩䩭呯㴰渥灧汖睍ぶ㩵㉾ⰳ┱渥灧汖睍ぶ㩵ㅾⰲ┱渥灧汖睍ぶ㩵ㅾⰰ┱渥灧汖睍ぶ㩵ㅾⰱ┱ഢ┊塌男呈㙡い┥䠹㥨椲桨武┥即捲坚㕡啃ഥ┊㙚㙭㑰歱㕋┥㑗㜹呁潑䕥┥婨畳㑉㠷䕃┥慧捍㍺礷は┥㑰眯⽓癎䔱ഥ┊䐴楍浔潊ご┥湫㍏㙈きじ┥杺奄樵乬畕┥噎朶瘲㙥歒┥摷內但㡳䕘┥㉮㡏券䵧䕌┥戸㑘㘸婦歎ഥ┊佋爹甴㉸慕┥䔯求稸汍䕎ഥ┊䭢扣扌午啢┥㡒䄰唸㡁〸ഥഊ
```

Output without UTF-16 BOM:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set 9wjQTdCRDE=mjixwsefckotvuhgplnayrdbzq
set wDGFEfPcW0=PZVHAIUWBDJNMGTXYREKFOQCLS
set xzvl5MgZI0=0523687491
set "bvHIFFzhy0= %9wjQTdCRDE:~14,1%%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~17,1%"
set "FuNgW0jHH0=%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~8,1%%9wjQTdCRDE:~14,1%%9wjQTdCRDE:~10,1%"
set "XJ2tVXWFQ0=%9wjQTdCRDE:~17,1%%9wjQTdCRDE:~10,1% %9wjQTdCRDE:~4,1%"
set "1hOEPRVAqk=%9wjQTdCRDE:~7,1%"
set "uPH1mnFf2U= %9wjQTdCRDE:~14,1%%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~17,1%"
set "z4yvS4rrqU=@%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~8,1%%9wjQTdCRDE:~14,1%"
set "1CKIG1TRfE= > %9wjQTdCRDE:~14,1%"
set "sRGJ3Gvx0m=%9wjQTdCRDE:~6,1%"
set "4cy00pOB4U="
set "WxtNipVEUC=%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~8,1%%9wjQTdCRDE:~14,1%%9wjQTdCRDE:~10,1%"
set "NeoIB1y/M0= %usErpROfilE%"
set "kGvjfw5kG0=%9wjQTdCRDE:~6,1%%9wjQTdCRDE:~8,1%%9wjQTdCRDE:~14,1%%9wjQTdCRDE:~10,1%"
set "seaZHxqknU=%9wjQTdCRDE:~10,1%%9wjQTdCRDE:~21,1%%9wjQTdCRDE:~17,1%%9wjQTdCRDE:~22,1%"
set "1k16oZIImk=%9wjQTdCRDE:~2,1%.%9wjQTdCRDE:~11,1%%9wjQTdCRDE:~3,1%"
set "fKiqpPKEM0=%9wjQTdCRDE:~10,1%%9wjQTdCRDE:~21,1%%9wjQTdCRDE:~17,1%%9wjQTdCRDE:~22,1%"
set "0pwsdjs2VU=%9wjQTdCRDE:~16,1%%9wjQTdCRDE:~19,1%%9wjQTdCRDE:~13,1%%9wjQTdCRDE:~5,1%"
set "O1gT3v8rZ0=%9wjQTdCRDE:~10,1% %9wjQTdCRDE:~10,1%%9wjQTdCRDE:~7,1%"
set "EWceIajzsE=%9wjQTdCRDE:~17,1%%9wjQTdCRDE:~10,1% %9wjQTdCRDE:~4,1%"
set "q21vmVhxa0=%9wjQTdCRDE:~11,1%"
%z4yvS4rrqU%%O1gT3v8rZ0%%1hOEPRVAqk%
%FuNgW0jHH0%%bvHIFFzhy0%%XJ2tVXWFQ0%%fKiqpPKEM0%%4cy00pOB4U%
%kGvjfw5kG0%%uPH1mnFf2U%%EWceIajzsE%%seaZHxqknU%%1CKIG1TRfE%%1k16oZIImk%%q21vmVhxa0%
%WxtNipVEUC%%NeoIB1y/M0%
%0pwsdjs2VU%%sRGJ3Gvx0m%
```

Output with string substitution only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set DIZtwTpYp0=jcptekgsyiwabrfxdvuhoqlmnz
set akWe7wEVtk=4678031952
set t9xiLcGGak=QYKZOXJBNVDFRLTUAPGHIWEMSC
@%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~1,1%%DIZtwTpYp0:~19,1%%DIZtwTpYp0:~20,1% %DIZtwTpYp0:~20,1%%DIZtwTpYp0:~14,1%%DIZtwTpYp0:~14,1%
%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~1,1%%DIZtwTpYp0:~19,1%%DIZtwTpYp0:~20,1% %DIZtwTpYp0:~19,1%%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~20,1% %DIZtwTpYp0:~10,1%%DIZtwTpYp0:~20,1%%DIZtwTpYp0:~13,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~16,1%
%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~1,1%%DIZtwTpYp0:~19,1%%DIZtwTpYp0:~20,1% %DIZtwTpYp0:~19,1%%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~20,1% %DIZtwTpYp0:~10,1%%DIZtwTpYp0:~20,1%%DIZtwTpYp0:~13,1%%DIZtwTpYp0:~22,1%%DIZtwTpYp0:~16,1% > %DIZtwTpYp0:~19,1%%DIZtwTpYp0:~9,1%.%DIZtwTpYp0:~3,1%%DIZtwTpYp0:~15,1%%DIZtwTpYp0:~3,1%
%DIZtwTpYp0:~4,1%%DIZtwTpYp0:~1,1%%DIZtwTpYp0:~19,1%%DIZtwTpYp0:~20,1% %USErPRofiLe%
%DIZtwTpYp0:~2,1%%DIZtwTpYp0:~11,1%%DIZtwTpYp0:~18,1%%DIZtwTpYp0:~7,1%%DIZtwTpYp0:~4,1%
```

Output with string splitting only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set "AkmnbpZ6fE=lo w"
set "RqeAIEKGy0=lo w"
set "kyMV0mdJSE= %userprofile%"
set "Vk5Ng36aZk=o of"
set "4F/61xI2Sk=f"
set "J1go2LJfwU=echo"
set "/9Cv1T3hiE= hel"
set "3ordIOX16k= > h"
set "gsfL9NAtVk= hel"
set "9a3EPPSdnU=t"
set "Z7RRI0ZVsk=@ech"
set "PzbtP4tnOk=echo"
set "MPIUGguP9U=e"
set "3r7XSTR8J0=i.tx"
set "h4D7F9OhPk=orld"
set "4E0p0pLCXk=echo"
set "nN9JpaoOa0=orld"
set "Mt35m9vKJE=paus"
%Z7RRI0ZVsk%%Vk5Ng36aZk%%4F/61xI2Sk%
%PzbtP4tnOk%%/9Cv1T3hiE%%RqeAIEKGy0%%h4D7F9OhPk%
%J1go2LJfwU%%gsfL9NAtVk%%AkmnbpZ6fE%%nN9JpaoOa0%%3ordIOX16k%%3r7XSTR8J0%%9a3EPPSdnU%
%4E0p0pLCXk%%kyMV0mdJSE%
%Mt35m9vKJE%%MPIUGguP9U%
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
