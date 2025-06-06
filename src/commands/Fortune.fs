module AgentDiscordBot.Commands.Commands.Fortune
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
        (CommandId.tryDeserialize "78c0be20-3ada-4e44-a3ec-b2ce7c1b2403" |> Result.get)
        {
            Names = [| "гадать"; "погадать"; "гадает"; "гадание" |]

            OnSelf = [|
                createReaction
                    "<@authorMention> пророчит свою судьбу на компотной гуще:"
                    "https://cdn.discordapp.com/attachments/912291464074117161/1232004998007885896/fortune-telling-on-the-goo.png"
                createReaction
                    "<@authorMention> удлиняет ладони перед гаданием:"
                    "https://cdn.discordapp.com/attachments/1231955824503558145/1231956458736713759/IG4x.gif"
                createReaction
                    "<@authorMention> видит страшное пророчество в ладоне:"
                    "https://cdn.discordapp.com/attachments/1231955824503558145/1231956860257566740/ruki-svetiatsia-1.gif"
                createReaction
                    "<@authorMention> раскладывает карты Таро:"
                    "https://cdn.discordapp.com/attachments/859253126878724126/1150447252238762105/fi37KfOUJWGK3SgG94YEzJg154BaXiekMKUWyBn5sHN8ySXejfJNqZfOJi6go66vV5UWeETmh9GFQ29oI85Oc1y3.webp"
            |]

            OnBot = [|
                createReactionDescription "Я и так знаю свою судьбу! 😾"
            |]

            OnOther = [|
                createReaction
                    "<@authorMention> пророчит судьбу <@targetMention> на компотной гуще:"
                    "https://cdn.discordapp.com/attachments/912291464074117161/1232004998007885896/fortune-telling-on-the-goo.png"
                createReaction
                    "<@authorMention> предсказывает длину <@targetMention> по ладони:"
                    "https://cdn.discordapp.com/attachments/912291464074117161/1232005528314581073/fortune-telling-on-the-hand.png"
                createReaction
                    "<@authorMention> вычисляет длину <@targetMention> по ладони:"
                    "https://cdn.discordapp.com/attachments/1231955824503558145/1231956037825859664/S3Cl.gif"
                createReaction
                    "<@authorMention> показывает ладонь <@targetMention>:"
                    "https://cdn.discordapp.com/attachments/1231955824503558145/1231956218290114600/e924b74646612244655d6d3ff718c311.gif"
                createReaction
                    "<@authorMention> гадает на картах Таро судьбу <@targetMention>:"
                    "https://cdn.discordapp.com/attachments/859253126878724126/1150447252238762105/fi37KfOUJWGK3SgG94YEzJg154BaXiekMKUWyBn5sHN8ySXejfJNqZfOJi6go66vV5UWeETmh9GFQ29oI85Oc1y3.webp"
                createReaction
                    "<@authorMention> принимается гадать на хрустальном шаре судьбу <@targetMention>:"
                    "https://c.tenor.com/Pjdqp_MpAe8AAAAC/tenor.gif"
            |]

            Cooldownable =
                None
        }
