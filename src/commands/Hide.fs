module AgentDiscordBot.Commands.Commands.Hide
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/BbW5C2qn8ggAAAAS/lulu-gifs-cat.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616283971170404/cat-catfallingandhiding.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616284390592642/cat-cute.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616284872945695/cat-hide_1.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616285216882769/cat-hide.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616285653086308/cat-hiding.gif"
        "https://cdn.discordapp.com/attachments/1034059525495455764/1047616286311596063/cat-shy.gif"
        "https://media.tenor.com/r4v3wuoctrYAAAAC/cat-hidden.gif"
        "https://media.tenor.com/O-h718UvzWIAAAAd/hiding-introvert.gif"
        "https://media.tenor.com/o9RaryfKDOgAAAAd/cat-kitty.gif" // на себя
        "https://media.tenor.com/7ERSsZ-KTvkAAAAd/cat-face-planted-on-the-bushes-viralhog.gif" //  на себя
        "https://media.tenor.com/2pdRqiTB2GMAAAAC/cat-leave-me-alone.gif" // на себя
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "381b173e-9e64-4665-94dd-a1cb79c1a7b2" |> Result.get)
        [| "спрятаться"; "hide"; "прячется" |]
        "<@authorMention> прячется:"
        true
        "За меня не надо прятаться."
        false
        "<@authorMention> прячется за <@targetMention>:"
        true
