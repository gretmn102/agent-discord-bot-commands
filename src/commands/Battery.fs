module AgentDiscordBot.Commands.Commands.Battery
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://c.tenor.com/X45Rd5nfc7oAAAAM/energize-energized.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "cacb2b96-0fdf-4c98-bed6-27aaf1bb364a" |> Result.get)
        [| "спетьБатарейку"; "battery" |]
        "Самому нельзя петь \"Батерей\"!"
        "Мне нельзя петь \"Батарейку\". Я этого не вынесу :scream_cat:"
        "<@authorMention> поет \"Батарейку\" <@targetMention>"
