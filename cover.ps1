dotnet test
coverlet .\Tests\bin\Debug\netcoreapp3.1\Tests.dll --target "dotnet" --targetargs "test Tests/Tests.csproj --no-build" --output "OpenCover.xml" --format opencover
reportgenerator -reports:"OpenCover.xml" -targetdir:"report"