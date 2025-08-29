module AgentDiscordBot.Commands.Commands.Snatch
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/irsckaQsr2QAAAAC/thief-stealing.gif"
        "https://c.tenor.com/tZmUCW4iRJEAAAAd/vampire-cat-steal-steal-vampire.gif"
        "https://c.tenor.com/sh_5zpuzWs4AAAAd/cat-pull-cat-snatch.gif"
        "https://c.tenor.com/r4wPECrdcysAAAAd/cat-goes-away.gif"
        "https://c.tenor.com/8-8e3JtHTicAAAAd/cat-yeet.gif"
        "https://media.tenor.com/lhKSYOk8KTEAAAAC/grab-steal.gif"
        "https://cdn.discordapp.com/attachments/1201405133284716594/1246111775447974031/GIF_20240531_194258_989.gif"
        // https://tenor.com/view/cats-captured-cat-ambushed-ambushed-cats-kidnapped-gif-26402250
        "https://media.tenor.com/Bv_kEIDbG0sAAAAd/cats-captured-cat.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "bf674738-583f-4764-aef7-df390c673e0e" |> Result.get)
        [| "украсть"; "snatch" |]
        "<@authorMention> крадет себя:"
        true
        "Не надо меня красть! 🙀"
        false
        "<@authorMention> крадет <@targetMention>, спасайте! 🙀"
        true
