#!/bin/bash

dotnet run --project src/AgentDiscordBotCommands.fsproj
diff output-exp.json output.json
