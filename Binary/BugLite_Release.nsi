Name "BugLite"
OutFile "BugLite_Setup-${MyTIMESTAMP}.exe"
InstallDir "$DESKTOP\BugLite"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Release\net9.0-windows\BugLite.Library.dll"
  File /r ".\Release\net9.0-windows\BugLite.dll"
  File /r ".\Release\net9.0-windows\BugLite.exe"
  File /r ".\Release\net9.0-windows\*.json"
SectionEnd ; end the section
