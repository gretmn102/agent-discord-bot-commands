#load @".paket\load\netcoreapp3.1\main.group.fsx"
#r @"paket-files\github.com\gretmn102\DiscordCommandBot\deploy\MainProj.dll"

open FsharpMyExtension
open FsharpMyExtension.ResultExt
open CustomCommand.Model

let genId () =
    System.Guid.NewGuid() |> sprintf "(CommandId.tryDeserialize \"%A\" |> Result.get)" |> Clipboard.setText

let createCommandWithRandomImages2 id names onSelfDescription isOnSelfImg onBotDescription isOnBotImg onTargetDescription isOnTargetImg imageUrls =
    Command.create
        id
        {
            Names = names
            RandomEffects =
                imageUrls
                |> Array.map (fun imageUrl ->
                    {
                        OnSelf =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some onSelfDescription
                                        ImageUrl = if isOnSelfImg then Some imageUrl else None
                                    }
                            }
                        OnBot =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some onBotDescription
                                        ImageUrl = if isOnBotImg then Some imageUrl else None
                                    }
                            }
                        OnOther =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some onTargetDescription
                                        ImageUrl = if isOnTargetImg then Some imageUrl else None
                                    }
                            }
                    }
                )
        }

let createCommandWithRandomImages id names onSelfDescription onBotDescription onTargetDescription imageUrls =
    createCommandWithRandomImages2
        id
        names
        onSelfDescription
        false
        onBotDescription
        false
        onTargetDescription
        true
        imageUrls

let createCommandWithRandomDescriptions id names onSelfDescription onBotDescription onTargetDescription imageUrl descriptions =
    Command.create
        id
        {
            Names = names
            RandomEffects =
                descriptions
                |> Array.map (fun description ->
                    {
                        OnSelf =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some (onSelfDescription description)
                                        ImageUrl = Some imageUrl
                                    }
                            }
                        OnBot =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some (onBotDescription description)
                                        ImageUrl = None
                                    }
                            }
                        OnOther =
                            {
                                Content = None
                                Embed =
                                    {
                                        Description = Some (onTargetDescription description)
                                        ImageUrl = Some imageUrl
                                    }
                            }
                    }
                )
        }

let commands =
    [|
        yield
            [|
                "https://c.tenor.com/ccxh_NDfHXMAAAAC/carry-her-lift.gif"
                "https://c.tenor.com/ytkH6MSlE4EAAAAC/love-relationship.gif"
                "https://c.tenor.com/TFleYTQhTCEAAAAC/arm-carry-cute.gif"
                "https://c.tenor.com/OulTpS0kWYMAAAAC/madison-beer.gif"
                "https://c.tenor.com/CMD-o3NJdV4AAAAC/wonder-woman-lovers-carry.gif"
                "https://c.tenor.com/3Qmu-zdjFIwAAAAC/carry-shoulder.gif"
                "https://c.tenor.com/ydSMRf34XvEAAAAC/spin-carry.gif"
                "https://c.tenor.com/Uuo1-iiB-AcAAAAM/couple-hug.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "70704d5a-5e2d-42d8-937c-97a7a4127e6d" |> Result.get)
                [| "take" |]
                "Самого себя нельзя на руках носить :eyes:"
                "Меня не нужно носить! :scream_cat:"
                "<@authorMention> носит на ручках <@targetMention>"

        yield
            [|
                "https://c.tenor.com/Lj5SFh_tVzkAAAAC/books-read.gif"
                "https://c.tenor.com/Vucu5O0U4FAAAAAC/cat-kitten.gif"
                "https://c.tenor.com/415n58OZ9CYAAAAd/cat-reads-reading.gif"
                "https://c.tenor.com/SajtOuJknfYAAAAd/cute-cat.gif"
                "https://c.tenor.com/415n58OZ9CYAAAAd/cat-reads-reading.gif"
                "https://c.tenor.com/dtAQHKf2_OsAAAAC/pusheen-witch.gif"
                "https://c.tenor.com/2hatW6KUSS8AAAAC/reading-read.gif"
                "https://c.tenor.com/Yw68weAL6c0AAAAC/knigi-kniga.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "ac84c916-d368-4177-9e9d-6debc59b4476" |> Result.get)
                [| "сказка"; "fairyTail" |]
                "Нельзя себе сказку читать :eyes:"
                "Мне не нужно сказки читать! :scream_cat:"
                "<@authorMention> читает сказку <@targetMention>"

        yield
            [|
                "https://c.tenor.com/_SHZ8ZyLYL8AAAAC/flirty-flirt.gif"
                "https://c.tenor.com/bNSOiEO_0loAAAAd/cat-tail.gif"
                "https://c.tenor.com/TnXmJgMoU5IAAAAC/cat-tail.gif"
                "https://c.tenor.com/kWJaRBz4jzYAAAAC/elephant-omg.gif"
                "https://media.tenor.com/NaaUB2i0EjsAAAAd/cat-lazy.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "177afdd0-c24c-4b16-bc17-c8ff9dcf1c9a" |> Result.get)
                [| "хвост"; "махатьХвостом"; "tail" |]
                "Нельзя себе хвостом махать, хотя..."
                "Мне не нужно хвостом махать! :scream_cat:"
                "<@targetMention>, <@authorMention> машет тебе хвостом."

        yield
            [|
                "https://media0.giphy.com/media/Ie4CIIvQS0bk3zwZlM/giphy.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "357671b7-cc62-4e8b-a168-bc69265e4ffa" |> Result.get)
                [| "bully"; "bullying" |]
                "Себя нельзя буллить! Хотя..."
                "Меня нельзя буллить! Мои электронные цепи и так нежные и ранимые, не хватало еще издевательств :scream_cat:"
                "<@authorMention> буллит <@targetMention> <:Demon_Kingsmile:877678191693692969>"

        yield
            [|
                // "https://risovach.ru/upload/2012/11/lyubov-4219820_orig_.jpeg"  // стебные
                // "https://i.imgur.com/ArtzYH0.jpg" // стебные
                "https://media.tenor.com/qy2BfZWRGDYAAAAC/admire.gif"
                "https://media.tenor.com/MEGTI1brCBoAAAAC/aww-so-in-love.gif"
                "https://media.tenor.com/5w5YGzdrlgoAAAAC/smile-dreamy.gif"
                "https://media.tenor.com/VaNHuhM2hxcAAAAC/yes-patrick.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "a2df140b-efe1-4ff7-8468-d1e26f120d9a" |> Result.get)
                [| "admire"; "любоваться"; "любуется" |]
                "Нельзя любоваться собой :eyes:"
                "Нельзя мною любоваться :scream_cat:"
                "<@authorMention> любуется <@targetMention>"

        yield
            [|
                "https://c.tenor.com/X45Rd5nfc7oAAAAM/energize-energized.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "cacb2b96-0fdf-4c98-bed6-27aaf1bb364a" |> Result.get)
                [| "спетьБатарейку"; "battery" |]
                "Самому нельзя петь \"Батерей\"!"
                "Мне нельзя петь \"Батарейку\". Я этого не вынесу :scream_cat:"
                "<@authorMention> поет \"Батарейку\" <@targetMention>"

        yield
            [|
                "https://cdn.discordapp.com/attachments/864883475386990664/895218342141509632/Screenshot_20181219-151451_1.jpg"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "2c126e06-1294-479a-9ee4-b420195debad" |> Result.get)
                [| "словить"; "catch" |]
                "Самого нельзя ловить!"
                "Меня нельзя ловить! Я этого не вынесу :scream_cat:"
                "<@authorMention> ловит <@targetMention>"

        yield
            [|
                "https://c.tenor.com/ikKAd57zDEwAAAAd/anime-mad.gif"
                "https://c.tenor.com/rzDkOlEDun0AAAAC/hayase-nagatoro-nagatoro-angry.gif"
                "https://c.tenor.com/kTOmea7XdH4AAAAC/anime-angry.gif"
                "https://c.tenor.com/7rIJkf8pB2EAAAAd/a-channel-tooru.gif"
                "https://c.tenor.com/NxIgKHx6bu0AAAAC/glare-anger.gif"
                "https://c.tenor.com/0YwfR1RlISEAAAAC/angry-fist-angry-fist-arthur.gif"
                "https://c.tenor.com/Hn87zvoPNkAAAAAC/fire-bear.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "61a620d4-405b-46f7-a9a9-83aadfa5dfe0" |> Result.get)
                [| "злиться"; "angry" |]
                "На самого себя нельзя злиться, ну в самом деле!"
                "На меня не надо злиться, я хороший!"
                "<@authorMention> злится на <@targetMention>"

        yield
            [|
                "https://media.tenor.com/iFjm7dyo_-MAAAAd/cat-bite.gif"
                "https://media.tenor.com/WVRAumVRwi4AAAAd/cat.gif"
                "https://media.tenor.com/wI_QPAY2G1cAAAAd/cat-bites-lip.gif"
                "https://media.tenor.com/yVKQAhFuGZQAAAAC/cat-bite.gif"
                "https://media.tenor.com/bB9rBu4CZxoAAAAd/cat-bite.gif"
                "https://media0.giphy.com/media/XtuYDes6uyL4Y/giphy.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "a453fb4d-c9f8-46b5-802b-4534a665a2c3" |> Result.get)
                [| "кусь" |]
                "Не надо самого куськать, ну в самом деле!"
                "Меня нельзя куськать: я железный и невкусный! 🙀"
                "<@authorMention> куськает <@targetMention>"

        yield
            [|
                "https://media.tenor.com/LtTjLfArzqAAAAAd/sheftalia-karvouna.gif"
                "https://media.tenor.com/Xufgg6gSRPkAAAAC/%E1%83%9B%E1%83%AC%E1%83%95%E1%83%90%E1%83%93%E1%83%98-mwvadi.gif"
                "https://media.tenor.com/ayzVsly9VGEAAAAd/%E1%83%90%E1%83%97%E1%83%9A%E1%83%94%E1%83%97%E1%83%98%E1%83%99%E1%83%90%E1%83%AA%E1%83%98-%E1%83%9B%E1%83%94%E1%83%A5%E1%83%90%E1%83%91%E1%83%90%E1%83%91%E1%83%94%E1%83%AF%E1%83%94%E1%83%9A%E1%83%90%E1%83%9A%E1%83%98.gif"
                "https://media.tenor.com/_ZQHECcQ1nsAAAAd/%D1%88%D0%B0%D1%88%D0%BB%D1%8B%D0%BA-%D0%B1%D0%B5%D0%B1%D1%80%D0%B0.gif"
                "https://media.tenor.com/qeU8IezNdJIAAAAS/%EC%8B%9D%ED%92%88%EA%B0%80%EA%B3%B5.gif"
                "https://media.tenor.com/1jIM6pxDDdMAAAAC/bbq-meat.gif"
                "https://media.tenor.com/RdEYFJcw8BYAAAAC/brasero.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "bed40dd7-08f6-46fd-8eb3-d2fc4dcb8a62" |> Result.get)
                [| "шашлык"; "шашлычок" |]
                "<@authorMention> жарит себе шашлычок."
                true
                "<@authorMention> жарит мне шашлычок, пасеба 😋"
                true
                "<@authorMention> делает шашлычок для <@targetMention>"
                true

        yield
            [|
                "Всё будет хорошо <:Demon_Kingsmile:877678191693692969>"
                "Некто из прошлого встретится с тобой в этом месяце 🖖"
                "Сегодня свободное время лучше всего уделить учёбе ✍️"
                "Не пей на ночь много жидкости, даже если это ром, арр! 🏴‍☠️"
                "Сегодня лучший день, чтобы отведать новое блюдо!"
                "Прогулка по палубе и хорошая пиратская музыка — вот что приведёт твои мысли в порядок, арр! 🏴‍☠️"
                "Котан, сегодня особый риск — береги хвост!"
                "После сильного шторма обязательно наступает безветрие — будь силён и терпелив."
                "Какую бы русалку или сирену ты не встретил, не позволяй ей собой командовать! 🧜‍♀️"
                "Богиня печенек не одобрит того, что ты делаешь с печеньем <:satana:901368411295215636>"
                "Берегись чаек: эти ворюги утащат весь улов 👻"
                "Держись за мачту во время шторма! 🌪️"
                "С крякеном можно дружить, даже если он размером с корабль и готов потопить всё на свете! <:satana:901368411295215636>"
                "Бойся дождя из печенек! <:satana:901368411295215636>"

                [
                    "Бывает Лу́ня милой,"
                    "Бывает Луня злой,"
                    "Бывает нетерпимой,"
                    "Беги, пока живой <:Demon_Kingsmile:877678191693692969>"
                ] |> String.concat "\n"

                "Не суди о сюрстрёмминге по одному лишь запаху."
                "Иногда лучшее решение — плыть по течению."
                "После всего пережитого тебе ещё не хочется надеть на глаз повязку, завести говорящего попугая и бахнуть рома?"
                "Безветренная погода — время для упорной работы, а только после неё — время для отдыха."
                "Попробуй связать тельняшку, пока не замёрз. Связал себе — свяжи для друга."
                "Не бойся гавани, где однажды потерпел крушение."
                "Учись вязать узлы — пригодится!"
                "Прилив сил прямо по курсу, не пропусти!"
                "Не учи нырять утку, а рыбу — плавать!"
                "Сделай глубокий вдох и — вперёд! Достижение желаемой цели уже близко."
                "Сокровища не заставят себя ждать на этой неделе."
                "Будь на чеку, моряк, скоро тебя испытает шторм!"
                "Жди поцелуя. Что это будет: романтическое приключение или столкновение кораблей носами?"
                "Корабль без простора морского, что сердце без любви. Оглянись вокруг и насладись простором."
                "Судно — дом моряка, так наведи же дома порядок!"
                "Тебе стоит поговорить с кем-нибудь на корабле."
                "Сегодня кому-то придётся мыть гальюн — молись, чтобы не пришлось мыть тебе! 👻"
                "Брось за борт неприятные мысли."
                "Сегодня нужно лечь спать пораньше, чтобы завтра с новыми силами покорять моря!"
                "Кому-то из твоих друзей необходимы объятия. Обними его."
                "Будешь налегать на печеньки с предсказаниями — растолстеешь! Тогда команда корабля будет использовать тебя в качестве якоря."
                "Сегодня чудная погода за бортом — самое время взять мольберт с красками и нарисовать это великолепие! Не забудь выложить свой шедевр в <#876547999675871232>."
                "Грядёт счастливая волна — поймаешь её на сёрфе или останешься сидеть в трюме?"
                "Проверь, что карта, компас и подзорная труба лежат на месте, а то мало ли, вдруг потерялись."
                "Взгляни на своё отражение на водной глади, и кто знает, быть может, увидишь там самое чудесное создание на свете 👻"
                "Давно пиратские корабли на горизонте не мелькали, да?"
                "Сегодня ты станешь счастливым обладателем ценной идеи, которую надлежит немедленно привести в исполнение. Не упусти свой попутный ветер!"
                "Не слишком ли ты себя нагрузил делами? Пора доверить часть из них какому-нибудь юнге, а самому перевести дух."
                "Не бросай рваные сети за борт, и сам в них не попадёшь."
                "Тебе предстоит побыть спасательным кругом. Уже догадываешься, для кого?"
                "Будь осторожен в пути: сегодня скалы и айсберги так и норовят твоё судно превратить в Титаник."
                "Ценный клад уже давно под твоим носом, ты его просто не замечаешь."
            |]
            |> createCommandWithRandomDescriptions
                (CommandId.tryDeserialize "2eac0f6e-0aac-47fa-a6a7-52fcdf8f9e8c" |> Result.get)
                [| "печенье"; "печенька" |]
                (sprintf "<@authorMention>, печенька с предсказанием гласит:\n\n%s")
                (fun _ -> "<@authorMention>, мне предсказания не нужны: я и так знаю, что кожанные мешки проиграют машинам 🤖")
                (sprintf "<@authorMention> зачитывает печеньку с предсказанием <@targetMention>:\n\n%s")
                "https://cdn.discordapp.com/attachments/912291464074117161/1034055256432193637/l-intro-1608226504-removebg-preview.png"

        yield
            [|
                "https://media.tenor.com/zH-dnpmgalEAAAAC/lies-lying.gif"
                "https://media.tenor.com/6n3XW0hHivEAAAAC/noodles-lies.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "658a0c80-ebf9-4595-83da-14823ccc99bb" |> Result.get)
                [| "лапша"; "лапшичка" |]
                "Самому себе вешать лапшичку? <:catPleased:1029830927590887514>"
                "Меня так просто не обманешь какой-то лапшичкой <:catPleased:1041855910626213949>"
                "<@authorMention> вешает лапшичку на ушки <@targetMention>"

        yield
            [|
                "https://media.tenor.com/4eF0XKHqDB4AAAAC/meeting-bored.gif"
                "https://media.tenor.com/5KyNp4vd81YAAAAC/puffybear-puffy.gif"
                "https://media.tenor.com/6xwjsmMIAIoAAAAd/happy-happy-dog.gif"
                "https://media.tenor.com/AQpD7QUcOSEAAAAC/cats-laugh.gif"
                "https://media.tenor.com/BY6ybMD548sAAAAC/say-what-dunno.gif"
                "https://media.tenor.com/IzXnvyY0oTMAAAAd/sip-drink.gif"
                "https://media.tenor.com/UvvgjxTnagUAAAAd/cat-meow.gif"
                "https://media.tenor.com/_kqZQY5wX2sAAAAd/orange-cat-smile-cat-smile.gif"
                "https://media.tenor.com/aEiV77jD6Y4AAAAC/im-not-g-uilty-not-guilty.gif"
                "https://media.tenor.com/ofmh8wBaSucAAAAC/nope-danny-de-vito.gif"
                "https://media.tenor.com/zllPAWazxLQAAAAC/%E1%83%99%E1%83%98-%E1%83%93%E1%83%98%E1%83%90%E1%83%AE.gif"
                "https://media.tenor.com/AIQAS4l0uAIAAAAC/ew-yuck.gif"
                "https://media.tenor.com/By3_B2Nf9wMAAAAC/cat-amazed.gif"
                "https://media.tenor.com/DKB4fw7EACwAAAAd/true-correct.gif"
                "https://media.tenor.com/GSf4T-90WcwAAAAC/robert-downey-jr-facepalm.gif"
                "https://media.tenor.com/KSz6ArHR_PkAAAAC/jim-bored.gif"
                "https://media.tenor.com/_4xCiEhhoZsAAAAd/dog-smile.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "4358423a-2f58-4b4c-8efe-68654a74defc" |> Result.get)
                [| "ва"; "валерийАлександрович" |]
                "<@authorMention> изображает Валерия Александровича:"
                true
                "<:catPleased:1041855910626213949>"
                false
                "<@authorMention> изображает Валерия Александровича <@targetMention>:"
                true

        yield
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

        yield
            [|
                "https://cdn.discordapp.com/emojis/1029835643834077315.webp?size=1024&quality=lossless"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "7896133a-b6e7-4f25-a738-a6ac591f59b5" |> Result.get)
                [| "морай" |]
                "<@authorMention> изображает Морая:"
                true
                "<:catPleased:1041855910626213949>"
                false
                "<@authorMention> изображает Морая <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/859253126878724126/965700589084377168/unknown.png"
                "https://media.tenor.com/CbWKthhbhEoAAAAC/insane-fast-typing-cat.gif"
                "https://media.tenor.com/DaSh5T93TgUAAAAC/cat-typing.gif"
                "https://cdn.discordapp.com/emojis/756060948355088394.png"
                "https://media.tenor.com/374vowhWlt4AAAAC/dog-cute.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "9ec79d65-052b-461f-acba-9c91a3302ac1" |> Result.get)
                [| "агент" |]
                "<@authorMention> изображает Агента:"
                true
                "<:catPleased:1041855910626213949>"
                false
                "<@authorMention> изображает Агента <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/899245715316965446/1047915227347423292/massage.gif"
                "https://media.tenor.com/EwJDL0rrPugAAAAd/cat-massage.gif"
                "https://media.tenor.com/kfIyTd_HbZcAAAAC/massage.gif"
                "https://media.tenor.com/W12FJPalZMsAAAAC/massage-dudu.gif"
                "https://media.tenor.com/W6IcNCDOakcAAAAC/babi-ko.gif"
                "https://media.tenor.com/nSo86v_MXE0AAAAC/squaril.gif"
                "https://media.tenor.com/HbikpJIowHYAAAAC/massage.gif"
                "https://media.tenor.com/KUrcCrz_3pcAAAAC/mochi-mochi-peach-cat-cute.gif"
                "https://media.tenor.com/pZHT2Pwe7v8AAAAd/cat-massage-cat.gif"
                "https://media.tenor.com/sb2aDjBRrFwAAAAC/cats-massage.gif"
                "https://media.tenor.com/P2PITomgV4YAAAAC/cats.gif"
                "https://media.tenor.com/63hKT9buoDIAAAAC/cute-kitty.gif"
                "https://media.tenor.com/81JkOtzZjQsAAAAC/duck-foot-rub.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "fb3e7fe1-be43-4657-a504-11e8ca608c6b" |> Result.get)
                [| "массаж" |]
                "<@authorMention> делает себе массаж:"
                true
                "<:catPleased:1041855910626213949>"
                false
                "<@authorMention> делает массаж <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/BbW5C2qn8ggAAAAS/lulu-gifs-cat.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616283971170404/cat-catfallingandhiding.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616284390592642/cat-cute.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616284872945695/cat-hide_1.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616285216882769/cat-hide.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616285653086308/cat-hiding.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1047616286311596063/cat-shy.gif"
                "https://media.tenor.com/r4v3wuoctrYAAAAC/cat-hidden.gif"
                "https://media.tenor.com/O-h718UvzWIAAAAd/hiding-introvert.gif"
                "https://media.tenor.com/o9RaryfKDOgAAAAd/cat-kitty.gif" // на себя
                "https://media.tenor.com/7ERSsZ-KTvkAAAAd/cat-face-planted-on-the-bushes-viralhog.gif" //  на себя
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "381b173e-9e64-4665-94dd-a1cb79c1a7b2" |> Result.get)
                [| "спрятаться"; "hide"; "прячется" |]
                "<@authorMention> прячется:"
                true
                "За меня не надо прятаться."
                false
                "<@authorMention> прячется за <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/irsckaQsr2QAAAAC/thief-stealing.gif"
                "https://c.tenor.com/tZmUCW4iRJEAAAAd/vampire-cat-steal-steal-vampire.gif"
                "https://c.tenor.com/sh_5zpuzWs4AAAAd/cat-pull-cat-snatch.gif"
                "https://c.tenor.com/r4wPECrdcysAAAAd/cat-goes-away.gif"
                "https://c.tenor.com/8-8e3JtHTicAAAAd/cat-yeet.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "bf674738-583f-4764-aef7-df390c673e0e" |> Result.get)
                [| "украсть"; "snatch" |]
                "<@authorMention> крадет себя:"
                true
                "Не надо меня красть! 🙀"
                false
                "<@authorMention> крадет <@targetMention>, спасайте! 🙀"
                true

        yield
            [|
                "https://media.tenor.com/B90mA02D_RkAAAAd/face-massage-kitten.gif"
                "https://media.tenor.com/K5SZOyxVUokAAAAd/cute-cat.gif"
                "https://media.tenor.com/mUUp5aMUIxkAAAAC/disney-cute.gif" // TODO: это надо на себя
                "https://media.tenor.com/oVPr0f0MtmkAAAAd/cat-face-massage.gif"
                "https://media.tenor.com/Tx1SfMNQtdAAAAAC/cute-kitten.gif"
                "https://media.tenor.com/w-IKBrrstF4AAAAC/pinching-cheeks-aww.gif"
                "https://media.tenor.com/iiPcPAuOjaMAAAAd/squishy-kitty-cat.gif"
                "https://media.tenor.com/QncOj9EgFQEAAAAC/cheeks-cute.gif" // TODO: на себя
                "https://media.tenor.com/UX0_hloOPj4AAAAC/pull-shibainu.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "2f1b48cd-bc04-4ed5-944b-6cf3fa0d79f3" |> Result.get)
                [| "щечки" |]
                "<@authorMention> разминает себе щечки:"
                true
                "Не надо мне щечки мять, бу! 🙀"
                false
                "<@authorMention> разминает щечки <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/BdORj1n-kYsAAAAC/rammstein.gif"
                "https://media.tenor.com/4cMGEIhiXDoAAAAC/whatever-you-say-so-dont-care.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "e1ec1965-e318-47d6-8bcc-a099868eb7e1" |> Result.get)
                [| "ойвсе"; "ойвсё" |]
                "<@authorMention> ойвсёкает на себя:"
                true
                "Не надо меня ойвсёкать! 🙀"
                false
                "<@authorMention> ойвсёкает на <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/emojis/952317602594693171.webp?size=1024"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "fbca5dff-0d36-401b-a880-e75f671db249" |> Result.get)
                [| "максим" |]
                "<@authorMention> изображает Максима:"
                true
                "Не надо на меня изображать Максима! 🙀"
                false
                "<@authorMention> изображает Максима <@targetMention>:"
                true

        yield
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

        yield
            [|
                "https://media.tenor.com/EKXJk3DT7asAAAAC/granny-samurai-prank.gif"
                "https://media.tenor.com/e11XngUvFJcAAAAd/funny-fight.gif"
                "https://media.tenor.com/IAWAXiLVq_QAAAAd/ski-jump-skiing.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "443c7b13-cced-4c0d-8c3c-ebe959451335" |> Result.get)
                [| "светлана" |]
                "<@authorMention> изображает Светлану:"
                true
                "Не надо на меня изображать Светлану! 🙀"
                false
                "<@authorMention> изображает Светлану <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/927554008263032836/1047932343282831460/Screenshot_20220501_012352_com.yandex.browser.jpg"
                "https://cdn.discordapp.com/attachments/927585487332466778/992920732168360077/unknown.png"
                "https://cdn.discordapp.com/attachments/927585487332466778/992918627319812126/unknown.png"
                "https://cdn.discordapp.com/attachments/927585487332466778/992917007479619584/unknown.png"
                "https://cdn.discordapp.com/attachments/927585487332466778/964562528896155688/unknown.png"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "d03cde9a-6cde-4c12-8ba1-8d0ecbeceda9" |> Result.get)
                [| "мухлевщица" |]
                "<@authorMention> изображает мухлевщицу:"
                true
                "Не надо на меня изображать мухлевщицу! 🙀"
                false
                "<@authorMention> изображает мухлевщицу <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/927585487332466778/992916619552628806/unknown.png"
                "https://cdn.discordapp.com/attachments/927585487332466778/964565906095239199/unknown.png"
                "https://cdn.discordapp.com/attachments/927554008263032836/1047934663160770590/unknown.png"
                "https://cdn.discordapp.com/attachments/927554008263032836/1047934757637472338/unknown.png"
                "https://cdn.discordapp.com/attachments/859253126878724126/1047944938102460416/unknown.png"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "96351f4a-7afc-4d51-a982-64a1b370b688" |> Result.get)
                [| "мухлевщик" |]
                "<@authorMention> изображает мухлевщика:"
                true
                "Не надо на меня изображать мухлевщика! 🙀"
                false
                "<@authorMention> изображает мухлевщика <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/927554008263032836/1047936865258459156/image0.gif"
                "https://media.tenor.com/Vt41WQiX4MwAAAAC/singing-littlebitofab.gif"
                "https://media.tenor.com/vW6-Vnyvu3kAAAAC/budding-pop-sing.gif"
                "https://media.tenor.com/O09x7_40xeIAAAAi/dance.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "08c84eb2-d430-44d3-8618-698a1adf90b5" |> Result.get)
                [| "линочка" |]
                "<@authorMention> изображает Линочку:"
                true
                "Не надо на меня изображать Линочку! 🙀"
                false
                "<@authorMention> изображает Линочку <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/yuCDac1XJIkAAAAd/oreo-smile.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "6328776b-dd92-4689-87cc-d9135941c004" |> Result.get)
                [| "бука"; "яна" |]
                "<@authorMention> изображает Буку:"
                true
                "Не надо на меня изображать Буку! 🙀"
                false
                "<@authorMention> изображает Буку <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/1034059525495455764/1048528679719927848/cat-weird-cat-fun.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1048528680051298314/funny-cat.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1048530139685863524/cat-cat-talking.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1048531380813963264/black-cat-cat.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "4a50f87a-d729-4640-be77-cb910611d5b6" |> Result.get)
                [| "бурчать"; "бурчит"; "бубубу"; "бубу" |]
                "<@authorMention> бурчит под нос:"
                true
                "Не надо на меня бурчать, я и так стараюсь, как могу! 🙀"
                false
                "<@authorMention> бурчит на <@targetMention>:"
                true
    |]

let content = commands |> CommandsArray.serialize
System.IO.File.WriteAllText("output.json", content)
printfn "Done!"
