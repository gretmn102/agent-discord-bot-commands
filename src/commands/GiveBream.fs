module AgentDiscordBot.Commands.Commands.GiveBream
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "02e5809c-7623-4c6d-9d33-f7cbba75de46" |> Result.get)
        {
            Names = [|
                "giveBream"
                "датьЛеща"
            |]

            OnSelf = [|
                createReactionDescription
                    "Зачем себе давать леща, если можно дать другому? <:Demon_Kingsmile:877678191693692969>"
            |]

            OnBot = [|
                createReactionDescription "Кыш 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> выстреливает лещом в <@targetMention>"
                    // https://tenor.com/view/fish-cannon-gif-14801380928410168204
                    "https://media.tenor.com/zWkRiIchK4wAAAAd/fish-cannon.gif"
            |]

            Cooldownable = None
        }
