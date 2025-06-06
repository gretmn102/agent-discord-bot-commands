module AgentDiscordBot.Commands.Commands.Take
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://c.tenor.com/ccxh_NDfHXMAAAAC/carry-her-lift.gif"
        "https://c.tenor.com/ytkH6MSlE4EAAAAC/love-relationship.gif"
        "https://c.tenor.com/TFleYTQhTCEAAAAC/arm-carry-cute.gif"
        "https://c.tenor.com/OulTpS0kWYMAAAAC/madison-beer.gif"
        "https://c.tenor.com/CMD-o3NJdV4AAAAC/wonder-woman-lovers-carry.gif"
        "https://c.tenor.com/3Qmu-zdjFIwAAAAC/carry-shoulder.gif"
        "https://c.tenor.com/ydSMRf34XvEAAAAC/spin-carry.gif"
        "https://c.tenor.com/Uuo1-iiB-AcAAAAM/couple-hug.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "70704d5a-5e2d-42d8-937c-97a7a4127e6d" |> Result.get)
        [| "take" |]
        "Самого себя нельзя на руках носить :eyes:"
        "Меня не нужно носить! :scream_cat:"
        "<@authorMention> носит на ручках <@targetMention>"
