module AgentDiscordBot.Commands.Commands.FlirtyEyes
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/944823021548503050/1049285511388336138/1667032276165432283.gif"
        "https://media.tenor.com/6gp6u2j7huYAAAAC/cat-cute.gif"
        "https://media.tenor.com/xpN-1asA5CwAAAAC/puppy-eyes-pet-lover.gif"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "3f8071f9-1ce7-4814-987c-89ebd8cf6128" |> Result.get)
        [| "глазки"; "строитьГлазки" |]
        "<@authorMention> строит глазки:"
        true
        "Не надо мне тут строить глазки."
        false
        "<@authorMention> строит глазки <@targetMention>:"
        true
