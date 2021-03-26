for /r %%i in (*.cue, *.gdi *.cdi) do chdman createcd -i "%%i" -o "%%~ni.chd"
pause