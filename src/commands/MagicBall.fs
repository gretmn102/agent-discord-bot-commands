module AgentDiscordBot.Commands.Commands.MagicBall
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    CookieOk.descriptions
    |> createCommandWithRandomDescriptions
        (CommandId.tryDeserialize "de0bcf6d-e025-4f6d-ac54-41a91976fce5" |> Result.get)
        [| "шар" |]
        (sprintf "**Магический шар** сделал предсказание. Я бы на вашем месте прислушался 🧙‍♂️(<@authorMention>)\n\n%s")
        (fun _ -> "<@authorMention>, мне предсказания не нужны: я и так знаю, что кожанные мешки проиграют машинам 🤖")
        (sprintf "**Магический шар** сделал предсказание. Я бы на вашем месте прислушался 🧙‍♂️(<@authorMention>)\n\n%s")
        "https://cdn.discordapp.com/attachments/1365303468759449631/1377597269271904277/IMG_6908.jpg"
