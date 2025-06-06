module AgentDiscordBot.Commands.Commands.Flowers
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/aNQO4rue0dUAAAAd/flowers-good.gif"
            "https://media.tenor.com/ZLJtOJ55pFcAAAAd/morning-sunshine.gif"
            "https://media.tenor.com/DA27MkM7jBAAAAAC/bloomfleur-roses-roses.gif"
            "https://cdn.discordapp.com/attachments/947576023560634459/1126040949995343882/95oaItmMboY.jpg"
            "https://cdn.discordapp.com/attachments/947576023560634459/1126040950238621707/3sd71ovHeaA.jpg"
            "https://cdn.discordapp.com/attachments/947576023560634459/1126040950452523078/eyDJogn0cqc.jpg"
            "https://cdn.discordapp.com/attachments/947576023560634459/1126040950762909767/ote_7JCOr3c.jpg"
            "https://cdn.discordapp.com/attachments/947576023560634459/1126040951299780701/qfhJ5YUUP9w.jpg"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "b3ff9bb9-1a2e-4696-9833-2f49d06fb60c" |> Result.get)
        [| "цветы"; "flowers" |]
        "Любуется цветами <:catPleased:1041855910626213949>"
        gifs
        "<:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> дарит цветы <@targetMention>:"
        gifs
