module AgentDiscordBot.Commands.Commands.Paw
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://media.tenor.com/TcYTfeJkbmcAAAAC/%D0%BA%D0%BE%D1%82.gif"
        "https://media.tenor.com/b3QpV-rd7C4AAAAC/kitty-little-paws.gif"
        "https://cdn.discordapp.com/attachments/927554008263032836/1049192535500800000/bloggif_6123f977cfede-2-1-1-1-1.gif"
        "https://media.tenor.com/KZC1s7f-RZ4AAAAC/cute-kitten.gif"
        "https://c.tenor.com/Ar_RqkuvrNsAAAAd/tenor.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "de12b01f-2ec1-4b80-9264-1e76507ebf1e" |> Result.get)
        [| "лапки" |]
        "У <@authorMention> лапки:"
        true
        "Меня и так лапки сотворили."
        false
        "<@authorMention> показывает свои лапки <@targetMention>:"
        true
