# IdentityServer

## Migrations ( All Cmds in the root of the repository)

    Requirements 
    * dotnet new tool-manifest
    * dotnet tool install dotnet-ef

    Add Migration 
    * dotnet ef migrations add Initial -p Infrastructure/ -s WebUi/ -o Persistence/Migrations


    Remove Migration 
    * dotnet ef migrations remove -p Infrastructure/ -s WebUi/ 

    Database
    dotnet ef database update -s WebUI/ 
    dotnet ed database drop -s WebUI/ 

## Requirements

## Extras

* dotnet ef migrations add Initial -p Src/Infrastructure -s Src/WebUi -o Persistence/Migrations
