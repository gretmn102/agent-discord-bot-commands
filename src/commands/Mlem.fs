module AgentDiscordBot.Commands.Commands.Mlem
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "15ed1339-5db5-40f5-b149-b05cd88445e0" |> Result.get)
        [| "млем" |]
        "<@authorMention> млемает:"
        [|
            "https://media.tenor.com/BZGFIFd4vZcAAAAC/mclovin-cat.gif"
        |]
        "<@authorMention>, не надо млемать на меня, бип-буп."
        [||]
        "<@authorMention> млемает на <@targetMention>:"
        [|
            "https://media.tenor.com/BZGFIFd4vZcAAAAC/mclovin-cat.gif"
        |]
