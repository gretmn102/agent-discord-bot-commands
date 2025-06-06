module AgentDiscordBot.Commands.Commands.Agent
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/859253126878724126/965700589084377168/unknown.png"
        "https://media.tenor.com/CbWKthhbhEoAAAAC/insane-fast-typing-cat.gif"
        "https://media.tenor.com/DaSh5T93TgUAAAAC/cat-typing.gif"
        "https://cdn.discordapp.com/emojis/756060948355088394.png"
        "https://media.tenor.com/374vowhWlt4AAAAC/dog-cute.gif"
        "https://media.tenor.com/uoAnIlKgLSUAAAAd/what-cat.gif"
        "https://cdn.discordapp.com/attachments/1011244894020456488/1050386943571136573/IMG_20221208_152214_516.jpg"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "9ec79d65-052b-461f-acba-9c91a3302ac1" |> Result.get)
        [| "агент" |]
        "<@authorMention> изображает Агента:"
        true
        "<:catPleased:1041855910626213949>"
        false
        "<@authorMention> изображает Агента <@targetMention>:"
        true

