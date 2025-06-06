module AgentDiscordBot.Commands.Commands.Lina
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/927554008263032836/1047936865258459156/image0.gif"
        "https://media.tenor.com/Vt41WQiX4MwAAAAC/singing-littlebitofab.gif"
        "https://media.tenor.com/vW6-Vnyvu3kAAAAC/budding-pop-sing.gif"
        "https://cdn.discordapp.com/attachments/928223332019609610/1187448973976412311/IMG_2430.png"
        "https://cdn.discordapp.com/attachments/929387581194510347/1188129150196789339/IMG_2437.png"
        "https://cdn.discordapp.com/attachments/929387581194510347/1188129150637179000/IMG_2438.png"
        "https://cdn.discordapp.com/attachments/929387581194510347/1188129150972727347/IMG_2439.png"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "08c84eb2-d430-44d3-8618-698a1adf90b5" |> Result.get)
        [| "линочка"; "лина" |]
        "<@authorMention> изображает Линочку:"
        true
        "Не надо на меня изображать Линочку! 🙀"
        false
        "<@authorMention> изображает Линочку <@targetMention>:"
        true

