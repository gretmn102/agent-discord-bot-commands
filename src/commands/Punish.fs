module AgentDiscordBot.Commands.Commands.Punish
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/1074262266880466965/1074262416944283648/fa5dac8bf1f0a16f9c4330d8dfc64042.gif"
            "https://cdn.discordapp.com/attachments/1074262266880466965/1074262417254658108/a8c0789126e3711f87842b55024e0419.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "22481f64-d591-4b3f-8a72-ef7cd3ea01b1" |> Result.get)
        [| "наказать"; "отшлепать" |]
        "<@authorMention> шлепать:"
        gifs
        "<@authorMention>, никакого шлепа в мою смену! <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> шлепает <@targetMention>:"
        gifs
