module AgentDiscordBot.Commands.Commands.Glazastaja
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "2f734cc5-d6ee-4bc7-8414-de010dbda7c8" |> Result.get)
        {
            Names = [| "глазастая" |]

            OnSelf = [|
                createReaction
                    "<@authorMention> изображает Глазастую 🐑:\n — Я тигр в овечьей шкуре!"
                    "https://media.tenor.com/PdVv4qj2u8YAAAAC/boki-boki-world.gif"
            |]

            OnBot = [|
                createReactionDescription "<:catPleased:1029834035679199312>"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> изображает Глазастую 🐑:\n — Я тигр в овечьей шкуре!"
                    "https://media.tenor.com/PdVv4qj2u8YAAAAC/boki-boki-world.gif"
            |]

            Cooldownable = None
        }
