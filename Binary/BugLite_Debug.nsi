Name "BugLite"
OutFile "BugLite.exe"
InstallDir "$DESKTOP\BugLite"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Debug\net9.0-windows\BugLite.Library.dll"
  File /r ".\Debug\net9.0-windows\BugLite.dll"
  File /r ".\Debug\net9.0-windows\BugLite.exe"
  File /r ".\Debug\net9.0-windows\*.json"
  File /r ".\Debug\net9.0-windows\*.ico"
  
  File "..\*.toml"
SectionEnd ; end the section
