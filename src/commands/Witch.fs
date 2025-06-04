module AgentDiscordBot.Commands.Commands.Witch
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/933317410465923082/1169723611322532111/IMG_20231102_223542.jpg"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "24062599-0f5b-4e6e-aada-f2b7e4cebcbd" |> Result.get)
        [| "ведьма" |]
        "Ведьма:"
        gifs
        "<:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> превращает в ведьму <@targetMention>:"
        gifs
