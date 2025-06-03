module AgentDiscordBot.Commands.Commands.Sleep
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "213d850a-c056-494c-ae1f-62458386c830" |> Result.get)
        [| "спать"; "sleep"; "уложитьСпать" |]
        "<@authorMention> укладывается спатюнькать:"
        [|
            "https://media.tenor.com/MlEcr_6z6lEAAAAd/happy-christmas.gif"
            "https://media.tenor.com/tIp8NWWKpokAAAAd/cat-lazy.gif"
            "https://media.tenor.com/bBycY0Pdq_IAAAAC/iod-iodiod.gif"
            "https://media.tenor.com/N2hl_fAdpmAAAAAd/cat-kitten.gif"
            "https://media.tenor.com/MsKzT_aGMF8AAAAd/tired-good-night.gif"
            "https://media.tenor.com/oDSUnnEJLKcAAAAC/cat-catzzz.gif"
        |]
        "<@authorMention>, лучше ты ложись, а мне еще работать и работать <:monika:876512461761691688>"
        [||]
        "<@authorMention> укладывает спать <@targetMention>:"
        [|
            "https://media.tenor.com/VdIKn05yIh8AAAAd/cat-sleep.gif"
            "https://media.tenor.com/R_cGlaPuqTQAAAAd/sleepy-cat-cat.gif"
            "https://media.tenor.com/GS6roA5CehwAAAAd/cat-sleepy.gif"
            "https://media.tenor.com/cCaPvVOJruEAAAAd/good-night-siesta.gif"
            "https://media.tenor.com/xZL-YpO6wFcAAAAd/cat-kitty.gif"
            "https://media.tenor.com/IJKuYz9RPYQAAAAd/cat-%D0%BA%D0%BE%D1%82.gif"
        |]
