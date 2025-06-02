module AgentDiscordBot.Commands.Commands.Moraj
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/emojis/1029835643834077315.webp?size=1024&quality=lossless"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "7896133a-b6e7-4f25-a738-a6ac591f59b5" |> Result.get)
        [| "морай" |]
        "<@authorMention> изображает Морая:"
        true
        "<:catPleased:1041855910626213949>"
        false
        "<@authorMention> изображает Морая <@targetMention>:"
        true

