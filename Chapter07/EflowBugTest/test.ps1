Write-Output "Text input should work here."
dotnet run

Invoke-EflowVmCommand -command 'sudo iotedge list'

Write-Output "`nText input should be hidden (and laggy) here. You will probably need to press enter twice."
dotnet run

Read-Host "`n`nText input should work here (using Read-Host)"

Write-Output "`nText input in C# should now work again."
dotnet run