module AgentDiscordBot.Commands.Commands.Poke
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/946817848397934643/1185166928310964244/poke-stop.gif"
            "https://cdn.discordapp.com/attachments/946817848397934643/1185166928747167764/tabatinga.gif"
            "https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExNXNwamhsMmlkeWU4Y3duaGtqNXcwcTl2ZXA4M2F4cGUzOXZxaXh0MyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/XSgTZVb2evZYJe3oyC/giphy.gif"
            "https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExOHF1ZHM2bHQ4cnFtYjNuMHR3ZXU3em9naGQ2bG83YjdvYTJmamEyNCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/3ohfFH3gJpepwS5DEY/giphy.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "7b2a48cd-558a-4252-9243-ce0e05484897" |> Result.get)
        [| "тык" |]
        "<@authorMention> тыкает:"
        gifs
        "<@authorMention>, не надо меня тыкать 🙀"
        [||]
        "<@authorMention> тыкает <@targetMention>:"
        gifs
