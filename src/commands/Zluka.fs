module AgentDiscordBot.Commands.Commands.Zluka
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =

    let reactions =
        [|
            createReaction
                "<@authorMention> изображает Злюку:"
                "https://cdn.discordapp.com/attachments/927554008263032836/1271880268289933333/IMG_20240719_013304.jpg"
            createReaction
                "<@authorMention> изображает Злюку:"
                "https://c.tenor.com/93FZJSBvwfEAAAAd/tenor.gif"
            createReaction
                "<@authorMention> изображает Злюку:"
                "https://cdn.discordapp.com/attachments/927554008263032836/1271883564903825450/IMG_20240801_173118_316.jpg"
            createReaction
                "<@authorMention> изображает Злюку:"
                "https://cdn.discordapp.com/attachments/929387581194510347/1271885445189603449/20240607_191138-removebg-preview.png"
            createReaction
                "<@authorMention> изображает Злюку:"
                "https://cdn.discordapp.com/attachments/929387581194510347/1279046022609240165/Screenshot_20240826_173627_org.mozilla.firefox-removebg-preview.png"
        |]

    Command.create
        (CommandId.tryDeserialize "17429368-0def-4767-be39-1fd0d40635eb" |> Result.get)
        {
            Names = [|
                "злюка"
            |]

            OnSelf = reactions

            OnBot = [|
                createReactionDescription "Никаких злюк в мою смену! 😾"
            |]

            OnOther = reactions

            Cooldownable = None
        }
