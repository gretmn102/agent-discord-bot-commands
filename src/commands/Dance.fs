module AgentDiscordBot.Commands.Commands.Dance
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "06d9b434-a3e3-4551-b30c-b2338f648819" |> Result.get)
        {
            Names = [| "танец"; "танцевать"; "танцует" |]

            OnSelf = [|
                createReaction
                    "<@authorMention> танцует:"
                    "https://media.tenor.com/kQA86PqyXZQAAAAi/small-dancing-white-cat-dance-funny.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/RUGGdovmONkAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/eilrJW8N9f8AAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/-qBsG1HwR4oAAAAC/tenor.gif" // танец черно-белого кота
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/ZGovSy1dWQAAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/EuK-0kNNU_MAAAAC/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/swG4OJcOEcsAAAAC/tenor.gif"
                createReaction
                    "<@authorMention> пытается станцевать на шесте, пока никто не видит:"
                    "https://c.tenor.com/4z0JBiBrY2wAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/yAtEo2plQIYAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> пускается в зажигательный танец:"
                    "https://cdn.discordapp.com/attachments/859253126878724126/1007408454534713384/ass.gif"
                createReaction
                    "<@authorMention> танцует брейк-данс:"
                    "https://c.tenor.com/DTFWkey880EAAAAC/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/NVP2kRD7CHsAAAAC/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/38oB_0vHdn4AAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/r0R0N3dI3kIAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/RUGGdovmONkAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/5BYK-WS0__gAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/wmy7KME5DnwAAAAd/tenor.gif" // рыжий кот
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/aOa7sSEg_TYAAAAC/tenor.gif" // гандам стайл
                createReaction
                    "<@authorMention> танцует:"
                    "https://media.tenor.com/r-nqpCc0mT8AAAAi/dance.gif"
                createReaction
                    "<@authorMention> танцует:"
                    "https://c.tenor.com/6yMqezH9zcIAAAAd/tenor.gif"
            |]

            OnBot = [|
                createReactionDescription "Никаких танцулек в мою смену! 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> танцует с <@targetMention> на фоне луны:"
                    "https://c.tenor.com/G8yybLyvHKsAAAAC/tenor.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/XEtDtLZg8usAAAAd/spinning-xuxa.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/n3zeXSJMwM0AAAAd/dancing-friends.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/CfcJDdQUtiAAAAAd/gatinho-dan%C3%A7ante.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/v4jhYVrAPA4AAAAd/dancing-jordan-fisher.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/J4xTl0CHtsYAAAAd/manx-manx-dancing.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/w3tqEgUcrLUAAAAd/love-dance.gif"
                createReaction
                    "<@authorMention> танцует с <@targetMention>:"
                    "https://media.tenor.com/bVlx0j6rztMAAAAd/urgant-brezhneva.gif"
            |]

            Cooldownable =
                None
        }
