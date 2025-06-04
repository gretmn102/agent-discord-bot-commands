module AgentDiscordBot.Commands.Commands.Hug
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "bee17367-86f6-4a35-a6ff-64d2188f3810" |> Result.get)
        [| "обнять" |]
        "<@authorMention> обнимает себя 🤗"
        [||]
        "<@authorMention>, я слишком холодный для всего этого, бип-буп."
        [||]
        "<@authorMention> обнимает <@targetMention>:"
        [|
            "https://media.tenor.com/KbM-vf5iJ0cAAAAd/cats-hug.gif"
            "https://media.tenor.com/IH3q87oSV5EAAAAd/cat-hug.gif"
            "https://media.tenor.com/_w6z-q2Z8xEAAAAd/goodnite-moomoo.gif"
            "https://media.tenor.com/eAKshP8ZYWAAAAAC/cat-love.gif"
            "https://media.tenor.com/kBlRhi7nqYwAAAAd/cat-hugs-alydn.gif"
            "https://media.tenor.com/uxo1ef9EdxQAAAAd/cat-cats.gif"
        |]
