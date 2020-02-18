dotnet --version

dotnet new --help

dotnet new console

dotnet new --list

dotnet add package Newtonsoft.Json

dotnet restore

dotnet build

dotnet run

dotnet test

dotnet publish --configuration Release --output out

dotnet publish --configuration Release --output out --self-contained

dotnet publish --configuration Release --output out --self-contained --runtime win-x64 /p:PublishSingleFile=true /p:IncludeSymbolsInSingleFile=true

dotnet new console --name App --output App
dotnet add .\App\App.csproj padckage Colorful.Console
dotnet new classlib --name App.Shared --output Shared\App.Shared
dotnet add .\App\App.csproj reference .\Shared\App.Shared\App.Shared.csproj
dotnet new xunit --name App.Tests --output Tests/App.Tests
dotnet add .\Tests\App.Tests\App.Tests.csproj reference .\App\App.csproj
dotnet run --project .\App\App.csproj
dotnet test .\Tests\App.Tests\App.Tests.csproj

dotnet tool install --global dotnetsay


