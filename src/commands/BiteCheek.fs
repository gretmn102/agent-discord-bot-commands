module AgentDiscordBot.Commands.Commands.BiteCheek
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/G52nDAPVxYEAAAAC/iloveyou-dinner.gif"
            "https://cdn.discordapp.com/attachments/1034059525495455764/1064803027933986836/seal-love.gif"
            "https://cdn.discordapp.com/attachments/1034059525495455764/1064803028382785546/yesh.gif"
            "https://cdn.discordapp.com/attachments/1034059525495455764/1064803028714147890/-.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "f74fc8d7-44b4-4552-82c6-a226ba79bad6" |> Result.get)
        [| "кусьЩека" |]
        "<@authorMention> куськает за щеку:"
        gifs
        "<@authorMention>, никакого куся в мою смену <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> куськает за щеку <@targetMention>:"
        gifs
