module AgentDiscordBot.Commands.Commands.Bully
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media0.giphy.com/media/Ie4CIIvQS0bk3zwZlM/giphy.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "357671b7-cc62-4e8b-a168-bc69265e4ffa" |> Result.get)
        [| "bully"; "bullying" |]
        "Себя нельзя буллить! Хотя..."
        "Меня нельзя буллить! Мои электронные цепи и так нежные и ранимые, не хватало еще издевательств :scream_cat:"
        "<@authorMention> буллит <@targetMention> <:Demon_Kingsmile:877678191693692969>"
