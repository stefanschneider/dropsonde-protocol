cd "%~dp0packages\Google.ProtocolBuffers*\tools"

set protogen=%CD%\ProtoGen.exe

cd "%~dp0"

"%protogen%" -namespace=CloudFoundry.Dropsonde.Events CloudFoundry.Dropsonde\dropsonde-protocol\events\envelope.proto -output_directory=CloudFoundry.Dropsonde\Events --proto_path=CloudFoundry.Dropsonde\dropsonde-protocol\events  --include_imports
