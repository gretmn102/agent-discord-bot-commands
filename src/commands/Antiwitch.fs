module AgentDiscordBot.Commands.Commands.Antiwitch
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let reactions =
        [|
            createReaction
                "<@authorMention> колет антиведьмин <@targetMention>"
                "https://cdn.discordapp.com/attachments/927554008263032836/1280590448481669128/Picsart_24-08-27_18-59-52-169.png"
        |]

    Command.create
        (CommandId.tryDeserialize "58f9d5d4-ec9e-4581-8a86-c2d1be734839" |> Result.get)
        {
            Names = [| "антиведьмин" |]

            OnSelf = reactions

            OnBot = [|
                createReactionDescription "Кыш 😾"
            |]

            OnOther = reactions

            Cooldownable = None
        }
