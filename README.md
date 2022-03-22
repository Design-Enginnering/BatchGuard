# BatchGuard

Based on [taxiobf](https://github.com/cchash/taxiobf).

Rushed batch file obfuscation tool I made in a few hours. Not all features complete, potentially buggy, and not "as secure" as I want to final product to be. Messy code abound. Only thing for sure is that all "obfuscation" options added right now work.

Updates will come soon.

## User interface
![image](https://media.discordapp.net/attachments/955850893113298957/955850910242840576/unknown.png)

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
਍敀档⁯景൦挊獬਍敳汴捯污攠慮汢摥汥祡摥硥慰獮潩൮猊瑥䈠啇剁彄畒乚䭢佮䕑㜽㠰㐵㌱㈶ഹ猊瑥䈠啇剁彄兆楸攰䄹ぐ渽歵硨灬慶楳睺瑲祢敪杯捭煤൦猊瑥䈠啇剁彄啧眱䕣乙づ刽啌䕋䍆偗噔塂兊䅈䑎䝉婏奍൓┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄啧眱䕣乙づ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰱ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰳ┱䈥啇剁彄畒乚䭢佮䕑縺ⰶ┱䈥啇剁彄畒乚䭢佮䕑縺ⰷ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰲ┱䈥啇剁彄兆楸攰䄹ぐ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰵ┱┽䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱┠䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄兆楸攰䄹ぐ縺ㄲㄬ┥䝂䅕䑒剟婵扎湋兏㩅㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰵ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㜱ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㝾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰まㄬ㴥䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱䈥啇剁彄兆楸攰䄹ぐ縺㤱ㄬ‥䈥啇剁彄兆楸攰䄹ぐ縺㈱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱䈥啇剁彄兆楸攰䄹ぐ縺㌱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㕾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰳ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄啧眱䕣乙づ縺ⰶ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰵ┱䈥啇剁彄啧眱䕣乙づ縺ⰲ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰳ┱䈥啇剁彄兆楸攰䄹ぐ縺㔲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ㴥╀䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱┠䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱䈥啇剁彄兆楸攰䄹ぐ縺㔲ㄬ∥਍䈥啇剁彄兆楸攰䄹ぐ縺ⰹ┱䈥啇剁彄兆楸攰䄹ぐ縺㠱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰴ┱∠䈥啇剁彄啧眱䕣乙づ縺ㄱㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ⰰ┱䈥啇剁彄啧眱䕣乙づ縺ⰲ┱䈥啇剁彄啧眱䕣乙づ縺㘱ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰まㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰸ┱╟䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰱ┱䈥啇剁彄兆楸攰䄹ぐ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ⰱ┱䈥啇剁彄啧眱䕣乙づ縺㤱ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰵ┱䈥啇剁彄啧眱䕣乙づ縺ⰸ┱䈥啇剁彄啧眱䕣乙づ縺㐲ㄬ┥䝂䅕䑒剟婵扎湋兏㩅ㅾㄬ㴥䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱䈥啇剁彄兆楸攰䄹ぐ縺㤱ㄬ‥䈥啇剁彄兆楸攰䄹ぐ縺㈱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱䈥啇剁彄兆楸攰䄹ぐ縺㌱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㕾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰳ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄畒乚䭢佮䕑縺ⰴ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰰ┱䈥啇剁彄兆楸攰䄹ぐ縺〱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰰ┱䈥啇剁彄啧眱䕣乙づ縺ⰱ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰱ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰳ┱䈥啇剁彄兆楸攰䄹ぐ縺㌱ㄬ㴥䈥啇剁彄兆楸攰䄹ぐ縺㠱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰲ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰳ┱䈥啇剁彄兆楸攰䄹ぐ縺㤱ㄬ‥唥䕳灲潒楦敬∥਍䈥啇剁彄兆楸攰䄹ぐ縺ⰹ┱䈥啇剁彄兆楸攰䄹ぐ縺㠱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰴ┱∠䈥啇剁彄啧眱䕣乙づ縺ㄱㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ⰰ┱䈥啇剁彄啧眱䕣乙づ縺ⰲ┱䈥啇剁彄啧眱䕣乙づ縺㘱ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰まㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰸ┱╟䝂䅕䑒束ㅕ捷奅敎㨰㉾ⰵ┱䈥啇剁彄啧眱䕣乙づ縺ⰳ┱䈥啇剁彄啧眱䕣乙づ縺㐱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰱ┱䈥啇剁彄兆楸攰䄹ぐ縺㔱ㄬ┥䝂䅕䑒剟婵扎湋兏㩅㙾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰳ┱䈥啇剁彄啧眱䕣乙づ縺ⰷ┱┽䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱┠䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄兆楸攰䄹ぐ縺㔲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ⰴ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰲ┱䈥啇剁彄畒乚䭢佮䕑縺ⰸ┱┯䝂䅕䑒䙟硑ど㥥偁㨰㕾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺㤱ㄬ㴥㸠┠䝂䅕䑒䙟硑ど㥥偁㨰㍾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰰ┱┮䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰴ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰴ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥┯䝂䅕䑒剟婵扎湋兏㩅まㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰹ┱䈥啇剁彄啧眱䕣乙づ縺㈲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰷ┱䈥啇剁彄啧眱䕣乙づ縺㔲ㄬ┥䝂䅕䑒剟婵扎湋兏㩅㕾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰶ┱┽䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰵ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄啧眱䕣乙づ縺ⰶ┱䈥啇剁彄畒乚䭢佮䕑縺ⰷ┱䈥啇剁彄畒乚䭢佮䕑縺ⰶ┱䈥啇剁彄畒乚䭢佮䕑縺ⰲ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰶ┱䈥啇剁彄畒乚䭢佮䕑縺ⰲ┱䈥啇剁彄兆楸攰䄹ぐ縺〱ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰷ┱┽䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰴ┱ഢ┊䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱䈥啇剁彄兆楸攰䄹ぐ縺㐱ㄬ‥┢䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰱ┱䈥啇剁彄啧眱䕣乙づ縺〲ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰㉾ㄬ┥䝂䅕䑒束ㅕ捷奅敎㨰ㅾⰶ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄啧眱䕣乙づ縺㠱ㄬ弥䈥啇剁彄畒乚䭢佮䕑縺ⰱ┱䈥啇剁彄啧眱䕣乙づ縺ⰰ┱䈥啇剁彄兆楸攰䄹ぐ縺ⰵ┱䈥啇剁彄啧眱䕣乙づ縺ㄲㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰳ┱䈥啇剁彄啧眱䕣乙づ縺㔲ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㉾ⰴ┱䈥啇剁彄畒乚䭢佮䕑縺ⰸ┱┽䝂䅕䑒䙟硑ど㥥偁㨰㙾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㡾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰㥾ㄬ┥䝂䅕䑒䙟硑ど㥥偁㨰ㅾⰸ┱ഢ┊䝂䅕䑒䍟䡄䝕晤╳䈥啇剁彄㜯婯卪礱ഥ┊䝂䅕䑒卟克扭爳╗䈥啇剁彄杭䥏偈すഥ┊䝂䅕䑒婟桺㘳捫╦䈥啇剁彄㥭汢乮湗┥䝂䅕䑒晟歙⼲穬╉䈥啇剁彄㙃㠳㡰橩ഥ┊䝂䅕䑒㑟楮䱩桵╲਍䈥啇剁彄到佬卤㉱ഥഊ
```

Output without UTF-16 BOM:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set BGUARD_M0NbtObX0y=9184732560
set BGUARD_1pl7DboSME=TUIDNZRLWKOHMXJPCVQABESGYF
set BGUARD_HUynqAAbqE=esijvnxpyqdzobuakcgmfhlwtr
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_HUynqAAbqE:~11,1%%BGUARD_1pl7DboSME:~13,1%%BGUARD_M0NbtObX0y:~0,1%%BGUARD_1pl7DboSME:~25,1%%BGUARD_1pl7DboSME:~21,1%%BGUARD_HUynqAAbqE:~25,1%%BGUARD_HUynqAAbqE:~7,1%%BGUARD_1pl7DboSME:~25,1%=%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~17,1%%BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~12,1% %UserprOFILE%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_M0NbtObX0y:~8,1%%BGUARD_HUynqAAbqE:~6,1%%BGUARD_HUynqAAbqE:~24,1%%BGUARD_HUynqAAbqE:~15,1%%BGUARD_1pl7DboSME:~25,1%%BGUARD_1pl7DboSME:~10,1%%BGUARD_M0NbtObX0y:~2,1%%BGUARD_1pl7DboSME:~12,1%=@%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~17,1%%BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~12,1% %BGUARD_HUynqAAbqE:~12,1%%BGUARD_HUynqAAbqE:~20,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_1pl7DboSME:~17,1%%BGUARD_HUynqAAbqE:~6,1%%BGUARD_1pl7DboSME:~22,1%%BGUARD_HUynqAAbqE:~25,1%%BGUARD_HUynqAAbqE:~25,1%%BGUARD_HUynqAAbqE:~5,1%%BGUARD_1pl7DboSME:~16,1%%BGUARD_HUynqAAbqE:~0,1%=%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~17,1%%BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~12,1% %BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~22,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_HUynqAAbqE:~16,1%%BGUARD_1pl7DboSME:~17,1%%BGUARD_HUynqAAbqE:~5,1%%BGUARD_1pl7DboSME:~2,1%%BGUARD_1pl7DboSME:~15,1%%BGUARD_HUynqAAbqE:~18,1%%BGUARD_HUynqAAbqE:~23,1%%BGUARD_1pl7DboSME:~21,1%=%BGUARD_HUynqAAbqE:~20,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_1pl7DboSME:~16,1%%BGUARD_1pl7DboSME:~24,1%/%BGUARD_1pl7DboSME:~22,1%%BGUARD_M0NbtObX0y:~7,1%%BGUARD_HUynqAAbqE:~13,1%%BGUARD_1pl7DboSME:~12,1%%BGUARD_HUynqAAbqE:~6,1%=%BGUARD_HUynqAAbqE:~7,1%%BGUARD_HUynqAAbqE:~15,1%%BGUARD_HUynqAAbqE:~14,1%%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_HUynqAAbqE:~24,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~11,1%%BGUARD_1pl7DboSME:~16,1%%BGUARD_HUynqAAbqE:~12,1%%BGUARD_1pl7DboSME:~11,1%%BGUARD_1pl7DboSME:~21,1%%BGUARD_1pl7DboSME:~23,1%=%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~17,1%%BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~12,1% %BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~22,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1%%BGUARD_M0NbtObX0y:~2,1%%BGUARD_1pl7DboSME:~7,1%%BGUARD_HUynqAAbqE:~20,1%%BGUARD_1pl7DboSME:~25,1%%BGUARD_1pl7DboSME:~20,1%%BGUARD_M0NbtObX0y:~7,1%= > %BGUARD_HUynqAAbqE:~21,1%%BGUARD_HUynqAAbqE:~2,1%.%BGUARD_HUynqAAbqE:~24,1%%BGUARD_HUynqAAbqE:~6,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_M0NbtObX0y:~7,1%%BGUARD_1pl7DboSME:~13,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_HUynqAAbqE:~16,1%%BGUARD_HUynqAAbqE:~4,1%%BGUARD_1pl7DboSME:~16,1%%BGUARD_1pl7DboSME:~25,1%%BGUARD_HUynqAAbqE:~24,1%=%BGUARD_HUynqAAbqE:~22,1%%BGUARD_HUynqAAbqE:~12,1% %BGUARD_HUynqAAbqE:~23,1%%BGUARD_HUynqAAbqE:~12,1%%BGUARD_HUynqAAbqE:~25,1%%BGUARD_HUynqAAbqE:~22,1%%BGUARD_HUynqAAbqE:~10,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_%BGUARD_1pl7DboSME:~10,1%%BGUARD_1pl7DboSME:~10,1%%BGUARD_1pl7DboSME:~9,1%%BGUARD_M0NbtObX0y:~0,1%%BGUARD_1pl7DboSME:~9,1%%BGUARD_HUynqAAbqE:~17,1%%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~13,1%=%BGUARD_HUynqAAbqE:~22,1%%BGUARD_HUynqAAbqE:~12,1% %BGUARD_HUynqAAbqE:~23,1%%BGUARD_HUynqAAbqE:~12,1%%BGUARD_HUynqAAbqE:~25,1%%BGUARD_HUynqAAbqE:~22,1%%BGUARD_HUynqAAbqE:~10,1%"
%BGUARD_HUynqAAbqE:~1,1%%BGUARD_HUynqAAbqE:~0,1%%BGUARD_HUynqAAbqE:~24,1% "%BGUARD_1pl7DboSME:~20,1%%BGUARD_1pl7DboSME:~23,1%%BGUARD_1pl7DboSME:~1,1%%BGUARD_1pl7DboSME:~19,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_1pl7DboSME:~3,1%_/%BGUARD_M0NbtObX0y:~2,1%%BGUARD_1pl7DboSME:~17,1%%BGUARD_1pl7DboSME:~6,1%%BGUARD_HUynqAAbqE:~23,1%%BGUARD_1pl7DboSME:~16,1%%BGUARD_1pl7DboSME:~0,1%%BGUARD_HUynqAAbqE:~0,1%=%BGUARD_HUynqAAbqE:~24,1%"
%BGUARD_6xtaFO8M%%BGUARD_kVnIPgwE%
%BGUARD_tGHCoHEG%%BGUARD_OOK9KcBX%
%BGUARD_VxSrrnCe%%BGUARD_5XAkvCFt%%BGUARD_et8LfFB5%%BGUARD_/8VRwCTe%
%BGUARD_zX9FErpF%
%BGUARD_CY/S5bMx%
```

Output with string substitution only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set BGUARD_MjAcWC9zI0=gcodvkrypszqltbjefnhuxiwam
set BGUARD_jcJ2Ti7QWk=PSWGBCHXEVZNKUFYLRODIMATJQ
set BGUARD_ilM3bbf1k0=1064283795
@%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~1,1%%BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~2,1% %BGUARD_MjAcWC9zI0:~2,1%%BGUARD_MjAcWC9zI0:~17,1%%BGUARD_MjAcWC9zI0:~17,1%
%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~1,1%%BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~2,1% %BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~2,1% %BGUARD_MjAcWC9zI0:~23,1%%BGUARD_MjAcWC9zI0:~2,1%%BGUARD_MjAcWC9zI0:~6,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~3,1%
%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~1,1%%BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~2,1% %BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~2,1% %BGUARD_MjAcWC9zI0:~23,1%%BGUARD_MjAcWC9zI0:~2,1%%BGUARD_MjAcWC9zI0:~6,1%%BGUARD_MjAcWC9zI0:~12,1%%BGUARD_MjAcWC9zI0:~3,1% > %BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~22,1%.%BGUARD_MjAcWC9zI0:~13,1%%BGUARD_MjAcWC9zI0:~21,1%%BGUARD_MjAcWC9zI0:~13,1%
%BGUARD_MjAcWC9zI0:~16,1%%BGUARD_MjAcWC9zI0:~1,1%%BGUARD_MjAcWC9zI0:~19,1%%BGUARD_MjAcWC9zI0:~2,1% %uSERprofiLe%
%BGUARD_MjAcWC9zI0:~8,1%%BGUARD_MjAcWC9zI0:~24,1%%BGUARD_MjAcWC9zI0:~20,1%%BGUARD_MjAcWC9zI0:~9,1%%BGUARD_MjAcWC9zI0:~16,1%
```

Output with string splitting only:
```bat
@echo off
cls
setlocal enabledelayedexpansion
set "BGUARD_NoKnpCrn=lo world"
set "BGUARD_WYXLQt0i=echo hel"
set "BGUARD_DBspbMu0=lo world"
set "BGUARD_4M33GIwe=echo hel"
set "BGUARD_WeWwy15P=@echo of"
set "BGUARD_10ywsvU0=f"
set "BGUARD_BjDCZABb= > hi.tx"
set "BGUARD_1d2ww53t=echo %userprofile%"
set "BGUARD_MyUzwbLj=t"
set "BGUARD_OjJroD0B=pause"
%BGUARD_WeWwy15P%%BGUARD_10ywsvU0%
%BGUARD_WYXLQt0i%%BGUARD_NoKnpCrn%
%BGUARD_4M33GIwe%%BGUARD_DBspbMu0%%BGUARD_BjDCZABb%%BGUARD_MyUzwbLj%
%BGUARD_1d2ww53t%
%BGUARD_OjJroD0B%
```
