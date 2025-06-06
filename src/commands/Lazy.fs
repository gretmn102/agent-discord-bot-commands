module AgentDiscordBot.Commands.Commands.Lazy
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://c.tenor.com/XmsP1zzo-G4AAAAd/huh-what-is-it.gif"
            "https://cdn.discordapp.com/attachments/859253126878724126/1161043975680032768/1696862434.jpg"
            "https://c.tenor.com/KRr-5gB7OCwAAAAd/tenor.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "02959305-a2c1-403e-b065-5fe885ca73bc" |> Result.get)
        [| "тюляша" |]
        "<@authorMention> тюленится:"
        gifs
        "<@authorMention>, никаких тюленей 😾"
        [||]
        "<@authorMention> тюленится перед <@targetMention>:"
        gifs
