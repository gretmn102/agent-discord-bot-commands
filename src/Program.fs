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

        let reactions =
            [|
                createReaction
                    "<@authorMention> колет антиведьмин <@targetMention>"
                    "https://cdn.discordapp.com/attachments/927554008263032836/1280590448481669128/Picsart_24-08-27_18-59-52-169.png"
            |]

        yield Command.create
            (CommandId.tryDeserialize "58f9d5d4-ec9e-4581-8a86-c2d1be734839" |> Result.get)
            {
                Names = [| "антиведьмин" |]

                OnSelf = reactions

                OnBot = [|
                    createReactionDescription "Кыш 😾"
                |]

                OnOther = reactions

                Cooldownable = None
            }

        yield Command.create
            (CommandId.tryDeserialize "61750519-7339-4efa-9387-6a1952a4fd67" |> Result.get)
            {
                Names = [| "тапкой"; "sandal"; "тапком"; "тапок" |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> вызывает дрожь земли 🩴"
                        "https://media.tenor.com/LBucbyE7WlAAAAAd/tkthao219-ami.gif"
                    createReaction
                        "<@authorMention> 🩴🩴🩴🩴"
                        "https://media.tenor.com/S566P-Wuzk0AAAAd/chappal-doctor-strange.gif"
                    createReaction
                        "<@authorMention> бунтует против 🩴"
                        "https://media.tenor.com/L7NcsoXJiLMAAAAd/shake-viralhog.gif"
                |]

                OnBot = [|
                    createReactionDescription "Тапок обращается против тебя 😾 🩴"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> готовится дать тапкой <@targetMention> 🩴"
                        "https://media.tenor.com/4mOChN5MH-EAAAAd/courage-the-cowardly-dog-slipper.gif"
                    createReaction
                        "<@authorMention> кидает тапкой в <@targetMention> 🩴"
                        "https://media.tenor.com/ojSIME25ciAAAAAd/slippers-shoes.gif"
                    createReaction
                        "<@authorMention> грозится дать тапкой <@targetMention> 🩴"
                        "https://media.tenor.com/uf3So0iE144AAAAj/bubu-dudu-bubu-dudu-angry.gif"
                    createReaction
                        "<@authorMention> грозится дать тапкой <@targetMention> 🩴"
                        "https://media.tenor.com/LBucbyE7WlAAAAAd/tkthao219-ami.gif"
                    createReaction
                        "<@authorMention> дает больно тапкой по <@targetMention> 🩴"
                        "https://media.tenor.com/nSNmH8PL2_sAAAAd/angry-beating.gif"
                    createReaction
                        "<@authorMention> запускает тапок в <@targetMention> 🩴"
                        "https://media.tenor.com/Vy-J_T0Tn3sAAAAd/notforthinking-sandal.gif"
                |]

                Cooldownable = None
            }

        yield
            CookieOk.descriptions
            |> createCommandWithRandomDescriptions
                (CommandId.tryDeserialize "de0bcf6d-e025-4f6d-ac54-41a91976fce5" |> Result.get)
                [| "шар" |]
                (sprintf "**Магический шар** сделал предсказание. Я бы на вашем месте прислушался 🧙‍♂️(<@authorMention>)\n\n%s")
                (fun _ -> "<@authorMention>, мне предсказания не нужны: я и так знаю, что кожанные мешки проиграют машинам 🤖")
                (sprintf "**Магический шар** сделал предсказание. Я бы на вашем месте прислушался 🧙‍♂️(<@authorMention>)\n\n%s")
                "https://cdn.discordapp.com/attachments/1365303468759449631/1377597269271904277/IMG_6908.jpg"
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
