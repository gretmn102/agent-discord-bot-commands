module AgentDiscordBot.Commands.Commands.Arrows
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://c.tenor.com/F3e-qN3UrOcAAAAC/cat-scratching.gif"
            "https://c.tenor.com/jwX64uKXt-gAAAAd/%D9%88%D9%82%D8%AA-%D8%A7%D9%84%D8%B9%D9%85%D8%A7%D8%B1%D9%8A.gif"
            "https://c.tenor.com/yz_7VcX0WjYAAAAS/cat-changing-the-clock-changing-the-time.gif"
            "https://cdn.discordapp.com/attachments/778999058965987378/1028774690992439407/unknown.png"
            "https://cdn.discordapp.com/attachments/778999058965987378/1028773979382620261/unknown.png"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "5d7ea1d2-bf47-48d6-b0d9-245b0c9b4f02" |> Result.get)
        [| "стрелки"; "стрелочки" |]
        "<@authorMention> переводит стрелочки 🔄"
        gifs
        "Нечего на меня стрелочки переводить <:catPleased:1041855910626213949>"
        [||]
        "<@authorMention> переводит стрелочки на <@targetMention> 🔄"
        gifs
