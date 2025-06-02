module AgentDiscordBot.Commands.Commands.Tail
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://c.tenor.com/_SHZ8ZyLYL8AAAAC/flirty-flirt.gif"
        "https://c.tenor.com/bNSOiEO_0loAAAAd/cat-tail.gif"
        "https://c.tenor.com/TnXmJgMoU5IAAAAC/cat-tail.gif"
        "https://c.tenor.com/kWJaRBz4jzYAAAAC/elephant-omg.gif"
        "https://media.tenor.com/NaaUB2i0EjsAAAAd/cat-lazy.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "177afdd0-c24c-4b16-bc17-c8ff9dcf1c9a" |> Result.get)
        [| "хвост"; "махатьХвостом"; "tail" |]
        "Нельзя себе хвостом махать, хотя..."
        "Мне не нужно хвостом махать! :scream_cat:"
        "<@targetMention>, <@authorMention> машет тебе хвостом."
