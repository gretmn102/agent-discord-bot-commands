module AgentDiscordBot.Commands.Commands.Sommelier
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "8449c671-1076-4fc8-a205-04bd0d1cc3c3" |> Result.get)
        {
            Names = [|
                "дегустатор"; "дегустирует"; "дегустировать"; "дегустация"
            |]

            OnSelf = [|
                createReaction
                    "<@authorMention> дегустирует вино:"
                    "https://c.tenor.com/bf0xo_6W-yYAAAAC/tenor.gif"
            |]

            OnBot = [|
                createReactionDescription "Никаких дегусташек в мою смену! 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> дегустирует вино:"
                    "https://c.tenor.com/bf0xo_6W-yYAAAAC/tenor.gif"
            |]

            Cooldownable = None
        }
