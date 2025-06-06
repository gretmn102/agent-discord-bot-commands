module AgentDiscordBot.Commands.Commands.Buzz
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "e0437fd8-455a-4345-86fe-2509d8b495fd" |> Result.get)
        [| "жужу"; "жужжать"; "жужжит"; "buzz" |]
        "<@authorMention> жужжит:"
        [|
            "https://media.tenor.com/TwqntufBQVgAAAAd/cat-bee.gif"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050712130028064808/iu.png"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050712195069116466/iu.png"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050712314061541397/iu.png"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050712846159327262/jadejerilyn.png"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050715734248005683/iu.png"
            "https://cdn.discordapp.com/attachments/1011244894020456488/1052238388079632414/b337286ba3aaf5cc.png"
        |]
        "<@authorMention>, не жужжи на меня, а то бип-буп сделаю <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> жужжит на <@targetMention>:"
        [|
            "https://media.tenor.com/b922yKwSlO8AAAAC/bee-cat.gif"
            "https://media.tenor.com/KUN8-p-Qrf4AAAAd/bee.gif"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050712378511212655/iu.png"
            "https://cdn.discordapp.com/attachments/1050675277354766356/1050715734248005683/iu.png"
        |]

