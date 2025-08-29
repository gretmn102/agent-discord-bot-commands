module AgentDiscordBot.Commands.Commands.FairyTail
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "ac84c916-d368-4177-9e9d-6debc59b4476" |> Result.get)
        [| "сказка"; "fairyTail" |]
        "<@authorMention> читает сказку:"
        [|
            // https://tenor.com/view/membaca-reading-military-strategy-cat-flipping-pages-gif-16640449
            "https://c.tenor.com/Lj5SFh_tVzkAAAAC/books-read.gif"
            "https://c.tenor.com/Vucu5O0U4FAAAAAC/cat-kitten.gif"
            "https://c.tenor.com/415n58OZ9CYAAAAd/cat-reads-reading.gif"
            "https://c.tenor.com/dtAQHKf2_OsAAAAC/pusheen-witch.gif"
            "https://c.tenor.com/2hatW6KUSS8AAAAC/reading-read.gif"
        |]
        "<@authorMention>, мне не нужно сказки читать! :scream_cat:"
        [||]
        "<@authorMention> читает сказку для <@targetMention>"
        [|
            // кот на книгах с надписью "Что читаем?". Альтернатива — https://tenor.com/view/pk3-writing-gif-8071370
            "https://c.tenor.com/Yw68weAL6c0AAAAC/knigi-kniga.gif"
        |]
