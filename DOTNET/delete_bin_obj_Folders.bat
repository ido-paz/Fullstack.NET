cls
echo deleting program.cs
del /s /q program.cs
echo deleting UnitTest1.cs
del /s /q UnitTest1.cs
echo deleting *.csproj
del /s /q *.csproj

echo deleting bin folders
for /f %i in ('dir /a:d /s /b bin') do rd /s /q "%i"
echo deleting obj folders
for /f %i in ('dir /a:d /s /b obj') do rd /s /q "%i"
echo deleting vscode folders
for /f %i in ('dir /a:d /s /b .vscode') do rd /s /q "%i"
echo deleting vs folders
for /f %i in ('dir /a:d /s /b .vs') do rd /s /q "%i"
echo deleting demo folders
for /f %i in ('dir /a:d /s /b demo*') do rd /s /q "%i"
echo deleting node_modules folders
for /f %i in ('dir /a:d /s /b node_modules') do rd /s /q "%i"
