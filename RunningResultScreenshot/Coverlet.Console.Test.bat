@echo off

@cd ..
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

@pause