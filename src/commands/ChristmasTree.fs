module AgentDiscordBot.Commands.Commands.ChristmasTree
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let urls =
        [|
            "https://media.tenor.com/g3UwgAuiDWUAAAAd/cat-viralhog.gif"
            "https://media.tenor.com/utCF57nJhY0AAAAd/cat-tree.gif"
            "https://media.tenor.com/2SFJCV0M6r8AAAAd/cat-cats.gif"
            "https://media.tenor.com/6aSwChrWuhcAAAAC/cats-pull.gif"
            "https://media.tenor.com/3atPsShb-p0AAAAd/christmas-tree-fell-on-the-cat-viralhog.gif"
            "https://media.tenor.com/tr-LVhGZoGUAAAAd/cat-tree-cat-christmas-tree.gif"
            "https://media.tenor.com/Z2Z1-qwoZkoAAAAd/cat-xmas.gif"
            "https://media.tenor.com/fV7M7ji-JbkAAAAd/cat-vs-ornament-cat.gif"
            "https://media.tenor.com/PVexpkgAwoIAAAAd/cat-christmas-flying-xmas-cat.gif"
            "https://cdn.discordapp.com/attachments/927554008263032836/1058352914072096828/GIF-8672460d3336fa6d01b9be872b5d77f2.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "66486c02-9fff-47eb-baad-2930b4c6e432" |> Result.get)
        [| "ёлка"; "елка" |]
        "<@authorMention> играется с ёлкой:"
        urls
        "<@authorMention>, не трогай ёлку, бип-буп!"
        [||]
        "<@authorMention> валит ёлку <@targetMention>:"
        urls
