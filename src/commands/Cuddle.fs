module AgentDiscordBot.Commands.Commands.Cuddle
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "8da29f55-fb38-4de9-b40b-caa9a0cba489" |> Result.get)
        [| "ластиться"; "ластится"; "тереться" |]
        "<@authorMention> ластится:"
        [|
            "https://media.tenor.com/QYQ6fTqCdrEAAAAd/manul-pallas-cat.gif"
        |]
        "<@authorMention>, на меня это не работает <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> ластится к <@targetMention>:"
        [|
            "https://media.tenor.com/GKzrBpqjBzMAAAAd/cute-cat.gif"
            "https://media.tenor.com/oepLIJup6kIAAAAd/wet-hair.gif"
            "https://media.tenor.com/UW1xc68-KXkAAAAd/funny-animals-cats.gif"
            "https://media.tenor.com/twkOV4hc7JUAAAAd/kitty-cat.gif"
        |]
