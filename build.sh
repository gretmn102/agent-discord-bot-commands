#!/bin/bash

dotnet tool restore
dotnet paket install
# dotnet build -c Release
dotnet run --project src/AgentDiscordBotCommands.fsproj
