module AgentDiscordBot.Commands.Commands.Drama
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/igJNrzoEWiwAAAAC/faint-drama.gif"
        "https://media.discordapp.net/attachments/859253126878724126/1090804061676244992/output.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "d158506e-27a7-41f1-bca2-8fb9d6a9dbdb" |> Result.get)
        [| "драма" |]
        "<@authorMention> изображает королеву драмы:"
        true
        "Тщетны твои <:Demon_Kingsmile:877678191693692969>"
        false
        "<@authorMention> изображает королеву драмы перед <@targetMention>:"
        true
