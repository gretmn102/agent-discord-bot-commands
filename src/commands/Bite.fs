module AgentDiscordBot.Commands.Commands.Bite
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/iFjm7dyo_-MAAAAd/cat-bite.gif"
        "https://media.tenor.com/WVRAumVRwi4AAAAd/cat.gif"
        "https://media.tenor.com/wI_QPAY2G1cAAAAd/cat-bites-lip.gif"
        "https://media.tenor.com/yVKQAhFuGZQAAAAC/cat-bite.gif"
        "https://media.tenor.com/bB9rBu4CZxoAAAAd/cat-bite.gif"
        "https://media0.giphy.com/media/XtuYDes6uyL4Y/giphy.gif"
        "https://media.tenor.com/p9AJkXcmJucAAAAC/nom-tik-tok.gif"
        "https://cdn.discordapp.com/attachments/876498372939382784/948864222912204800/03e6f05d01f87f934a5c2b547bf77e61.jpg"
        "https://media.tenor.com/snjr2hMxcs8AAAAd/funny-animals-kitty.gif"
        "https://c.tenor.com/e3XWGaLSpW4AAAAd/tenor.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "a453fb4d-c9f8-46b5-802b-4534a665a2c3" |> Result.get)
        [| "кусь" |]
        "Не надо самого куськать, ну в самом деле!"
        "Меня нельзя куськать: я железный и невкусный! 🙀"
        "<@authorMention> куськает <@targetMention>"
