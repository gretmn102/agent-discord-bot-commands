module AgentDiscordBot.Commands.Commands.Catapult
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "a9817f5c-c091-46af-8545-277507d6278b" |> Result.get)
        {
            Names = [|
                "catapult"
                "катапульта"
                "катапультировать"
                "катапультироваться"
                "катапультируется"
                "катапультирование"
            |]

            OnSelf = [|
                createReaction
                    "<@authorMention> катапультируется вдаль 🗻"
                    "https://media1.tenor.com/m/J7Ooz9dg-y8AAAAd/lfgoat-goatsby.gif"
                createReaction
                    "<@authorMention> катапультируется в гущу битвы ⚔️"
                    "https://media.tenor.com/NvOAfs4weF0AAAAd/jump-launched.gif"
                createReaction
                    "<@authorMention> случайно катапультирует себя 😱"
                    "https://media.tenor.com/GB7PMPpWelEAAAAd/ardilla.gif"
            |]

            OnBot = [|
                createReactionDescription "Кыш 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> катапультирует свои трусы 👖 в <@targetMention>"
                    "https://media.tenor.com/5i3PQD_wkVcAAAAd/pete-%26-pete-pete-y-pete.gif"
                createReaction
                    "<@authorMention> катапультирует <@targetMention> в космос 🌌"
                    "https://media.tenor.com/SpkgwensT5cAAAAd/sling-shot-boing.gif"
                createReaction
                    "<@authorMention> катапультирует <@targetMention> в горы 🗻"
                    "https://media.tenor.com/f0ktS94Y1EwAAAAd/catapult-joe-smol-joe.gif"
            |]

            Cooldownable = None
        }
