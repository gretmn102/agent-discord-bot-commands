module AgentDiscordBot.Commands.Commands.Adalinda
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    [|
        "https://cdn.discordapp.com/attachments/958443579393576963/958444009527836853/unknown.png"
        "https://media.tenor.com/xfMZa2hEWfwAAAAC/fat-girl.gif"
        "https://c.tenor.com/F3e-qN3UrOcAAAAC/cat-scratching.gif"
        "https://c.tenor.com/0Ff8iqk9RJIAAAAd/cat-fat.gif"
        "https://c.tenor.com/gZyfqj9X1qYAAAAd/dont-touch-me-peasant.gif"
        "https://c.tenor.com/jwX64uKXt-gAAAAd/%D9%88%D9%82%D8%AA-%D8%A7%D9%84%D8%B9%D9%85%D8%A7%D8%B1%D9%8A.gif"
        "https://c.tenor.com/yz_7VcX0WjYAAAAS/cat-changing-the-clock-changing-the-time.gif"
        "https://cdn.discordapp.com/attachments/750659871208243240/923101985283137557/ceae5f25f5716c566c664e401a1648cf.jpg"
        "https://cdn.discordapp.com/attachments/778999058965987378/1023560031007952996/unknown.png"
        "https://cdn.discordapp.com/attachments/778999058965987378/1028774013293564086/unknown.png"
        "https://cdn.discordapp.com/attachments/859253126878724126/1005264669004537946/542d31cb59bf2bc9.jpg"
        "https://cdn.discordapp.com/attachments/859253126878724126/961036289925337118/unknown.png"
        "https://upload.wikimedia.org/wikipedia/commons/0/06/Jove_decadent.jpg"
        "https://cdn.discordapp.com/attachments/821693841718771724/1048505953131171911/B_-u7MnJO_G12amayezRHnfpc6JIAqOavzk1gayFHrwmw7X7Q3OaMNbq6tkK2IE_4GXh0zkrBD1Bj_EyzcCE7_R4.jpg"
        "https://media.tenor.com/igJNrzoEWiwAAAAC/faint-drama.gif"
        "https://media.tenor.com/BLyoWqxTQ3gAAAAC/darkwing-duck-gosalyn-mallard.gif"
        "https://cdn.discordapp.com/attachments/912291464074117161/1048897403291455600/6HsY8tDMPhs-removebg-preview.png"
    |]
    |> createCommandWithRandomImages2
        (CommandId.tryDeserialize "0195eb5a-771c-463b-bc32-afcf2a60d636" |> Result.get)
        [| "адалинда" |]
        "<@authorMention> изображает Адалинду:"
        true
        "<:catPleased:1041855910626213949>"
        false
        "<@authorMention> изображает Адалинду <@targetMention>:"
        true
