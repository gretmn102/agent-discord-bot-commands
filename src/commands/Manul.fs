module AgentDiscordBot.Commands.Commands.Manul
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://c.tenor.com/eaYWFPJBj8wAAAAd/manul-warms-his-paws.gif"
        "https://cdn.discordapp.com/attachments/864883475386990664/895712522831806494/Screenshot_20181219-152732_2.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895931456755478528/Screenshot_20181219-151254_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895931600775307294/Screenshot_20181219-151451_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895931730056327219/Screenshot_20181219-151339_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895931854216114186/Screenshot_20181219-151417_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895932260405092362/Screenshot_20181219-152635_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/895938189229965322/Screenshot_20181219-152706_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/896372453222252564/Screenshot_20181219-152719_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/898455985977450526/Screenshot_20181219-152649_2.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/899743293557059614/Screenshot_20181219-152725_1.jpg"
        "https://cdn.discordapp.com/attachments/864883475386990664/938488951755399208/manul.gif"
        "https://cdn.discordapp.com/attachments/864883475386990664/939977295282728982/Manul_5.jpg"
        "https://cdn.discordapp.com/attachments/876541671997837312/953350018385997824/--4492039.png"
        "https://www.poznavayka.org/wp-content/uploads/2019/02/Tibetskiy-manul.jpg"
        "https://www.poznavayka.org/wp-content/uploads/2019/02/manul-skalitsya.jpg"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "e21881d7-de61-40cc-a2b9-d1fb35c75ce7" |> Result.get)
        [| "манул" |]
        "<@authorMention> изображает Манула:"
        true
        "Не надо на меня изображать Манула! 🙀"
        false
        "<@authorMention> изображает Манула <@targetMention>:"
        true
