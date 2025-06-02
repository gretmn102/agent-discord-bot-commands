module AgentDiscordBot.Commands.Commands.Svetlana
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/EKXJk3DT7asAAAAC/granny-samurai-prank.gif"
        "https://media.tenor.com/e11XngUvFJcAAAAd/funny-fight.gif"
        "https://media.tenor.com/IAWAXiLVq_QAAAAd/ski-jump-skiing.gif"
        "https://media.tenor.com/UqEPGGQJX1UAAAAC/ta-chegando.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "443c7b13-cced-4c0d-8c3c-ebe959451335" |> Result.get)
        [| "светлана" |]
        "<@authorMention> изображает Светлану:"
        true
        "Не надо на меня изображать Светлану! 🙀"
        false
        "<@authorMention> изображает Светлану <@targetMention>:"
        true
