module AgentDiscordBot.Commands.Commands.Nevermind
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/BdORj1n-kYsAAAAC/rammstein.gif"
        "https://media.tenor.com/4cMGEIhiXDoAAAAC/whatever-you-say-so-dont-care.gif"
        "https://cdn.discordapp.com/attachments/927554008263032836/1187705644988497930/1703241466840.jpg" // ёжик уходит с надписью "Ой, всё"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "e1ec1965-e318-47d6-8bcc-a099868eb7e1" |> Result.get)
        [| "ойвсе"; "ойвсё" |]
        "<@authorMention> ойвсёкает на себя:"
        true
        "Не надо меня ойвсёкать! 🙀"
        false
        "<@authorMention> ойвсёкает на <@targetMention>:"
        true
