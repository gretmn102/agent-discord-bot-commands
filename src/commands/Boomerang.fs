module AgentDiscordBot.Commands.Commands.Boomerang
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "55c15899-598f-432b-92d9-ffa4f2bc3d31" |> Result.get)
        [| "бумеранг" |]
        "<@authorMention> изображает бумеранг:"
        [|
            "https://media.tenor.com/NW9JL2p3XSwAAAAd/family-guy-boomerang.gif"
        |]
        "<@authorMention>, не надо в меня запускать бумеранг, бип-буп! 🙀"
        [||]
        "<@authorMention> запускает бумеранг в <@targetMention>:"
        [|
            "https://media.tenor.com/YO9Pq8wew9YAAAAC/boomerang-coming.gif"
            "https://media.tenor.com/CgYWLZ8S2d4AAAAC/boomerang-throw.gif"
            "https://media.tenor.com/images/365754798f6d8ad0f81e49e93d170f1c/tenor.gif"
            "https://cdn.dribbble.com/users/1161476/screenshots/4906637/untit.gif"
        |]
