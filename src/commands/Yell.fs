module AgentDiscordBot.Commands.Commands.Yell
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/Lg21skpXtU4AAAAC/cat-meme.gif"
            "https://media.tenor.com/PGnGqfkIuLYAAAAC/cat-head.gif"
            "https://media.tenor.com/_zVIdn3Ok_cAAAAC/cat-scream.gif"
            "https://media.tenor.com/t5HqHfs2_sEAAAAC/cat-kitten.gif"
            "https://media.tenor.com/bQuWIFsZWEgAAAAC/thurston-waffles-meow.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "12d022d6-7e44-429e-8c46-178ea8fa1e27" |> Result.get)
        [| "орать"; "орет"; "орёт"; "кричит"; "кричать" |]
        "<@authorMention> кричит:"
        gifs
        "<@authorMention>, никакого ора в мою смену! <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> кричит на <@targetMention>:"
        gifs
