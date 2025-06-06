module AgentDiscordBot.Commands.Commands.Shashlik
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/LtTjLfArzqAAAAAd/sheftalia-karvouna.gif"
        "https://media.tenor.com/Xufgg6gSRPkAAAAC/%E1%83%9B%E1%83%AC%E1%83%95%E1%83%90%E1%83%93%E1%83%98-mwvadi.gif"
        "https://media.tenor.com/ayzVsly9VGEAAAAd/%E1%83%90%E1%83%97%E1%83%9A%E1%83%94%E1%83%97%E1%83%98%E1%83%99%E1%83%90%E1%83%AA%E1%83%98-%E1%83%9B%E1%83%94%E1%83%A5%E1%83%90%E1%83%91%E1%83%90%E1%83%91%E1%83%94%E1%83%AF%E1%83%94%E1%83%9A%E1%83%90%E1%83%9A%E1%83%98.gif"
        "https://media.tenor.com/_ZQHECcQ1nsAAAAd/%D1%88%D0%B0%D1%88%D0%BB%D1%8B%D0%BA-%D0%B1%D0%B5%D0%B1%D1%80%D0%B0.gif"
        "https://media.tenor.com/qeU8IezNdJIAAAAS/%EC%8B%9D%ED%92%88%EA%B0%80%EA%B3%B5.gif"
        "https://media.tenor.com/1jIM6pxDDdMAAAAC/bbq-meat.gif"
        "https://media.tenor.com/RdEYFJcw8BYAAAAC/brasero.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "bed40dd7-08f6-46fd-8eb3-d2fc4dcb8a62" |> Result.get)
        [| "шашлык"; "шашлычок" |]
        "<@authorMention> жарит себе шашлычок."
        true
        "<@authorMention> жарит мне шашлычок, пасеба 😋"
        true
        "<@authorMention> делает шашлычок для <@targetMention>"
        true

