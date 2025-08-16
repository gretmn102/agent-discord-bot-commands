module AgentDiscordBot.Commands.Commands.StealPantsu
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "0cd53a9e-051e-467d-846f-c49e2d21e2a1" |> Result.get)
        {
            Names = [|
                "stealPantsu"
                "stealUnderwear"
                "украстьТрусы"
                "украстьТрусики"
            |]

            OnSelf = [|
                createReaction
                    "<@authorMention> надевает себе на голову чьи-то трусы 👖"
                    "https://media.tenor.com/t3JzHhZ01UAAAAAd/kstr-kochstrasse.gif"
                createReaction
                    "<@authorMention> радуется улову 👖"
                    "https://cdn.discordapp.com/emojis/624254380866142228.png?size=1024"
            |]

            OnBot = [|
                createReactionDescription "Кыш 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> крадет трусы 👖 у <@targetMention>"
                    "https://media.tenor.com/2XZMDsfdPcAAAAAd/underwear-steal.gif"
                createReaction
                    "<@authorMention> крадет розовые трусики 👖 с сердечком у <@targetMention>"
                    "https://cdn.discordapp.com/emojis/852649802772119562.png?size=1024"
                createReaction
                    "<@authorMention> стягивает трусики 👖 с <@targetMention>"
                    "https://media.tenor.com/La79v3H4fcAAAAAd/panties-cats.gif"
            |]

            Cooldownable = None
        }
