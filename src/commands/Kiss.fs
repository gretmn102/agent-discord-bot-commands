module AgentDiscordBot.Commands.Commands.Kiss
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "659fb789-3dc3-42bb-b855-a58665af3580" |> Result.get)
        [| "поцеловать" |]
        "<@authorMention>, надо бы указать, кого целуешь <:froggieShock:958004634310574120>"
        [||]
        "<@authorMention>, не надо меня целовать, бип-буп! 🙀"
        [||]
        "<@authorMention> целует <@targetMention>:"
        [|
            "https://media.tenor.com/3DHc1_2PZ-oAAAAC/kiss.gif" // аниме
            "https://media.tenor.com/RQhHyGyFoXIAAAAd/love.gif" // коты
            "https://media.tenor.com/4m0Z24gYBg8AAAAC/milk-and-mocha-cute.gif" // mocha
            "https://media.tenor.com/QKceeOMr8NUAAAAC/kiss-kisses.gif" // mocha
            "https://media.tenor.com/RKts25diH6gAAAAC/mochi-kiss.gif" // mocha
            "https://media.tenor.com/PIluhbjJORMAAAAd/kiss-bite.gif" // anime
            "https://media.tenor.com/0qBw32t-hdkAAAAC/poggers-anime.gif" // anime
            "https://media.tenor.com/fiafXWajQFoAAAAC/kiss-anime.gif" // anime
            "https://media.tenor.com/KE3VW3qP4RAAAAAC/kiss.gif" // anime
            "https://media.tenor.com/fONsKJlR5aEAAAAC/kiss-love.gif" // anime
            "https://media.tenor.com/217aKgnf16sAAAAC/kiss.gif" // mocha
            "https://media.tenor.com/1mkcYYknDFYAAAAC/kiss.gif" // real
            "https://media.tenor.com/DoHbYaLukKcAAAAC/lyubov-lyublu.gif" // real
            "https://media.tenor.com/m6pOa3HDKFQAAAAC/passionate-kiss-kiss.gif" // real
            "https://media.tenor.com/fCB3Ifb_e5AAAAAC/kiss-me-cats.gif" // tom and jerry
            "https://media.tenor.com/ky0z0xDC1HMAAAAC/kiss-passionate.gif" // bear and rabbit
        |]
