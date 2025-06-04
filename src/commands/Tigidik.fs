module AgentDiscordBot.Commands.Commands.Tigidik
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/927554008263032836/1057093913653018624/image0.gif"
            "https://cdn.discordapp.com/attachments/927554008263032836/1057094982177140916/image0.gif"
            "https://cdn.discordapp.com/attachments/859253126878724126/968132450142277642/tigidikYoYo.gif"
            "https://c.tenor.com/mJw5w8xREjYAAAAd/playful-energy.gif"
            "https://media.tenor.com/7K3u8X-NUU8AAAAd/dance-dancing.gif"
            "https://cdn.discordapp.com/attachments/927554008263032836/1057096297573781634/image0.gif"
            "https://tenor.com/ru/view/кот-котик-пушистый-скачет-кот-скачет-gif-7521206174951915808"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "37687414-bd3c-49ff-a42c-1eed212c39a6" |> Result.get)
        [| "тыгыдык" |]
        "<@authorMention> тыгыдыкает:"
        gifs
        "<@authorMention>, никакого тыгыдыка в мою смену <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> тыгыдыкает с <@targetMention>:"
        gifs
