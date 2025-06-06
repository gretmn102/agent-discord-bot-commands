module AgentDiscordBot.Commands.Commands.Coffee
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "49a07c36-710d-44b0-a501-65b568021e23" |> Result.get)
        [| "кофе"; "кофи" |]
        "<@authorMention> пьет кофе:"
        [|
            "https://media.tenor.com/IzXnvyY0oTMAAAAd/sip-drink.gif"
            "https://media.tenor.com/YlOvlmcMs-0AAAAC/cat-anime.gif"
            "https://media.tenor.com/INkk8LcOQHkAAAAC/drink-coffee-coffee.gif"
            "https://media.tenor.com/qMwy9pHiCkEAAAAi/peach-goma-peach-and-goma.gif"
            "https://media.tenor.com/RCtM_PIQ1OMAAAAd/good-morning-cat-images-good-morning.gif"
            "https://cdn.discordapp.com/attachments/912291464074117161/919132967681552394/02-09-12-i.webp"
            "https://cdn.discordapp.com/attachments/912291464074117161/919132968549744680/119107907_1032230470568506_1513547111738979195_o.jpg"
            "https://cdn.discordapp.com/attachments/912291464074117161/919132969862586398/tumblr_4e7dfe8b239773aa666c6ff40e950964_63995269_1280.jpg"
        |]
        "<@authorMention>, я в кофе не нуждаюсь, бип-буп."
        [||]
        "<@authorMention> наливает кофейку <@targetMention>:"
        [|
            "https://media.tenor.com/QBO_RQ-3BLkAAAAC/coffee-coffee-cup.gif"
            "https://media.tenor.com/Q2PkmfA5n2kAAAAC/coffee-turkish-coffee.gif"
            "https://media.tenor.com/PyTMOa1FSecAAAAC/%D0%BA%D0%BE%D1%84%D0%B5-%D0%B1%D1%83%D0%B4%D0%B5%D1%88%D1%8C.gif"
            "https://media.tenor.com/djQSgoOBJY0AAAAC/%D0%BA%D0%BE%D1%84%D0%B5%D0%B9%D0%BA%D1%83-%D0%BA%D0%BE%D1%84%D0%B5.gif"
            "https://cdn.discordapp.com/attachments/912291464074117161/919132969548001340/M1o6QT6J7oQ.png"
        |]
