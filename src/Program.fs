open FsharpMyExtension
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils
open AgentDiscordBot.Commands.Commands

let commands: Command [] =
    [|
        yield Take.command
        yield FairyTail.command
        yield Tail.command
        yield Bully.command
        yield Admire.command
        yield Battery.command
        yield Catch.command
        yield Angry.command
        yield Bite.command
        yield Shashlik.command
        yield CookieCatsShip.command
        yield Noodle.command
        yield ValerijAleksandrovich.command
        yield Adalinda.command
        yield Moraj.command
        yield Agent.command
        yield Massage.command
        yield Hide.command
        yield Snatch.command
        yield Cheek.command
        yield Nevermind.command
        yield Maksim.command
        yield Manul.command
        yield Svetlana.command
        yield Muhlevshica.command
        yield Muhlevshik.command
        yield Lina.command
        yield Yana.command
        yield Mumble.command
        yield Run.command
        yield Plead.command
        yield Attack.command
        yield Drama.command
        yield Womanizer.command
        yield Paw.command
        yield Peek.command
        yield FlirtyEyes.command
        yield Sleep.command
        yield Buzz.command

        yield // todo: не знаю, как перевести команду. Caresses — очень общее, fondle — это вообще мять груди. Rub, быть может?
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "8da29f55-fb38-4de9-b40b-caa9a0cba489" |> Result.get)
                [| "ластиться"; "ластится"; "тереться" |]
                "<@authorMention> ластится:"
                [|
                    "https://media.tenor.com/QYQ6fTqCdrEAAAAd/manul-pallas-cat.gif"
                |]
                "<@authorMention>, на меня это не работает <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> ластится к <@targetMention>:"
                [|
                    "https://media.tenor.com/GKzrBpqjBzMAAAAd/cute-cat.gif"
                    "https://media.tenor.com/oepLIJup6kIAAAAd/wet-hair.gif"
                    "https://media.tenor.com/UW1xc68-KXkAAAAd/funny-animals-cats.gif"
                    "https://media.tenor.com/twkOV4hc7JUAAAAd/kitty-cat.gif"
                |]

        yield AirKiss.command
        yield ChristmasTree.command
        yield Snow.command
        yield Hug.command
        yield Mlem.command
        yield Tigidik.command
        yield BiteCheek.command
        yield Yell.command
        yield Punish.command
        yield Lunaris.command
        yield Riot.command
        yield Pat.command
        yield Boomerang.command
        yield Kiss.command
        yield Sing.command
        yield Viola.command
        yield Flowers.command
        yield Badminton.command
        yield Jungledrum700.command
        yield Arrows.command
        yield Witch.command
        yield Coffee.command
        yield Poke.command
        yield Lazy.command
        yield CookieOk.command
        yield Loo.command
        yield Fortune.command
        yield Dance.command
        yield Evgenka.command
        yield Sommelier.command
        yield Zluka.command
        yield Roman.command
        yield Glazastaja.command
        yield Topic.command
        yield Antiwitch.command
        yield Sandal.command
        yield MagicBall.command
    |]

let testUniqIds () =
    commands
    |> Array.fold
        (fun ids x ->
            if Set.contains x.Id ids then
                failwithf "%A not uniq!" x.Id
            Set.add x.Id ids
        )
        Set.empty
    |> ignore

testUniqIds ()
let content = commands |> CommandsArray.serialize
System.IO.File.WriteAllText("output.json", content)
printfn "Done!"
