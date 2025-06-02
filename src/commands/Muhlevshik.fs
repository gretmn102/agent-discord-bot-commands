module AgentDiscordBot.Commands.Commands.Muhlevshik
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/927585487332466778/992916619552628806/unknown.png"
        "https://cdn.discordapp.com/attachments/927585487332466778/964565906095239199/unknown.png"
        "https://cdn.discordapp.com/attachments/927554008263032836/1047934663160770590/unknown.png"
        "https://cdn.discordapp.com/attachments/927554008263032836/1047934757637472338/unknown.png"
        "https://cdn.discordapp.com/attachments/859253126878724126/1047944938102460416/unknown.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477678378909726/Screenshot_2022-09-19_at_20-03-54_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477678743830569/Screenshot_2022-09-19_at_20-05-55_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477679209402479/Screenshot_2022-09-19_at_20-07-37_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477679641395383/Screenshot_2022-09-19_at_20-19-52_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477680023097435/Screenshot_2022-09-19_at_20-21-56_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477680438313000/Screenshot_2022-09-19_at_20-24-21_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477680887111780/Screenshot_2022-09-19_at_20-31-31_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477681293955133/Screenshot_2022-09-19_at_20-33-58_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477681696620585/Screenshot_2022-09-19_at_20-35-04_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477682061512874/Screenshot_2022-09-19_at_20-37-58_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1021477725170581524/Screenshot_2022-09-19_at_20-44-50_UNO_Online_-_UNO_Online_CrazyGames.png"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "96351f4a-7afc-4d51-a982-64a1b370b688" |> Result.get)
        [| "мухлевщик" |]
        "<@authorMention> изображает мухлевщика:"
        true
        "Не надо на меня изображать мухлевщика! 🙀"
        false
        "<@authorMention> изображает мухлевщика <@targetMention>:"
        true
