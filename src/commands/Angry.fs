module AgentDiscordBot.Commands.Commands.Angry
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        // "https://c.tenor.com/ikKAd57zDEwAAAAd/anime-mad.gif"
        // "https://c.tenor.com/rzDkOlEDun0AAAAC/hayase-nagatoro-nagatoro-angry.gif"
        // "https://c.tenor.com/kTOmea7XdH4AAAAC/anime-angry.gif"
        // "https://c.tenor.com/7rIJkf8pB2EAAAAd/a-channel-tooru.gif"
        // "https://c.tenor.com/NxIgKHx6bu0AAAAC/glare-anger.gif"
        // "https://c.tenor.com/0YwfR1RlISEAAAAC/angry-fist-angry-fist-arthur.gif"
        // "https://c.tenor.com/Hn87zvoPNkAAAAAC/fire-bear.gif"
        "https://media.tenor.com/4rBafeqPOj0AAAAC/mad-angry.gif"
        "https://media.tenor.com/gWVekiI5onwAAAAC/madcat-ygzcat.gif"
        "https://media.tenor.com/qzimWk_DVYUAAAAd/cat-angry-angry.gif"
        "https://media.tenor.com/SN6EKkspK5UAAAAd/suspense-suspicious.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "61a620d4-405b-46f7-a9a9-83aadfa5dfe0" |> Result.get)
        [| "злиться"; "angry" |]
        "На самого себя нельзя злиться, ну в самом деле!"
        "На меня не надо злиться, я хороший!"
        "<@authorMention> злится на <@targetMention>"
