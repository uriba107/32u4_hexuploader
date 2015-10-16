@echo off
set comport=%1
set hexfile=%2
set avrdudepath=%CD%\bin\avrdude

%avrdudepath%\avrdude.exe -v -cavr109 -patmega32u4 -P%comport% -b57600 -D -Uflash:w:%hexfile%:i
REM pause