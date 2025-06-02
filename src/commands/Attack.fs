module AgentDiscordBot.Commands.Commands.Attack
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/l5sIE_3H3EEAAAAd/cats-fighting-fighting-cats.gif"
        "https://media.tenor.com/2NUo71q5wbMAAAAC/cats-fight.gif"
        "https://media.tenor.com/saVFWCC23KoAAAAd/cat-fight-cats-fighting.gif"
        "https://media.tenor.com/l5sIE_3H3EEAAAAd/cats-fighting-fighting-cats.gif"
        "https://media.tenor.com/Y2JNQLkzz8sAAAAd/cats-funny.gif"
        "https://media.tenor.com/TPDruIOzoEkAAAAC/kitten-smol.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "e5141bbc-be19-4f91-8228-e71a4d13a89b" |> Result.get)
        [| "напасть"; "атаковать" |]
        "<@authorMention> няпадает:"
        true
        "Не советую на меня нападать <:Demon_Kingsmile:877678191693692969>"
        false
        "<@authorMention> няпадает на <@targetMention>:"
        true
