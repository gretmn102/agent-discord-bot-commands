module AgentDiscordBot.Commands.Commands.Muhlevshica
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/927554008263032836/1047932343282831460/Screenshot_20220501_012352_com.yandex.browser.jpg"
        "https://cdn.discordapp.com/attachments/927585487332466778/992920732168360077/unknown.png"
        "https://cdn.discordapp.com/attachments/927585487332466778/992918627319812126/unknown.png"
        "https://cdn.discordapp.com/attachments/927585487332466778/992917007479619584/unknown.png"
        "https://cdn.discordapp.com/attachments/927585487332466778/964562528896155688/unknown.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775832859476008/Screenshot_2022-09-04_at_02-36-39_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775833157275688/Screenshot_2022-09-04_at_02-41-12_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775833434108025/Screenshot_2022-09-04_at_02-45-13_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775833681559562/Screenshot_2022-09-04_at_02-56-04_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775833929044068/Screenshot_2022-09-04_at_03-01-52_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775834193272915/Screenshot_2022-09-04_at_03-06-12_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775834805637190/Screenshot_2022-09-04_at_03-08-06_UNO_Online_-_UNO_Online_CrazyGames.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775835040522240/767.PNG"
        "https://cdn.discordapp.com/attachments/778999058965987378/1015775835275411556/23546.PNG"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "d03cde9a-6cde-4c12-8ba1-8d0ecbeceda9" |> Result.get)
        [| "мухлевщица" |]
        "<@authorMention> изображает мухлевщицу:"
        true
        "Не надо на меня изображать мухлевщицу! 🙀"
        false
        "<@authorMention> изображает мухлевщицу <@targetMention>:"
        true
