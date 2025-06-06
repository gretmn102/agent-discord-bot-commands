module AgentDiscordBot.Commands.Commands.Plead
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/2UPCE4EQRi8AAAAC/please-begging.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "c974e9ee-3c56-4869-adcb-141d0388e3db" |> Result.get)
        [| "умолять"; "просить"; "умоляет" |]
        "<@authorMention> умоляет:"
        true
        "Тщетны твои мольбы <:Demon_Kingsmile:877678191693692969>"
        false
        "<@authorMention> умоляет <@targetMention>:"
        true
