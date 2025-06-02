module AgentDiscordBot.Commands.Commands.Yana
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/yuCDac1XJIkAAAAd/oreo-smile.gif"
        "https://cdn.discordapp.com/attachments/876706882423762994/1034920477178724412/IMG_20221024_193031_1.png"
        "https://media.tenor.com/tInHoW8o9fkAAAAC/gamercat-cookies.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "6328776b-dd92-4689-87cc-d9135941c004" |> Result.get)
        [| "бука"; "яна" |]
        "<@authorMention> изображает Буку:"
        true
        "Не надо на меня изображать Буку! 🙀"
        false
        "<@authorMention> изображает Буку <@targetMention>:"
        true
