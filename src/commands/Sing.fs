module AgentDiscordBot.Commands.Commands.Sing
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/WSVo8Lw5-O8AAAAC/simone-simons-epica.gif"
            "https://media.tenor.com/6_wT-yXbIg4AAAAC/alissa-white-gluz-arch-enemy.gif"
            "https://media.tenor.com/mA4XKYoYKAQAAAAC/shot-glass-vodka.gif"
            "https://media.tenor.com/uKM1eieWMD4AAAAd/hi-hair-flip.gif"
            "https://media.tenor.com/h6UICQBlLCgAAAAd/karaoke-queen.gif"
            "https://media.tenor.com/vyHsxkohdPsAAAAC/howling-music.gif"
            "https://media.tenor.com/sGEdXsawxqYAAAAC/despicable-me-minions.gif"
            "https://media.tenor.com/XqQnYUDNiJAAAAAC/dozhd-rain.gif"
            "https://media.tenor.com/e1_ReiRceFYAAAAd/going-crazy-maya-rudolph.gif"
            "https://media.tenor.com/6i--pFIVdKcAAAAd/hollywood-vampires-johnny-depp.gif"
            "https://media.tenor.com/Ia5uNtbqL_YAAAAC/singer-bad-singer.gif"
            "https://media.tenor.com/_D8GuditwzsAAAAC/singing-rockers.gif"
            "https://media.tenor.com/uFx6AIzrbXgAAAAC/singing-comedy.gif"
            "https://media.tenor.com/TAG6CAmWxGcAAAAC/cat-singing.gif"
            "https://media.tenor.com/cPLvusWmwJcAAAAd/singing-maya-rudolph.gif"
            "https://media.tenor.com/fyX1hCbOOEYAAAAC/sing-movie-dancing.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "df96ad15-d47d-44ee-ac85-eb83344ff946" |> Result.get)
        [| "спеть"; "поет"; "поёт"; "караоке" |]
        "<@authorMention>, поёт:"
        gifs
        "<@authorMention>, не надо тут петь, бип-буп! 🙀"
        [||]
        "<@authorMention> поёт для <@targetMention>:"
        gifs
