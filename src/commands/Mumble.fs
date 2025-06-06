module AgentDiscordBot.Commands.Commands.Mumble
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/1034059525495455764/1048528679719927848/cat-weird-cat-fun.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1048528680051298314/funny-cat.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1048530139685863524/cat-cat-talking.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1048531380813963264/black-cat-cat.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "4a50f87a-d729-4640-be77-cb910611d5b6" |> Result.get)
        [| "бурчать"; "бурчит"; "бубубу"; "бубу" |]
        "<@authorMention> бурчит под нос:"
        true
        "Не надо на меня бурчать, я и так стараюсь, как могу! 🙀"
        false
        "<@authorMention> бурчит на <@targetMention>:"
        true

