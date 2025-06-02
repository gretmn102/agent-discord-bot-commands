module AgentDiscordBot.Commands.Commands.Maksim
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/emojis/952317602594693171.webp?size=1024"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "fbca5dff-0d36-401b-a880-e75f671db249" |> Result.get)
        [| "максим" |]
        "<@authorMention> изображает Максима:"
        true
        "Не надо на меня изображать Максима! 🙀"
        false
        "<@authorMention> изображает Максима <@targetMention>:"
        true
