module AgentDiscordBot.Commands.Commands.Catch
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/864883475386990664/895218342141509632/Screenshot_20181219-151451_1.jpg"
        "https://c.tenor.com/9OGqk-WVlNEAAAAC/cats-chase.gif"
    |]
    |> createCommandWithRandomImages
        (CommandId.tryDeserialize "2c126e06-1294-479a-9ee4-b420195debad" |> Result.get)
        [| "словить"; "catch"; "споймать"; "поймать" |]
        "Самого нельзя ловить!"
        "Меня нельзя ловить! Я этого не вынесу :scream_cat:"
        "<@authorMention> ловит <@targetMention>"
