module AgentDiscordBot.Commands.Commands.Roman
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let reactions =
        [|
            createReaction
                "<@authorMention> изображает Романа:"
                "https://cdn.discordapp.com/attachments/1162103667969765519/1274020343039918090/RomanRipLog.gif"
            createReaction
                "<@authorMention> изображает Романа:"
                "https://cdn.discordapp.com/attachments/930127222373777509/1287108434629754921/apepeGachi.gif"
        |]

    Command.create
        (CommandId.tryDeserialize "46b21435-5207-428c-92d5-a2f4697006ef" |> Result.get)
        {
            Names = [|
                "роман"
            |]

            OnSelf = reactions

            OnBot = [|
                createReactionDescription "Никаких Романов в мою смену! 😾"
            |]

            OnOther = reactions

            Cooldownable = None
        }

