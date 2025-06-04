module AgentDiscordBot.Commands.Commands.AirKiss
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let urls =
        [|
            "https://media.tenor.com/SFj-19Vp3YkAAAAC/kiss-flying.gif"
            "https://media.tenor.com/vmrR0VoDVRkAAAAC/blow-kiss-anime-blow-kiss.gif"
            "https://media.tenor.com/R1y3qRkSRwkAAAAC/anime-girl.gif"
            "https://media.tenor.com/43qt_qk-LWkAAAAC/cute-anime.gif"
            "https://media.tenor.com/7s-3eQ3MNtsAAAAC/laughs-kiis.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "4667fdc1-7d6f-4bef-960e-d3521cdae1fe" |> Result.get)
        [| "воздушныйПоцелуй"; "поцелуй" |]
        "<@authorMention> посылает воздушный поцелуй:"
        urls
        "<@authorMention>, мне роботу, из цифровой плоти и холодных логических цепей, чужда теплота двуногих, но все равно спасибо, бип-буп."
        [||]
        "<@authorMention> посылает воздушный поцелуй <@targetMention>:"
        urls
