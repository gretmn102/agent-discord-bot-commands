module AgentDiscordBot.Commands.Commands.Run
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/Bev4TG664HQAAAAC/%D0%B1%D0%B5%D0%B6%D0%B8%D0%BC.gif"
        "https://media.tenor.com/nmY9uVcG-vkAAAAC/very-scary-movie2-priest.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "5b99c051-01c1-44f4-a531-55e2e927dec6" |> Result.get)
        [| "бежать"; "сбежать"; "сбегает" |]
        "<@authorMention> сбегает:"
        true
        "От меня не сбежать <:Demon_Kingsmile:877678191693692969>"
        false
        "<@authorMention> сбегает от <@targetMention>:"
        true

