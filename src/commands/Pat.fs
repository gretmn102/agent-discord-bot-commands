module AgentDiscordBot.Commands.Commands.Pat
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://media.tenor.com/WfjEGbjVRtIAAAAC/mochi-mochi-peach-cat-cute.gif"
            "https://cdn.discordapp.com/attachments/1090297880981549136/1090298329482670090/image1.gif"
            "https://cdn.discordapp.com/attachments/1090297880981549136/1090298329851760700/image2.gif"
            "https://cdn.discordapp.com/attachments/1090297880981549136/1090298330384453662/image3.gif"
            "https://cdn.discordapp.com/attachments/1090297880981549136/1090298330753536010/image4.gif"
            "https://cdn.discordapp.com/attachments/1090297880981549136/1090298524664594543/image0.gif"
            "https://media.tenor.com/WvkIVYcwGfEAAAAd/cat-sleeping.gif"
            "https://media.tenor.com/y8NOCYSyd-AAAAAd/cat-petting-cat.gif"
            "https://cdn.discordapp.com/attachments/859253126878724126/1287109653993488394/vgif-ru-39489.gif"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "656ca5c8-2d60-460b-bb1d-7e235d62607f" |> Result.get)
        [| "гладит"; "гладить"; "погладить" |]
        "<@authorMention> гладит:"
        gifs
        "<@authorMention>, не надо меня гладить, бип-буп! <:kittyResentment:976904434401558539>"
        [||]
        "<@authorMention> гладит <@targetMention>:"
        gifs
