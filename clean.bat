
@echo off
rd /s /q .vs

pushd .
cd OpenSilverAppSettings

pushd .
cd OpenSilverAppSettings
rd /s /q bin
rd /s /q obj
popd

pushd .
cd OpenSilverAppSettings.Browser
del /q wwwroot\appsettings.json
rd /s /q bin
rd /s /q obj
popd

pushd .
cd OpenSilverAppSettings.Simulator
rd /s /q bin
rd /s /q obj
popd

popd
