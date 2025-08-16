open CustomCommand.Model

open AgentDiscordBot.Commands.Commands
open AgentDiscordBot.Commands.Utils

let commands: Command [] =
    [|
        Take.command
        FairyTail.command
        Tail.command
        Bully.command
        Admire.command
        Battery.command
        Catch.command
        Angry.command
        Bite.command
        Shashlik.command
        CookieCatsShip.command
        Noodle.command
        ValerijAleksandrovich.command
        Adalinda.command
        Moraj.command
        Agent.command
        Massage.command
        Hide.command
        Snatch.command
        Cheek.command
        Nevermind.command
        Maksim.command
        Manul.command
        Svetlana.command
        Muhlevshica.command
        Muhlevshik.command
        Lina.command
        Yana.command
        Mumble.command
        Run.command
        Plead.command
        Attack.command
        Drama.command
        Womanizer.command
        Paw.command
        Peek.command
        FlirtyEyes.command
        Sleep.command
        Buzz.command
        Cuddle.command
        AirKiss.command
        ChristmasTree.command
        Snow.command
        Hug.command
        Mlem.command
        Tigidik.command
        BiteCheek.command
        Yell.command
        Punish.command
        Lunaris.command
        Riot.command
        Pat.command
        Boomerang.command
        Kiss.command
        Sing.command
        Viola.command
        Flowers.command
        Badminton.command
        Jungledrum700.command
        Arrows.command
        Witch.command
        Coffee.command
        Poke.command
        Lazy.command
        CookieOk.command
        Loo.command
        Fortune.command
        Dance.command
        Evgenka.command
        Sommelier.command
        Zluka.command
        Roman.command
        Glazastaja.command
        Topic.command
        Antiwitch.command
        Sandal.command
        MagicBall.command
        Catapult.command
        StealPantsu.command
    |]

testUniqIds commands
let content = commands |> CommandsArray.serialize
System.IO.File.WriteAllText("output.json", content)
printfn "Done!"
