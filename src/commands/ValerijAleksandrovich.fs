module AgentDiscordBot.Commands.Commands.ValerijAleksandrovich
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/4eF0XKHqDB4AAAAC/meeting-bored.gif"
        "https://media.tenor.com/5KyNp4vd81YAAAAC/puffybear-puffy.gif"
        "https://media.tenor.com/6xwjsmMIAIoAAAAd/happy-happy-dog.gif"
        "https://media.tenor.com/AQpD7QUcOSEAAAAC/cats-laugh.gif"
        "https://media.tenor.com/BY6ybMD548sAAAAC/say-what-dunno.gif"
        "https://media.tenor.com/IzXnvyY0oTMAAAAd/sip-drink.gif"
        "https://media.tenor.com/UvvgjxTnagUAAAAd/cat-meow.gif"
        "https://media.tenor.com/_kqZQY5wX2sAAAAd/orange-cat-smile-cat-smile.gif"
        "https://media.tenor.com/aEiV77jD6Y4AAAAC/im-not-g-uilty-not-guilty.gif"
        "https://media.tenor.com/ofmh8wBaSucAAAAC/nope-danny-de-vito.gif"
        "https://media.tenor.com/zllPAWazxLQAAAAC/%E1%83%99%E1%83%98-%E1%83%93%E1%83%98%E1%83%90%E1%83%AE.gif"
        "https://media.tenor.com/AIQAS4l0uAIAAAAC/ew-yuck.gif"
        "https://media.tenor.com/By3_B2Nf9wMAAAAC/cat-amazed.gif"
        "https://media.tenor.com/DKB4fw7EACwAAAAd/true-correct.gif"
        "https://media.tenor.com/GSf4T-90WcwAAAAC/robert-downey-jr-facepalm.gif"
        "https://media.tenor.com/KSz6ArHR_PkAAAAC/jim-bored.gif"
        "https://media.tenor.com/_4xCiEhhoZsAAAAd/dog-smile.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "4358423a-2f58-4b4c-8efe-68654a74defc" |> Result.get)
        [| "ва"; "валерийАлександрович" |]
        "<@authorMention> изображает Валерия Александровича:"
        true
        "<:catPleased:1041855910626213949>"
        false
        "<@authorMention> изображает Валерия Александровича <@targetMention>:"
        true
