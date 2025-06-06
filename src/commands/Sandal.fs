module AgentDiscordBot.Commands.Commands.Sandal
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "61750519-7339-4efa-9387-6a1952a4fd67" |> Result.get)
        {
            Names = [| "тапкой"; "sandal"; "тапком"; "тапок" |]

            OnSelf = [|
                createReaction
                    "<@authorMention> вызывает дрожь земли 🩴"
                    "https://media.tenor.com/LBucbyE7WlAAAAAd/tkthao219-ami.gif"
                createReaction
                    "<@authorMention> 🩴🩴🩴🩴"
                    "https://media.tenor.com/S566P-Wuzk0AAAAd/chappal-doctor-strange.gif"
                createReaction
                    "<@authorMention> бунтует против 🩴"
                    "https://media.tenor.com/L7NcsoXJiLMAAAAd/shake-viralhog.gif"
            |]

            OnBot = [|
                createReactionDescription "Тапок обращается против тебя 😾 🩴"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> готовится дать тапкой <@targetMention> 🩴"
                    "https://media.tenor.com/4mOChN5MH-EAAAAd/courage-the-cowardly-dog-slipper.gif"
                createReaction
                    "<@authorMention> кидает тапкой в <@targetMention> 🩴"
                    "https://media.tenor.com/ojSIME25ciAAAAAd/slippers-shoes.gif"
                createReaction
                    "<@authorMention> грозится дать тапкой <@targetMention> 🩴"
                    "https://media.tenor.com/uf3So0iE144AAAAj/bubu-dudu-bubu-dudu-angry.gif"
                createReaction
                    "<@authorMention> грозится дать тапкой <@targetMention> 🩴"
                    "https://media.tenor.com/LBucbyE7WlAAAAAd/tkthao219-ami.gif"
                createReaction
                    "<@authorMention> дает больно тапкой по <@targetMention> 🩴"
                    "https://media.tenor.com/nSNmH8PL2_sAAAAd/angry-beating.gif"
                createReaction
                    "<@authorMention> запускает тапок в <@targetMention> 🩴"
                    "https://media.tenor.com/Vy-J_T0Tn3sAAAAd/notforthinking-sandal.gif"
            |]

            Cooldownable = None
        }
