module AgentDiscordBot.Commands.Commands.Jungledrum700
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/WPdR3okORxgAAAAC/random-unicorn-dance.gif"
            "https://media.tenor.com/dpuJWXr_PoUAAAAC/dog-unicorn.gif"
            "https://media.tenor.com/xD2H2paGBt4AAAAC/prizzzle-unicorn.gif"
            "https://media.tenor.com/zVTEnTPnkoAAAAAC/pink-unicorn.gif"
            "https://media.tenor.com/DRZAPu4XZokAAAAC/unicorn-headphones.gif"
        |]

    createCommandWithRandomImages3
        (CommandId.tryDeserialize "acd93fec-f5bf-4c2d-b31e-d94f2cc9c631" |> Result.get)
        [| "единорог"; "джангл" |]
        "<@authorMention> изображает Джангл 🦄"
        gifs
        "<:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> изображает Джангл <@targetMention> 🦄"
        gifs
