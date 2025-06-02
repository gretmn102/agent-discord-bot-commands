module AgentDiscordBot.Commands.Commands.Cheek
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "2f1b48cd-bc04-4ed5-944b-6cf3fa0d79f3" |> Result.get)
        [| "щечки"; "щёчки" |]
        "<@authorMention> разминает себе щечки:"
        [|
            "https://media.tenor.com/mUUp5aMUIxkAAAAC/disney-cute.gif"
            "https://media.tenor.com/QncOj9EgFQEAAAAC/cheeks-cute.gif"
        |]
        "Не надо мне щечки мять, бу! 🙀"
        [||]
        "<@authorMention> разминает щечки <@targetMention>:"
        [|
            "https://media.tenor.com/B90mA02D_RkAAAAd/face-massage-kitten.gif"
            "https://media.tenor.com/K5SZOyxVUokAAAAd/cute-cat.gif"
            "https://media.tenor.com/oVPr0f0MtmkAAAAd/cat-face-massage.gif"
            "https://media.tenor.com/Tx1SfMNQtdAAAAAC/cute-kitten.gif"
            "https://media.tenor.com/w-IKBrrstF4AAAAC/pinching-cheeks-aww.gif"
            "https://media.tenor.com/iiPcPAuOjaMAAAAd/squishy-kitty-cat.gif"
            "https://media.tenor.com/UX0_hloOPj4AAAAC/pull-shibainu.gif"
            "https://media.tenor.com/EZelAU6S6McAAAAd/mochicat-cute.gif"
            "https://media.tenor.com/XuLO9w5VJLUAAAAC/kitten-cute-cat.gif"
        |]
