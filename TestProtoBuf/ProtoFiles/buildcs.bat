rem Build code from protos
echo "Generating protos...
set PROTOC=C:\Utils\protoc-3.4.0-win32\bin\protoc.Exe

%PROTOC% --proto_path=%~dp0 --csharp_out=%~dp0 %~dp0\*.proto	
