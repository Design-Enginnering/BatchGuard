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
਍敀档⁯景൦挊獬਍敳汴捯污攠慮汢敥瑸湥楳湯⁳☦猠瑥潬慣⁬湥扡敬敤慬敹敤灸湡楳湯਍瀥扵楬㩣㑾ㄬ┥異汢捩縺ⰵ┱漥㩳㥾ㄬ‥体佮伽允䩗乂啐䍉䱙呅噍䑘剚䙇卋ൈ┊異汢捩縺ⰴ┱瀥扵楬㩣㕾ㄬ┥獯縺ⰹ┱䰠潅㵙潡捴睤浩杰汶橱畹穥硢晲獫桮਍瀥扵楬㩣㑾ㄬ┥異汢捩縺ⰵ┱漥㩳㥾ㄬ‥浬偢㘽㔳㠹〲㜱ഴ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙㉾ⰰ┱匥湏㩏㕾ㄬ┥䕌奯縺ⰳ┱䰥潅㩙㥾ㄬ┥体佮縺ⰴ┱匥湏㩏㉾ⰱ┱䰥潅㩙㑾ㄬ┥䕌奯縺㈲ㄬ㴥䰥潅㩙㡾ㄬ┥䕌奯縺ⰰ┱䰥潅㩙ㅾⰵ┱䰥潅㩙㉾ⰳ┱ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙ㅾㄬ┥体佮縺㐲ㄬ┥䕌奯縺ㄱㄬ┥䕌奯縺ㄲㄬ┥䕌奯縺㔱ㄬ┥体佮縺㜱ㄬ┥体佮縺ⰸ┱䰥潅㩙㥾ㄬ㴥╀䕌奯縺㘱ㄬ┥䕌奯縺ⰳ┱䰥潅㩙㉾ⰵ┱ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏㕾ㄬ┥体佮縺ⰰ┱匥湏㩏ㅾⰸ┱匥湏㩏㥾ㄬ┥䕌奯縺ⰷ┱匥湏㩏㑾ㄬ┥体佮縺㠱ㄬ┥䕌奯縺㈲ㄬ㴥䰥潅㩙㉾ⰱ┱ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏ㅾⰱ┱䰥潅㩙㉾ㄬ┥䕌奯縺㔲ㄬ┥䕌奯縺㠱ㄬ┥体佮縺ⰹ┱匥湏㩏㉾ⰵ┱䰥潅㩙㕾ㄬ┥䕌奯縺ⰳ┱┽䕌奯縺㘱ㄬ┥䕌奯縺ⰳ┱䰥潅㩙㉾ⰵ┱䰥潅㩙ㅾㄬ∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢体佮縺㤱ㄬ┥体佮縺ⰱ┱匥湏㩏ㅾⰱ┱匥湏㩏㉾ⰳ┱匥湏㩏㥾ㄬ┥䕌奯縺㔲ㄬ┥体佮縺㌱ㄬ┥䕌奯縺ⰲ┱┽䕌奯縺ㄱㄬ┥䕌奯縺ⰱ┱┠䕌奯縺ⰵ┱•☦┠䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏㉾ㄬ┥体佮縺ⰲ┱䰥潅㩙㉾ⰴ┱匥湏㩏ㅾⰰ┱匥湏㩏ㅾⰳ┱匥湏㩏㕾ㄬ┥䕌奯縺㌱ㄬ┥体佮縺ⰳ┱‽甥敓偲潒䥆䕌∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢体佮縺ⰴ┱匥湏㩏㑾ㄬ┥体佮縺ⰲ┱䰥潅㩙ㅾⰸ┱䰥潅㩙㉾ⰴ┱匥湏㩏まㄬ┥体佮縺㔱ㄬ┥体佮縺㠱ㄬ㴥┠䕌奯縺㔲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ㄱㄬ∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢䕌奯縺ⰳ┱䰥潅㩙まㄬ┥䕌奯縺ⰲ┱䰥潅㩙㝾ㄬ┥体佮縺〱ㄬ┥䕌奯縺㐱ㄬ┥䕌奯縺ⰸ┱䰥潅㩙㉾ⰲ┱┽䕌奯縺㘱ㄬ∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢䕌奯縺㤱ㄬ┥体佮縺ㄱㄬ┥䕌奯縺㐱ㄬ┥䕌奯縺㈲ㄬ┥䕌奯縺㔲ㄬ┥䕌奯縺㈲ㄬ┥体佮縺㤱ㄬ┥体佮縺㈲ㄬ㴥ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏ㅾⰴ┱匥湏㩏ㅾⰲ┱匥湏㩏ㅾⰷ┱䰥潅㩙まㄬ┥体佮縺ⰷ┱䰥潅㩙ㅾⰳ┱䰥潅㩙㉾ⰴ┱䰥潅㩙ㅾⰴ┱┽䕌奯縺ⰲ┱•☦┠䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙㡾ㄬ┥䕌奯縺ⰴ┱䰥潅㩙㉾ㄬ┥体佮縺ⰳ┱匥湏㩏ㅾⰹ┱匥湏㩏ㅾⰹ┱匥湏㩏㡾ㄬ┥䕌奯縺㐱ㄬ㴥䰥潅㩙ㅾⰶ┱䰥潅㩙㍾ㄬ┥䕌奯縺㔲ㄬ┥䕌奯縺ⰱ┱•☦┠䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙㕾ㄬ┥䕌奯縺㔱ㄬ┥䕌奯縺ⰶ┱䰥潅㩙ㅾⰲ┱匥湏㩏㝾ㄬ┥体佮縺㌱ㄬ┥䕌奯縺㐲ㄬ┥䕌奯縺㈲ㄬ㴥䰥潅㩙ㅾⰶ┱䰥潅㩙㍾ㄬ┥䕌奯縺㔲ㄬ┥䕌奯縺ⰱ┱ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏㉾ⰰ┱匥湏㩏㉾ⰱ┱䰥潅㩙ㅾⰷ┱匥湏㩏ㅾⰰ┱䰥潅㩙ㅾⰲ┱匥湏㩏㉾ⰳ┱䰥潅㩙ㅾⰵ┱匥湏㩏ㅾⰶ┱┽䕌奯縺ⰱ┱䰥潅㩙㉾ⰰ┱䰥潅㩙ㅾⰱ┱䰥潅㩙㑾ㄬ∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢䕌奯縺㐲ㄬ┥体佮縺㠱ㄬ┥体佮縺㜱ㄬ┥体佮縺ⰳ┱匥湏㩏㍾ㄬ┥䕌奯縺㈲ㄬ┥体佮縺㘱ㄬ┥䕌奯縺ㄲㄬ㴥┠䕌奯縺㔲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ㄱㄬ∥☠…䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢䕌奯縺㜱ㄬ┥䕌奯縺㤱ㄬ┥体佮縺㔱ㄬ┥体佮縺㘱ㄬ┥体佮縺ⰳ┱匥湏㩏ㅾⰲ┱匥湏㩏ㅾⰱ┱匥湏㩏ㅾⰳ┱‽‾䰥潅㩙㉾ⰵ┱•☦┠䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙ㅾⰳ┱䰥潅㩙㉾ⰴ┱匥湏㩏㉾ⰱ┱匥湏㩏㉾ⰳ┱匥湏㩏ㅾⰶ┱䰥潅㩙ㅾⰷ┱匥湏㩏ㅾⰳ┱匥湏㩏ㅾⰰ┱┽䕌奯縺ⰱ┱┠䕌奯縺ⰱ┱䰥潅㩙㉾ⰱ┱•☦┠䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠䰥潅㩙ㅾⰱ┱匥湏㩏㡾ㄬ┥体佮縺㌱ㄬ┥䕌奯縺㐱ㄬ┥䕌奯縺ⰵ┱匥湏㩏まㄬ┥体佮縺ⰵ┱匥湏㩏㉾ⰳ┱┽䕌奯縺ㄱㄬ┥䕌奯縺ⰱ┱┠䕌奯縺ⰵ┱ഢ┊䕌奯縺㌲ㄬ┥䕌奯縺㘱ㄬ┥䕌奯縺ⰲ┱∠匥湏㩏㝾ㄬ┥体佮縺ⰷ┱匥湏㩏ㅾⰹ┱匥湏㩏ㅾⰷ┱䰥潅㩙㑾ㄬ┥体佮縺ⰵ┱匥湏㩏ㅾⰸ┱匥湏㩏㍾ㄬ㴥䰥潅㩙㙾ㄬ⸥䰥潅㩙㉾ㄬ┥䕌奯縺㤱ㄬ∥਍䰥潅㩙㉾ⰳ┱䰥潅㩙ㅾⰶ┱䰥潅㩙㉾ㄬ‥┢体佮縺㌲ㄬ┥䕌奯縺㠱ㄬ┥体佮縺ㄲㄬ┥䕌奯縺㤱ㄬ┥䕌奯縺ⰶ┱䰥潅㩙㕾ㄬ┥䕌奯縺ⰶ┱䰥潅㩙ㅾⰸ┱┽䕌奯縺ⰱ┱䰥潅㩙㉾ⰰ┱䰥潅㩙ㅾⰱ┱䰥潅㩙㑾ㄬ∥਍漥䱳畦啸╧樥䝮癋䕺╃䈥䑏浉摊╋਍夥桔䥂睨╃䨥兪湂䵯╄稥奡楫䕨╔爥穇兣啫╖਍眥極灱湅╋渥硤坷癋╆氥䕵睙扯╋欥䝂䥘楷╂娥䵸坶奬╥瀥婐䑸摂╷吥塌灡湊╙਍瀥瑄穷啺╹儥乑䕃䩢╷਍別䍢橧䑇╫挥瑡捭灙╋਍堥她䡫婫╆਍਍
```

Output without UTF-16 BOM:
```bat
@echo off
cls
setlocal enableextensions && setlocal enabledelayedexpansion
%public:~4,1%%public:~5,1%%os:~9,1% vxiA=agevyojtnlchrupdbxifqsmkzw
%public:~4,1%%public:~5,1%%os:~9,1% fOiN=8601597324
%public:~4,1%%public:~5,1%%os:~9,1% POTB=SFAGTPNURVQLXMYHDJCEIZBOWK
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~6,1%%vxiA:~25,1%%POTB:~19,1%%POTB:~18,1%%POTB:~3,1%%POTB:~20,1%%POTB:~5,1%%POTB:~12,1%=%vxiA:~9,1%%vxiA:~5,1% %vxiA:~25,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~20,1%%POTB:~19,1%%vxiA:~6,1%%vxiA:~12,1%%vxiA:~15,1%%vxiA:~23,1%%POTB:~24,1%%POTB:~4,1%=" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~18,1%%POTB:~17,1%%POTB:~23,1%%POTB:~23,1%%POTB:~23,1%%POTB:~3,1%%vxiA:~23,1%%POTB:~21,1%=%vxiA:~18,1%.%vxiA:~7,1%%vxiA:~17,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~18,1%%vxiA:~13,1%%vxiA:~23,1%%POTB:~4,1%%POTB:~20,1%%POTB:~7,1%%vxiA:~16,1%%POTB:~3,1%=%vxiA:~9,1%%vxiA:~5,1% %vxiA:~25,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~18,1%%POTB:~8,1%%vxiA:~8,1%%vxiA:~21,1%%POTB:~14,1%%POTB:~9,1%%vxiA:~13,1%%POTB:~4,1%=%vxiA:~19,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~2,1%%POTB:~10,1%%POTB:~1,1%%POTB:~0,1%%vxiA:~20,1%%POTB:~7,1%%POTB:~18,1%%POTB:~16,1%= %USERprOFILE%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~24,1%%POTB:~17,1%%vxiA:~21,1%%vxiA:~10,1%%vxiA:~22,1%%vxiA:~15,1%%POTB:~19,1%%POTB:~3,1%=%vxiA:~2,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~21,1%%vxiA:~19,1%%POTB:~6,1%%POTB:~21,1%%POTB:~17,1%%POTB:~22,1%%POTB:~1,1%%POTB:~19,1%= %vxiA:~11,1%%vxiA:~2,1%%vxiA:~9,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~25,1%%vxiA:~8,1%%vxiA:~3,1%%POTB:~19,1%%vxiA:~12,1%%POTB:~22,1%%vxiA:~13,1%%POTB:~19,1%=%vxiA:~7,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~1,1%%POTB:~16,1%%vxiA:~23,1%%POTB:~20,1%%POTB:~1,1%%vxiA:~5,1%%vxiA:~8,1%%POTB:~12,1%=%vxiA:~5,1% %vxiA:~5,1%%vxiA:~19,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~14,1%%vxiA:~17,1%%POTB:~25,1%%vxiA:~25,1%%POTB:~25,1%%vxiA:~17,1%%POTB:~25,1%%vxiA:~0,1%=%vxiA:~2,1%%vxiA:~10,1%%vxiA:~11,1%%vxiA:~5,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~1,1%%vxiA:~0,1%%POTB:~12,1%%POTB:~0,1%%POTB:~0,1%%vxiA:~4,1%%POTB:~19,1%%vxiA:~2,1%= > %vxiA:~11,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~3,1%%vxiA:~5,1%%POTB:~11,1%%POTB:~21,1%%vxiA:~0,1%%vxiA:~3,1%%vxiA:~7,1%%vxiA:~12,1%=%vxiA:~5,1%%vxiA:~12,1%%vxiA:~9,1%%vxiA:~15,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~16,1%%POTB:~3,1%%POTB:~24,1%%POTB:~2,1%%vxiA:~19,1%%POTB:~7,1%%vxiA:~10,1%%vxiA:~5,1%=%vxiA:~2,1%%vxiA:~10,1%%vxiA:~11,1%%vxiA:~5,1%" && %vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~13,1%%POTB:~14,1%%vxiA:~6,1%%POTB:~0,1%%vxiA:~0,1%%vxiA:~10,1%%POTB:~16,1%%POTB:~19,1%=@%vxiA:~2,1%%vxiA:~10,1%%vxiA:~11,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%vxiA:~13,1%%POTB:~2,1%%vxiA:~3,1%%vxiA:~8,1%%vxiA:~3,1%%POTB:~16,1%%vxiA:~15,1%%POTB:~7,1%=%vxiA:~5,1%%vxiA:~12,1%%vxiA:~9,1%%vxiA:~15,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~3,1%%POTB:~7,1%%vxiA:~22,1%%vxiA:~7,1%%POTB:~20,1%%POTB:~24,1%%POTB:~22,1%%vxiA:~16,1%=%vxiA:~2,1%%vxiA:~10,1%%vxiA:~11,1%%vxiA:~5,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~2,1%%POTB:~21,1%%vxiA:~20,1%%vxiA:~17,1%%vxiA:~7,1%%vxiA:~19,1%%POTB:~18,1%%vxiA:~8,1%= %vxiA:~11,1%%vxiA:~2,1%%vxiA:~9,1%"
%vxiA:~21,1%%vxiA:~2,1%%vxiA:~7,1% "%POTB:~25,1%%POTB:~18,1%%POTB:~22,1%%POTB:~10,1%%POTB:~11,1%%POTB:~12,1%%POTB:~13,1%%vxiA:~17,1%=%vxiA:~14,1%%vxiA:~0,1%%vxiA:~13,1%%vxiA:~21,1%"
%UYjsaCDE%%gDKiFonx%%CRNsyVUT%
%BgwafUco%%aZqXtFcn%%jWEcGIpX%%volzaVTR%
%GumtIWBB%%ZFNZjBFe%%iUktiubg%%UAVNvDdU%%gaXssyee%%cJOOOgkZ%%wnveRbUe%
%pXkWKXkA%%AqFSQUCd%
%kCbqLxMx%%zjscMDEG%
%QEJrDKwT%
```

Output with string substitution only:
```bat
@echo off
cls
setlocal enableextensions && setlocal enabledelayedexpansion
%public:~4,1%%public:~5,1%%os:~9,1% TfOX=RNQUXPDBOASJILEZFKCMYTWHVG
%public:~4,1%%public:~5,1%%os:~9,1% aYqf=xhomnfdzuslptawbcygvjirqek
%public:~4,1%%public:~5,1%%os:~9,1% bfDx=0632584197
@%aYqf:~24,1%%aYqf:~16,1%%aYqf:~1,1%%aYqf:~2,1% %aYqf:~2,1%%aYqf:~5,1%%aYqf:~5,1%
%aYqf:~24,1%%aYqf:~16,1%%aYqf:~1,1%%aYqf:~2,1% %aYqf:~1,1%%aYqf:~24,1%%aYqf:~10,1%%aYqf:~10,1%%aYqf:~2,1% %aYqf:~14,1%%aYqf:~2,1%%aYqf:~22,1%%aYqf:~10,1%%aYqf:~6,1%
%aYqf:~24,1%%aYqf:~16,1%%aYqf:~1,1%%aYqf:~2,1% %aYqf:~1,1%%aYqf:~24,1%%aYqf:~10,1%%aYqf:~10,1%%aYqf:~2,1% %aYqf:~14,1%%aYqf:~2,1%%aYqf:~22,1%%aYqf:~10,1%%aYqf:~6,1% > %aYqf:~1,1%%aYqf:~21,1%.%aYqf:~12,1%%aYqf:~0,1%%aYqf:~12,1%
%aYqf:~24,1%%aYqf:~16,1%%aYqf:~1,1%%aYqf:~2,1% %uSerpROfiLE%
%aYqf:~11,1%%aYqf:~13,1%%aYqf:~8,1%%aYqf:~9,1%%aYqf:~24,1%
```

Output with string splitting only:
```bat
@echo off
cls
setlocal enableextensions && setlocal enabledelayedexpansion
set "gpJvoZNh=i.tx"
set "vegYaqgK=echo"
set "CJwVSYRE=echo"
set "xwdUMNrT=orld" && set "gIHMNXtE="
set "oeIsGEzA=t"
set "OotfZyAr=echo" && set "vIwiWUaH=e"
set "UweCWoRu= hel" && set "zlFwEQUW=orld" && set "eyukvRUE= hel"
set "khXhXjmz= %userprofile%" && set "qDEpthmQ=paus" && set "UGHecxEl= > h" && set "EKfbzgSE=o of" && set "xfduXIKa=@ech"
set "tEWBEfwC=f" && set "WIKoTYij=lo w" && set "dPOeTruU=lo w"
%xfduXIKa%%EKfbzgSE%%tEWBEfwC%
%CJwVSYRE%%UweCWoRu%%dPOeTruU%%zlFwEQUW%
%OotfZyAr%%eyukvRUE%%WIKoTYij%%xwdUMNrT%%UGHecxEl%%gpJvoZNh%%oeIsGEzA%
%vegYaqgK%%khXhXjmz%
%qDEpthmQ%%vIwiWUaH%
%gIHMNXtE%
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
