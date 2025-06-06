module AgentDiscordBot.Commands.Commands.Badminton
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/n_oO2zHlSaUAAAAC/cats-badminton.gif"
            "https://media.tenor.com/5PgcK3LE1N0AAAAC/badminton-pelota.gif"
            "https://media.tenor.com/o6KPGhIAIv0AAAAC/badminton-smash.gif"
            "https://media.tenor.com/fseiuoIEMhMAAAAC/badminton-studio-eeksaurus.gif"
            "https://media.tenor.com/A7BNTBOsOcQAAAAC/sechi-youtube.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "ed2d4648-949a-4d56-adfe-75cf1f5ebbe9" |> Result.get)
        [| "бадминтон" |]
        "<@authorMention> играет в бадминтон 🏸"
        gifs
        "<:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> играет в бадминтон с <@targetMention> 🏸"
        gifs
