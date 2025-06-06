module AgentDiscordBot.Commands.Commands.Womanizer
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/1020769499370246198/1039880982448324658/4be76d1411ad3f91.png"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "908412ce-e724-44b0-a056-7ad192026aa3" |> Result.get)
        [| "ловелас"; "сердцеед" |]
        "<@authorMention> изображает из себя ловеласа:"
        true
        "Тщетны твои <:Demon_Kingsmile:877678191693692969>"
        false
        "<@authorMention> соблазняет <@targetMention>:"
        true
