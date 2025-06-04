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

        let questions =
            [|
                "Что вас вдохновляет?"
                "Какой фильм, книга или песня больше всего вас впечатлила?"
                "Если бы вам попался джинн, который может исполнить только одно желание, то что бы вы попросили?"
                "Что для вас является самым важным в дружбе?"
                "Гордитесь ли вы своими достижениями, если да, то какими?"
                "Если бы вы могли стать профессиональным спортсменом в любом виде спорта, какой бы вы выбрали и почему?"
                "Какие планы на будущее? Есть ли какие-то цели?"
                "Что вам больше всего нравится в себе?"

                "Какое событие в вашей жизни повлияло на вас больше всего?"
                "Какие у вас самые яркие детские воспоминания?"
                "Можете ли вы описать свой идеальный день?"
                "Какой самый странный сон вам когда-либо снился?"
                "Какие три вещи вы бы взяли с собой на необитаемый остров?"
                "Если бы у вас была возможность изменить одну вещь в мире, что бы вы изменили и почему?"
                "Если бы вы могли встретиться с любой исторической личностью, кого бы вы выбрали?"
                "В каком городе вы родились?"
                "Какое место в городе вам нравится посещать?"
                "Какой ваш любимый цвет?"
                "Какую музыку вы предпочитаете слушать?"
                "Какое ваше любимое блюдо?"
                "С каким овощем вы себя ассоциируете?"
                "Что бы вы делали, если бы увидели приведение?"
                "Готовы ли вы простить измену?"
                "Блогер, профессия или баловство?"

                "Какое у вас хобби?"
                "Как вы обычно проводите свободное время? Есть ли какие-то хобби или увлечения?"

                "Где бы вам хотелось побывать?"
                "Какой у вас любимый фильм?"
                "Что вам нравится делать в свободное время?"
                "Какие качества вы цените в людях?"
                "Какой была ваша первая работа?"
                "Какой ваш самый любимый вид спорта?"
                "Какой ваш самый большой страх?"
                "Какой ваш самый нелепый страх?"
                "Какой ваш самый необычный талант?"
                "Какая у вас мечта?"
                "У вас есть домашние животные?"
                "Какой у ваш был любимый школьный предмет?"
                "Если бы вы могли стать любым животным, кем бы вы стали и почему?"
                "Какой самый странный сон вы когда-либо видели?"

                "Любви все возрасты покорны. Как вы к этому относитесь? Возможны ли отношения с сильной разницей в возрасте, или это заблуждение и слепость одного или двух?"

                "Какую суперспособность вы бы хотели?"
                "Если бы тебе пришлось стать супергероем, какое имя и способности вы бы выбрали?"
                "Если бы тебе пришлось выбирать между невидимостью и умением летать, что бы ты выбрал (а) и почему?"

                "Если бы вы могли стать героем любого фильма, кем бы вы стали?"
                "Если бы вам пришлось стать злодеем в фильме, то каким было бы ваше злодейское хобби?"

                "Если бы была возможность путешествовать во времени, в какую эпоху вы бы отправились и зачем?"
                "Если бы возможно было бы общаться с животными на их языке, какую первую шутку рассказали бы вы своему питомцу?"
                "Если бы пришлось организовать своё шоу в цирке, что было бы главным номером?"

                "Какой наряд вы бы ни за что не надели?"
                "Назовите самый странный факт о себе."
                "Какой самый странный продукт вы когда-либо пробовали?"
                "Какой самый странный подарок вы когда-либо получали?"

                "Какой самый забавный момент в вашей жизни вам больше всего запомнился?"

                "Если бы у вас была возможность попробовать любую профессию на один день, что бы вы выбрали и почему?"
                "Есть ли у вас предмет из детства, который вы до сих пор храните как сувенир? Если да, то какой?"

                "Что для вас является источником счастья и радости в повседневной жизни?"

                "Что вас вдохновляет в последнее время? Может быть, новое увлечение или идея?"

                "Какие фильмы или сериалы вы недавно посмотрели и можете порекомендовать?"

                "Если бы вы могли выбрать любую страну для путешествия прямо сейчас, куда бы отправились и почему?"

                "В чём заключается смысл жизни?"
                "Все события предопределены?"
                "Что такое справедливость? Как мы можем достичь её в обществе?"
                "Что такое добро и зло? Как мы можем различать их?"
                "Каково значение искусства в нашей жизни?"
                "Существует ли абсолютная истина или всё относительно?"
                "Что привычно: материя или сознание?"
                "Каково значение этики в повседневной жизни?"
                "Можно ли достичь абсолютного счастья?"
                "Какова роль религии в нашей жизни?"
                "Может ли человек познать всё о мире или есть пределы нашего познания?"
                "Что такое дружба? Какие качества делают её настоящей?"
                "Каково значение толерантности и уважения к различиям во мнениях?"
                "Существует ли объективная мораль или каждый определяет свои собственные нормы?"
                "Что такое время? Как оно влияет на наше восприятие мира?"
                "Каково значение образования и самообразования в жизни человека?"
                "Может ли человек быть счастлив, живя в соответствии с ложными убеждениями?"
                "Что такое человеческое достоинство?"
                "Как мы можем развивать свой эмоциональный интеллект?"
                "Существует ли предназначение или каждый создаёт свой собственный путь?"
                "Как мы можем достичь гармонии между личными ценностями и общественными ожиданиями?"
            |]

        let reactions =
            questions
            |> Array.map (fun question ->
                createReaction
                    (sprintf "# Тема\n%s" question)
                    "https://c.tenor.com/9aUgRaFHsX8AAAAd/tenor.gif"
            )

        yield Command.create
            (CommandId.tryDeserialize "0d1b70b8-7a11-45b6-a9e3-c5484f72f017" |> Result.get)
            {
                Names = [| "тема"; "темы" |]

                OnSelf = reactions

                OnBot = reactions

                OnOther = reactions

                Cooldownable = None
            }

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
