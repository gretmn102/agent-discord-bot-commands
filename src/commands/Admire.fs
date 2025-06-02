module AgentDiscordBot.Commands.Commands.Admire
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        // "https://risovach.ru/upload/2012/11/lyubov-4219820_orig_.jpeg"  // стебные
        // "https://i.imgur.com/ArtzYH0.jpg" // стебные
        "https://media.tenor.com/qy2BfZWRGDYAAAAC/admire.gif"
        "https://media.tenor.com/MEGTI1brCBoAAAAC/aww-so-in-love.gif"
        "https://media.tenor.com/5w5YGzdrlgoAAAAC/smile-dreamy.gif"
        "https://media.tenor.com/VaNHuhM2hxcAAAAC/yes-patrick.gif"
        "https://cdn.discordapp.com/attachments/876706882423762994/895897487422914640/qdNVIlPoG8o.jpg"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "a2df140b-efe1-4ff7-8468-d1e26f120d9a" |> Result.get)
        [| "admire"; "любоваться"; "любуется" |]
        "Нельзя любоваться собой :eyes:"
        "Нельзя мною любоваться :scream_cat:"
        "<@authorMention> любуется <@targetMention>"
