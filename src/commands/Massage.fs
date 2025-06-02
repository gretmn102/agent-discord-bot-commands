module AgentDiscordBot.Commands.Commands.Massage
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/899245715316965446/1047915227347423292/massage.gif"
        "https://media.tenor.com/EwJDL0rrPugAAAAd/cat-massage.gif"
        "https://media.tenor.com/kfIyTd_HbZcAAAAC/massage.gif"
        "https://media.tenor.com/W12FJPalZMsAAAAC/massage-dudu.gif"
        "https://media.tenor.com/W6IcNCDOakcAAAAC/babi-ko.gif"
        "https://media.tenor.com/nSo86v_MXE0AAAAC/squaril.gif"
        "https://media.tenor.com/HbikpJIowHYAAAAC/massage.gif"
        "https://media.tenor.com/KUrcCrz_3pcAAAAC/mochi-mochi-peach-cat-cute.gif"
        "https://media.tenor.com/pZHT2Pwe7v8AAAAd/cat-massage-cat.gif"
        "https://media.tenor.com/sb2aDjBRrFwAAAAC/cats-massage.gif"
        "https://media.tenor.com/P2PITomgV4YAAAAC/cats.gif"
        "https://media.tenor.com/63hKT9buoDIAAAAC/cute-kitty.gif"
        "https://media.tenor.com/81JkOtzZjQsAAAAC/duck-foot-rub.gif"
        "https://media.tenor.com/jDWmx28SMacAAAAC/kittens-massaging.gif"
        "https://media.tenor.com/kfIyTd_HbZcAAAAC/massage.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "fb3e7fe1-be43-4657-a504-11e8ca608c6b" |> Result.get)
        [| "массаж" |]
        "<@authorMention> делает себе массаж:"
        true
        "<:catPleased:1041855910626213949>"
        false
        "<@authorMention> делает массаж <@targetMention>:"
        true
