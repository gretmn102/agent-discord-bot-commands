module AgentDiscordBot.Commands.Commands.Viola
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/935544768937721946/1120789700504985630/20230620_200402.jpg"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "f61d9c19-1b7f-4e79-8048-b526bc882c99" |> Result.get)
        [| "виолка" |]
        "<@authorMention>, изображает Виолку:"
        gifs
        "<:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> изображает Виолку <@targetMention>:"
        gifs
