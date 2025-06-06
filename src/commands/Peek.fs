module AgentDiscordBot.Commands.Commands.Peek
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://c.tenor.com/zKH6YcN6-rsAAAAd/kingking.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "36fb4d93-7bcc-4f5f-926c-5e1812bf8d5e" |> Result.get)
        [| "выглянуть"; "выглядывает"; "выглядывание" |]
        "У <@authorMention> выглядывает:"
        true
        "Хватит выглядывать — пора действовать!"
        false
        "<@authorMention> подглядывает за <@targetMention>:"
        true
