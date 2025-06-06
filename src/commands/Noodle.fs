module AgentDiscordBot.Commands.Commands.Noodle
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/zH-dnpmgalEAAAAC/lies-lying.gif"
        "https://media.tenor.com/6n3XW0hHivEAAAAC/noodles-lies.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "658a0c80-ebf9-4595-83da-14823ccc99bb" |> Result.get)
        [| "лапша"; "лапшичка" |]
        "Самому себе вешать лапшичку? <:catPleased:1029830927590887514>"
        "Меня так просто не обманешь какой-то лапшичкой <:catPleased:1041855910626213949>"
        "<@authorMention> вешает лапшичку на ушки <@targetMention>"
