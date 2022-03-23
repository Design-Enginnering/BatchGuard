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
਍敀档⁯景൦挊獬਍敳汴捯污攠慮汢摥汥祡摥硥慰獮潩൮猊瑥嘠桍噈瑋䉙㵷睳晥畮捸慬歯灹穱癲浴桪摢楧਍敳⁴桊奐啉呖单䨽婇䡁䍉䭑坆佂協塎䕌䵐噕䑙൒猊瑥搠䍈硭䉬偖㵁㐸㈶㌰ㄹ㔷਍敳⁴眢剹桡卡故㵎┠䵖䡨䭖奴睂縺ㄲㄬ┥䵖䡨䭖奴睂縺ⰲ┱嘥桍噈瑋䉙㩷㡾ㄬ∥਍敳⁴儢潷偰晰祩㵢嘥桍噈瑋䉙㩷ㅾⰰ┱嘥桍噈瑋䉙㩷ㅾⰶ┱嘥桍噈瑋䉙㩷㡾ㄬ┥䵖䡨䭖奴睂縺㌲ㄬ∥਍敳⁴砢䝸䑉乹畫㵥嘥桍噈瑋䉙㩷ㅾⰰ┱┠䵖䡨䭖奴睂縺〱ㄬ┥䵖䡨䭖奴睂縺ⰳ┱ഢ猊瑥∠潣䱵婄畫捹‽甥敓偒佒䥆敌∥਍敳⁴栢䍣瑂啲楃㵡嘥桍噈瑋䉙㩷ㅾⰰ┱嘥桍噈瑋䉙㩷ㅾⰶ┱嘥桍噈瑋䉙㩷㡾ㄬ┥䵖䡨䭖奴睂縺㌲ㄬ∥਍敳⁴栢敮体牋䭦㵅嘥桍噈瑋䉙㩷㉾ㄬ∥਍敳⁴丢卑慔李千㵸㸠┠䵖䡨䭖奴睂縺ㄲㄬ∥਍敳⁴倢奊偏啩䱋㵁嘥桍噈瑋䉙㩷ㅾⰳ┱嘥桍噈瑋䉙㩷㥾ㄬ┥䵖䡨䭖奴睂縺ⰵ┱嘥桍噈瑋䉙㩷まㄬ∥਍敳⁴倢瑯扄歌䑑㵡嘥桍噈瑋䉙㩷㡾ㄬ┥䵖䡨䭖奴睂縺〱ㄬ‥嘥桍噈瑋䉙㩷ㅾㄬ∥਍敳⁴昢䡺灵䵒䥆㵍ഢ猊瑥∠䡸䑙歭敫火┽䵖䡨䭖奴睂縺ⰲ┱嘥桍噈瑋䉙㩷㝾ㄬ┥䵖䡨䭖奴睂縺ㄲㄬ┥䵖䡨䭖奴睂縺〱ㄬ∥਍敳⁴吢塭䙕橭䥏㵇嘥桍噈瑋䉙㩷㉾ㄬ┥䵖䡨䭖奴睂縺ⰷ┱嘥桍噈瑋䉙㩷㉾ⰱ┱嘥桍噈瑋䉙㩷ㅾⰰ┱ഢ猊瑥∠奥剖䭴䭫慔┽䵖䡨䭖奴睂縺㔲ㄬ⸥嘥桍噈瑋䉙㩷ㅾⰸ┱嘥桍噈瑋䉙㩷㙾ㄬ∥਍敳⁴刢空塊坈噲㵲ഢ猊瑥∠汐䍣济歴䵷┽䵖䡨䭖奴睂縺㠱ㄬ∥਍敳⁴䴢䩁坩佄潵㵁┠䵖䡨䭖奴睂縺ㄲㄬ┥䵖䡨䭖奴睂縺ⰲ┱嘥桍噈瑋䉙㩷㡾ㄬ∥਍敳⁴爢捯商灢畦㵣╀䵖䡨䭖奴睂縺ⰲ┱嘥桍噈瑋䉙㩷㝾ㄬ┥䵖䡨䭖奴睂縺ㄲㄬ∥਍敳⁴挢祬䩵潕啮㵏嘥桍噈瑋䉙㩷㉾ㄬ┥䵖䡨䭖奴睂縺ⰷ┱嘥桍噈瑋䉙㩷㉾ⰱ┱嘥桍噈瑋䉙㩷ㅾⰰ┱ഢ猊瑥∠桃兇䅊潯䕹┽䵖䡨䭖奴睂縺ⰳ┱ഢ猊瑥∠煤祯海坩䕗┽䵖䡨䭖奴睂縺ⰸ┱嘥桍噈瑋䉙㩷ㅾⰰ┱┠䵖䡨䭖奴睂縺ⰱ┱ഢ┊潲䙣払晰捵┥硸䥇祄歎敵┥桃兇䅊潯䕹ഥ┊䡸䑙歭敫火┥祷慒慨䕓乥┥煤祯海坩䕗┥捨䉃牴䍕慩┥穒䩺䡘牗牖ഥ┊浔啘浆佪䝉┥䅍楊䑗畏䅯┥潐䑴䱢八慄┥睑灯灐楦批┥兎呓乡䍧硓┥奥剖䭴䭫慔┥汐䍣济歴䵷ഥ┊汣畹啊湯何┥潣䱵婄畫捹ഥ┊䩐余楐䭕䅌┥湨卥䭏晲䕋ഥ┊穦畈剰䙍䵉ഥഊ
```

Output without UTF-16 BOM:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set xtxTiSkMUy=5478296310
set imEAnQEHps=POCFZGNXJWBVMDAYEULIHSQKRT
set EnsuXAxEWd=vdlgswbfuahzetcjyoimqkxpnr
set "vGlKHyskpa=%EnsuXAxEWd:~12,1%"
set "XYYvotcKUG=%EnsuXAxEWd:~17,1% %EnsuXAxEWd:~17,1%%EnsuXAxEWd:~7,1%"
set "zItLiakOUa="
set "oVWKijodrU= > %EnsuXAxEWd:~10,1%"
set "VDQuRJUuHj=%EnsuXAxEWd:~23,1%%EnsuXAxEWd:~9,1%%EnsuXAxEWd:~8,1%%EnsuXAxEWd:~4,1%"
set "mSIsAqYmkq=%EnsuXAxEWd:~17,1%%EnsuXAxEWd:~25,1%%EnsuXAxEWd:~2,1%%EnsuXAxEWd:~1,1%"
set "jhGLdGfkWd="
set "kmcHiccESC=%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~14,1%%EnsuXAxEWd:~10,1%%EnsuXAxEWd:~17,1%"
set "ZPadONvoBB=%EnsuXAxEWd:~2,1%%EnsuXAxEWd:~17,1% %EnsuXAxEWd:~5,1%"
set "UBsqFvPSzC=@%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~14,1%%EnsuXAxEWd:~10,1%"
set "JDXyepaGUh=%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~14,1%%EnsuXAxEWd:~10,1%%EnsuXAxEWd:~17,1%"
set "CYApXQrUec= %UserProfILe%"
set "dIHOeydkyW= %EnsuXAxEWd:~10,1%%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~2,1%"
set "QqjIBAouZx=%EnsuXAxEWd:~7,1%"
set "xDGQnYUSMa=%EnsuXAxEWd:~18,1%.%EnsuXAxEWd:~13,1%%EnsuXAxEWd:~22,1%"
set "xgVKWQEEGL=%EnsuXAxEWd:~2,1%%EnsuXAxEWd:~17,1% %EnsuXAxEWd:~5,1%"
set "ICPAqcPEMw= %EnsuXAxEWd:~10,1%%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~2,1%"
set "QgvfMFrUOy=%EnsuXAxEWd:~13,1%"
set "ggPKgVYWUW=%EnsuXAxEWd:~17,1%%EnsuXAxEWd:~25,1%%EnsuXAxEWd:~2,1%%EnsuXAxEWd:~1,1%"
set "hLSTUNoBUu=%EnsuXAxEWd:~12,1%%EnsuXAxEWd:~14,1%%EnsuXAxEWd:~10,1%%EnsuXAxEWd:~17,1%"
%UBsqFvPSzC%%XYYvotcKUG%%QqjIBAouZx%
%JDXyepaGUh%%dIHOeydkyW%%ZPadONvoBB%%mSIsAqYmkq%%zItLiakOUa%
%hLSTUNoBUu%%ICPAqcPEMw%%xgVKWQEEGL%%ggPKgVYWUW%%oVWKijodrU%%xDGQnYUSMa%%QgvfMFrUOy%
%kmcHiccESC%%CYApXQrUec%
%VDQuRJUuHj%%vGlKHyskpa%
%jhGLdGfkWd%
```

Output with string substitution only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set HgbyaIESdE=TGVKUWXOJDRZSQBNHACPLFYEMI
set wjOilywECV=1702936485
set QRGePwKWPZ=nxiujgesclmokhpbfrdwzytavq
@%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~8,1%%QRGePwKWPZ:~13,1%%QRGePwKWPZ:~11,1% %QRGePwKWPZ:~11,1%%QRGePwKWPZ:~16,1%%QRGePwKWPZ:~16,1%
%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~8,1%%QRGePwKWPZ:~13,1%%QRGePwKWPZ:~11,1% %QRGePwKWPZ:~13,1%%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~11,1% %QRGePwKWPZ:~19,1%%QRGePwKWPZ:~11,1%%QRGePwKWPZ:~17,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~18,1%
%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~8,1%%QRGePwKWPZ:~13,1%%QRGePwKWPZ:~11,1% %QRGePwKWPZ:~13,1%%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~11,1% %QRGePwKWPZ:~19,1%%QRGePwKWPZ:~11,1%%QRGePwKWPZ:~17,1%%QRGePwKWPZ:~9,1%%QRGePwKWPZ:~18,1% > %QRGePwKWPZ:~13,1%%QRGePwKWPZ:~2,1%.%QRGePwKWPZ:~22,1%%QRGePwKWPZ:~1,1%%QRGePwKWPZ:~22,1%
%QRGePwKWPZ:~6,1%%QRGePwKWPZ:~8,1%%QRGePwKWPZ:~13,1%%QRGePwKWPZ:~11,1% %uSErProfILE%
%QRGePwKWPZ:~14,1%%QRGePwKWPZ:~23,1%%QRGePwKWPZ:~3,1%%QRGePwKWPZ:~7,1%%QRGePwKWPZ:~6,1%
```

Output with string splitting only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set "hyAMjhJzKQ=orld"
set "dXXrENQrUG=@ech"
set "EhSSJvsQWU=echo"
set "snzaOoXeup=t"
set "wheXffEeqb=f"
set "nmaZsJnEKe= hel"
set "zldasyEUGd=paus"
set "puLqSJKhQk=lo w"
set "bUCDltHkqx=lo w"
set "TxqSzFFaUH=orld"
set "iYotKFTEiv= hel"
set "CXqhsrlEWt=echo"
set "SInHOcXWDa=i.tx"
set "omsDIrpUaW=echo"
set "uZqWPfBVlD="
set "UbThNEaQoC=o of"
set "avfjzJVkaE= %userprofile%"
set "CVCwArdTkO=e"
set "VFOnVyzRvW= > h"
%dXXrENQrUG%%UbThNEaQoC%%wheXffEeqb%
%omsDIrpUaW%%nmaZsJnEKe%%puLqSJKhQk%%hyAMjhJzKQ%
%EhSSJvsQWU%%iYotKFTEiv%%bUCDltHkqx%%TxqSzFFaUH%%VFOnVyzRvW%%SInHOcXWDa%%snzaOoXeup%
%CXqhsrlEWt%%avfjzJVkaE%
%zldasyEUGd%%CVCwArdTkO%
%uZqWPfBVlD%
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
