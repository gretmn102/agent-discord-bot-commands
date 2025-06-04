module AgentDiscordBot.Commands.Commands.Snow
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "501e5b5b-3dba-4dc7-ac67-a3ef01105162" |> Result.get)
        [| "снежок" |]
        "<@authorMention> ловит снежок:"
        [|
            "https://media.tenor.com/AxE3ljKF0xAAAAAd/cat-cats.gif"
            "https://media.tenor.com/UGpGSqdp-3AAAAAC/cat-catch.gif"
        |]
        "<@authorMention>, это кто там снежком бросается, бип-буп? <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> бросает снежок в <@targetMention>:"
        [|
            "https://media.tenor.com/48IYu9PI9wMAAAAC/man-throw.gif"
            "https://media.tenor.com/jySu4lBl_loAAAAd/snowman-snowball.gif"
            "https://media.discordapp.net/attachments/906094410901643334/922919964669780038/9d32a24a8811.gif"
        |]
