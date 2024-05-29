@echo off
setlocal enabledelayedexpansion

rem Введення шляху до каталогу
set "directory=D:\Desktop\English"

rem Перевірка існування каталогу
if not exist "%directory%" (
    echo Каталог "%directory%" не знайдено.
    pause
    exit /b
)

rem Перехід до каталогу
cd /d "%directory%"

rem Перебір всіх підкаталогів у поточному каталозі
for /d %%D in (*) do (
    rem Перехід до підкаталогу
    cd "%%D"
    
    rem Підрахунок кількості файлів у підкаталозі
    set fileCount=0
    for %%F in (*) do (
        set /a fileCount+=1
    )
    
    rem Виведення назви підкаталогу і кількості файлів
    echo %%D : !fileCount!
    
    rem Повернення до початкового каталогу
    cd ..
)

endlocal
pause
