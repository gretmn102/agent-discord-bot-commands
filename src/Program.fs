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
                "https://cdn.discordapp.com/attachments/876706882423762994/895897487422914640/qdNVIlPoG8o.jpg"
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
                "https://c.tenor.com/9OGqk-WVlNEAAAAC/cats-chase.gif"
            |]
            |> createCommandWithRandomImages
                (CommandId.tryDeserialize "2c126e06-1294-479a-9ee4-b420195debad" |> Result.get)
                [| "словить"; "catch"; "споймать"; "поймать" |]
                "Самого нельзя ловить!"
                "Меня нельзя ловить! Я этого не вынесу :scream_cat:"
                "<@authorMention> ловит <@targetMention>"

        yield
            [|
                // "https://c.tenor.com/ikKAd57zDEwAAAAd/anime-mad.gif"
                // "https://c.tenor.com/rzDkOlEDun0AAAAC/hayase-nagatoro-nagatoro-angry.gif"
                // "https://c.tenor.com/kTOmea7XdH4AAAAC/anime-angry.gif"
                // "https://c.tenor.com/7rIJkf8pB2EAAAAd/a-channel-tooru.gif"
                // "https://c.tenor.com/NxIgKHx6bu0AAAAC/glare-anger.gif"
                // "https://c.tenor.com/0YwfR1RlISEAAAAC/angry-fist-angry-fist-arthur.gif"
                // "https://c.tenor.com/Hn87zvoPNkAAAAAC/fire-bear.gif"
                "https://media.tenor.com/4rBafeqPOj0AAAAC/mad-angry.gif"
                "https://media.tenor.com/gWVekiI5onwAAAAC/madcat-ygzcat.gif"
                "https://media.tenor.com/qzimWk_DVYUAAAAd/cat-angry-angry.gif"
                "https://media.tenor.com/SN6EKkspK5UAAAAd/suspense-suspicious.gif"
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
                "https://media.tenor.com/p9AJkXcmJucAAAAC/nom-tik-tok.gif"
                "https://cdn.discordapp.com/attachments/876498372939382784/948864222912204800/03e6f05d01f87f934a5c2b547bf77e61.jpg"
                "https://media.tenor.com/snjr2hMxcs8AAAAd/funny-animals-kitty.gif"
                "https://c.tenor.com/e3XWGaLSpW4AAAAd/tenor.gif"
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
                "Сегодня чудная погода за бортом — самое время взять мольберт с красками и нарисовать это великолепие! Не забудь выложить свой шедевр в <#1084967380146470942>."
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

                "У опытного морехода морской болезни быть не может, а вот нервный тик вызвать можно. Крутите штурвал в одну сторону пару минут, и сами всё увидите."
                "Затерянным в море дорогу подскажут звёзды. Доставай секстант."
                "Не бей шваброй тех, кто ходит по мытому полу палубы - лучше приобщи их к этому бравому делу!"
                "Запомни, салага: обороняться веслом от пирата – плохая идея."
                "Даже подзорная труба не нужна, чтобы прямо по курсу увидеть что-то хорошее."
                "Принимать важные решения в спешке – опрометчиво: рискуешь найти на мель."
                "Какое важное для себя решение ты принял недавно? Обдумай его ещё раз."
                "Попробуй новый сорт сыра."
                "Никогда не трогай зелёный шланг. Это притаившийся Змей, и ему от тебя нужны шоколадки."
                "Трюм пустеет, капитан! Запасы провианта заканчиваются! Пора их восполнить!"
                "Сегодня кое-кто захочет проверить, умеешь ли ты ходить по воде. Не дай столкнуть себя за борт!"
                "Завтра утро у тебя обязательно заладится. Но только если ты не переборщил с ромом."
                "Перестарался с валерьянкой на застолье – так хоть икай тихо, всех рыб распугаешь!"
                "Морские звёзды говорят, сегодня хороший день для отдыха."
                "Тонешь? Не молчи, что нужен спасательный круг!"
                "Солнце скоро выйдет из-за туч и согреет тебя."
                "Сделай наконец то, что так давно откладывал, и награди себя за это лакомством."
                "Корабль котиков не дрейфует, и ты не дрейфь!"
                "Потёртости и латки на парусах – это память о прошлом и опыт. Главное - уметь их расправить несмотря ни на что дальше ловить попутный ветер."
                "Держи голову прямо, а хвост по ветру, и всё будет хорошо!"
                "Отличный день, чтобы найти радость в каждодневных скучных делах."
                "Проветри свою каюту - и дышать станет легче."
                "Не паникуй раньше времени, если на мачту корабля сел буревестник."
                "Удача - это только малая часть успешной рыбалки. Бо́льшая - хорошая наживка и терпение."
                "Если каждый твой день похож на предыдущий, устрой вечеринку, только не переверните верх дном судно."
                "Как пелось в одной песне, «улыбнитесь, ведь улыбка - это флаг корабля»."
                "Не боишься, что тебя спутают с креветкой? Выпрями спину, котан!"

                "Впереди буря! Потребуется немыслимая сила, чтобы пережить свой девятый вал - не опускай лапы!"
                "Хороший клёв на рыбалке начинается с хорошей наживки."
                "Большие победы состоят из маленьких побед над самим собой."
                "Ветер поможет парусам, и намеченный путь будет проложен."
                "Предвидится штиль. Если хочешь, чтобы что-то случилось, перенимай инициативу: два весла в умелых лапах сделают намного больше, чем ожидание!"
                "Спустя месяц случится судьбоносное событие. Ты точно готов?"
                "Открыв одни новые земли, не останавливайся на достигнутом!"
                "Земля практически идеально круглой формы. А ты? Время хорошенько подкрепиться!"
                "\"Титаник\" строили профессионалы, а Корабль котиков - те, у кого лапки. И вот что вышло..."
                "Горизонт чист, все пути - у твоих лап. Выбери нужное направление!"
                "Совсем скоро тебя признают незаменимым членом команды!"
                "Тебя ждёт встреча с котом, который изменит твою жизнь."
                "Не бойся утонуть - бойся не попробовать научиться плавать."
                "Не оглядывайся на прошлое - развернуть корабль обратно всё равно не получится."
                "Не позволяй преградам на пути к твоему счастью быть сильнее."
                "Судно может найти на мель. Используй это время с умом!"
                "Готовься к приключениям и не удивляйся, если они настигнут тебя даже в знакомой гавани!"
                "Не заливай раны ромом - их исцелит время."
                "Скоро ты найдёшь занятие, которое тебя вдохновит на подвиги."
                "Доверься своей интуиции - сейчас она точно не подведёт."
                "Если собрался идти ко дну, пересядь на подлодку!"
                "Твои надежды и старания не напрасны!"
                "Ты получишь одобрение и поддержку, откуда не ждёшь."
                "Будь честен в первую очередь с самим собой, и тебя зауважают даже вредные пиявки."
                "В новые путешествия всегда найдётся время для новых открытий! Распахни пошире глаза, чтобы ничего не упустить!"
                "Море волнуется, не бери с него пример."
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
                "https://media.tenor.com/uoAnIlKgLSUAAAAd/what-cat.gif"
                "https://cdn.discordapp.com/attachments/1011244894020456488/1050386943571136573/IMG_20221208_152214_516.jpg"
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
                "https://media.tenor.com/jDWmx28SMacAAAAC/kittens-massaging.gif"
                "https://media.tenor.com/kfIyTd_HbZcAAAAC/massage.gif"
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
                "https://media.tenor.com/2pdRqiTB2GMAAAAC/cat-leave-me-alone.gif" // на себя
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
                "https://media.tenor.com/lhKSYOk8KTEAAAAC/grab-steal.gif"
                "https://cdn.discordapp.com/attachments/1201405133284716594/1246111775447974031/GIF_20240531_194258_989.gif"
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
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "2f1b48cd-bc04-4ed5-944b-6cf3fa0d79f3" |> Result.get)
                [| "щечки"; "щёчки" |]
                "<@authorMention> разминает себе щечки:"
                [|
                    "https://media.tenor.com/mUUp5aMUIxkAAAAC/disney-cute.gif"
                    "https://media.tenor.com/QncOj9EgFQEAAAAC/cheeks-cute.gif"
                |]
                "Не надо мне щечки мять, бу! 🙀"
                [||]
                "<@authorMention> разминает щечки <@targetMention>:"
                [|
                    "https://media.tenor.com/B90mA02D_RkAAAAd/face-massage-kitten.gif"
                    "https://media.tenor.com/K5SZOyxVUokAAAAd/cute-cat.gif"
                    "https://media.tenor.com/oVPr0f0MtmkAAAAd/cat-face-massage.gif"
                    "https://media.tenor.com/Tx1SfMNQtdAAAAAC/cute-kitten.gif"
                    "https://media.tenor.com/w-IKBrrstF4AAAAC/pinching-cheeks-aww.gif"
                    "https://media.tenor.com/iiPcPAuOjaMAAAAd/squishy-kitty-cat.gif"
                    "https://media.tenor.com/UX0_hloOPj4AAAAC/pull-shibainu.gif"
                    "https://media.tenor.com/EZelAU6S6McAAAAd/mochicat-cute.gif"
                    "https://media.tenor.com/XuLO9w5VJLUAAAAC/kitten-cute-cat.gif"
                |]

        yield
            [|
                "https://media.tenor.com/BdORj1n-kYsAAAAC/rammstein.gif"
                "https://media.tenor.com/4cMGEIhiXDoAAAAC/whatever-you-say-so-dont-care.gif"
                "https://cdn.discordapp.com/attachments/927554008263032836/1187705644988497930/1703241466840.jpg" // ёжик уходит с надписью "Ой, всё"
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
                "https://media.tenor.com/UqEPGGQJX1UAAAAC/ta-chegando.gif"
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
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775832859476008/Screenshot_2022-09-04_at_02-36-39_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775833157275688/Screenshot_2022-09-04_at_02-41-12_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775833434108025/Screenshot_2022-09-04_at_02-45-13_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775833681559562/Screenshot_2022-09-04_at_02-56-04_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775833929044068/Screenshot_2022-09-04_at_03-01-52_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775834193272915/Screenshot_2022-09-04_at_03-06-12_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775834805637190/Screenshot_2022-09-04_at_03-08-06_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775835040522240/767.PNG"
                "https://cdn.discordapp.com/attachments/778999058965987378/1015775835275411556/23546.PNG"
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
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477678378909726/Screenshot_2022-09-19_at_20-03-54_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477678743830569/Screenshot_2022-09-19_at_20-05-55_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477679209402479/Screenshot_2022-09-19_at_20-07-37_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477679641395383/Screenshot_2022-09-19_at_20-19-52_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477680023097435/Screenshot_2022-09-19_at_20-21-56_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477680438313000/Screenshot_2022-09-19_at_20-24-21_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477680887111780/Screenshot_2022-09-19_at_20-31-31_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477681293955133/Screenshot_2022-09-19_at_20-33-58_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477681696620585/Screenshot_2022-09-19_at_20-35-04_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477682061512874/Screenshot_2022-09-19_at_20-37-58_UNO_Online_-_UNO_Online_CrazyGames.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1021477725170581524/Screenshot_2022-09-19_at_20-44-50_UNO_Online_-_UNO_Online_CrazyGames.png"
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
                "https://cdn.discordapp.com/attachments/928223332019609610/1187448973976412311/IMG_2430.png"
                "https://cdn.discordapp.com/attachments/929387581194510347/1188129150196789339/IMG_2437.png"
                "https://cdn.discordapp.com/attachments/929387581194510347/1188129150637179000/IMG_2438.png"
                "https://cdn.discordapp.com/attachments/929387581194510347/1188129150972727347/IMG_2439.png"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "08c84eb2-d430-44d3-8618-698a1adf90b5" |> Result.get)
                [| "линочка"; "лина" |]
                "<@authorMention> изображает Линочку:"
                true
                "Не надо на меня изображать Линочку! 🙀"
                false
                "<@authorMention> изображает Линочку <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/yuCDac1XJIkAAAAd/oreo-smile.gif"
                "https://cdn.discordapp.com/attachments/876706882423762994/1034920477178724412/IMG_20221024_193031_1.png"
                "https://media.tenor.com/tInHoW8o9fkAAAAC/gamercat-cookies.gif"
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

        yield
            [|
                "https://media.tenor.com/Bev4TG664HQAAAAC/%D0%B1%D0%B5%D0%B6%D0%B8%D0%BC.gif"
                "https://media.tenor.com/nmY9uVcG-vkAAAAC/very-scary-movie2-priest.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "5b99c051-01c1-44f4-a531-55e2e927dec6" |> Result.get)
                [| "бежать"; "сбежать"; "сбегает" |]
                "<@authorMention> сбегает:"
                true
                "От меня не сбежать <:Demon_Kingsmile:877678191693692969>"
                false
                "<@authorMention> сбегает от <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/2UPCE4EQRi8AAAAC/please-begging.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "c974e9ee-3c56-4869-adcb-141d0388e3db" |> Result.get)
                [| "умолять"; "просить"; "умоляет" |]
                "<@authorMention> умоляет:"
                true
                "Тщетны твои мольбы <:Demon_Kingsmile:877678191693692969>"
                false
                "<@authorMention> умоляет <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/l5sIE_3H3EEAAAAd/cats-fighting-fighting-cats.gif"
                "https://media.tenor.com/2NUo71q5wbMAAAAC/cats-fight.gif"
                "https://media.tenor.com/saVFWCC23KoAAAAd/cat-fight-cats-fighting.gif"
                "https://media.tenor.com/l5sIE_3H3EEAAAAd/cats-fighting-fighting-cats.gif"
                "https://media.tenor.com/Y2JNQLkzz8sAAAAd/cats-funny.gif"
                "https://media.tenor.com/TPDruIOzoEkAAAAC/kitten-smol.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "e5141bbc-be19-4f91-8228-e71a4d13a89b" |> Result.get)
                [| "напасть"; "атаковать" |]
                "<@authorMention> няпадает:"
                true
                "Не советую на меня нападать <:Demon_Kingsmile:877678191693692969>"
                false
                "<@authorMention> няпадает на <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/igJNrzoEWiwAAAAC/faint-drama.gif"
                "https://media.discordapp.net/attachments/859253126878724126/1090804061676244992/output.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "d158506e-27a7-41f1-bca2-8fb9d6a9dbdb" |> Result.get)
                [| "драма" |]
                "<@authorMention> изображает королеву драмы:"
                true
                "Тщетны твои <:Demon_Kingsmile:877678191693692969>"
                false
                "<@authorMention> изображает королеву драмы перед <@targetMention>:"
                true

        yield
            [|
                "https://cdn.discordapp.com/attachments/1020769499370246198/1039880982448324658/4be76d1411ad3f91.png"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "908412ce-e724-44b0-a056-7ad192026aa3" |> Result.get)
                [| "ловелас"; "сердцеед" |]
                "<@authorMention> изображает из себя ловеласа:"
                true
                "Тщетны твои <:Demon_Kingsmile:877678191693692969>"
                false
                "<@authorMention> соблазняет <@targetMention>:"
                true

        yield
            [|
                "https://media.tenor.com/TcYTfeJkbmcAAAAC/%D0%BA%D0%BE%D1%82.gif"
                "https://media.tenor.com/b3QpV-rd7C4AAAAC/kitty-little-paws.gif"
                "https://cdn.discordapp.com/attachments/927554008263032836/1049192535500800000/bloggif_6123f977cfede-2-1-1-1-1.gif"
                "https://media.tenor.com/KZC1s7f-RZ4AAAAC/cute-kitten.gif"
                "https://c.tenor.com/Ar_RqkuvrNsAAAAd/tenor.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "de12b01f-2ec1-4b80-9264-1e76507ebf1e" |> Result.get)
                [| "лапки" |]
                "У <@authorMention> лапки:"
                true
                "Меня и так лапки сотворили."
                false
                "<@authorMention> показывает свои лапки <@targetMention>:"
                true

        yield
            [|
                "https://c.tenor.com/zKH6YcN6-rsAAAAd/kingking.gif"
            |]
            |> createCommandWithRandomImages2
                (CommandId.tryDeserialize "36fb4d93-7bcc-4f5f-926c-5e1812bf8d5e" |> Result.get)
                [| "выглянуть"; "выглядывает"; "выглядывание" |]
                "У <@authorMention> выглядывает:"
                true
                "Хватит выглядывать — пора действовать!"
                false
                "<@authorMention> подглядывает за <@targetMention>:"
                true

        yield
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

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "213d850a-c056-494c-ae1f-62458386c830" |> Result.get)
                [| "спать"; "sleep"; "уложитьСпать" |]
                "<@authorMention> укладывается спатюнькать:"
                [|
                    "https://media.tenor.com/MlEcr_6z6lEAAAAd/happy-christmas.gif"
                    "https://media.tenor.com/tIp8NWWKpokAAAAd/cat-lazy.gif"
                    "https://media.tenor.com/bBycY0Pdq_IAAAAC/iod-iodiod.gif"
                    "https://media.tenor.com/N2hl_fAdpmAAAAAd/cat-kitten.gif"
                    "https://media.tenor.com/MsKzT_aGMF8AAAAd/tired-good-night.gif"
                    "https://media.tenor.com/oDSUnnEJLKcAAAAC/cat-catzzz.gif"
                |]
                "<@authorMention>, лучше ты ложись, а мне еще работать и работать <:monika:876512461761691688>"
                [||]
                "<@authorMention> укладывает спать <@targetMention>:"
                [|
                    "https://media.tenor.com/VdIKn05yIh8AAAAd/cat-sleep.gif"
                    "https://media.tenor.com/R_cGlaPuqTQAAAAd/sleepy-cat-cat.gif"
                    "https://media.tenor.com/GS6roA5CehwAAAAd/cat-sleepy.gif"
                    "https://media.tenor.com/cCaPvVOJruEAAAAd/good-night-siesta.gif"
                    "https://media.tenor.com/xZL-YpO6wFcAAAAd/cat-kitty.gif"
                    "https://media.tenor.com/IJKuYz9RPYQAAAAd/cat-%D0%BA%D0%BE%D1%82.gif"
                |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "e0437fd8-455a-4345-86fe-2509d8b495fd" |> Result.get)
                [| "жужу"; "жужжать"; "жужжит"; "buzz" |]
                "<@authorMention> жужжит:"
                [|
                    "https://media.tenor.com/TwqntufBQVgAAAAd/cat-bee.gif"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050712130028064808/iu.png"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050712195069116466/iu.png"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050712314061541397/iu.png"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050712846159327262/jadejerilyn.png"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050715734248005683/iu.png"
                    "https://cdn.discordapp.com/attachments/1011244894020456488/1052238388079632414/b337286ba3aaf5cc.png"
                |]
                "<@authorMention>, не жужжи на меня, а то бип-буп сделаю <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> жужжит на <@targetMention>:"
                [|
                    "https://media.tenor.com/b922yKwSlO8AAAAC/bee-cat.gif"
                    "https://media.tenor.com/KUN8-p-Qrf4AAAAd/bee.gif"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050712378511212655/iu.png"
                    "https://cdn.discordapp.com/attachments/1050675277354766356/1050715734248005683/iu.png"
                |]

        yield
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

        let urls =
            [|
                "https://media.tenor.com/SFj-19Vp3YkAAAAC/kiss-flying.gif"
                "https://media.tenor.com/vmrR0VoDVRkAAAAC/blow-kiss-anime-blow-kiss.gif"
                "https://media.tenor.com/R1y3qRkSRwkAAAAC/anime-girl.gif"
                "https://media.tenor.com/43qt_qk-LWkAAAAC/cute-anime.gif"
                "https://media.tenor.com/7s-3eQ3MNtsAAAAC/laughs-kiis.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "4667fdc1-7d6f-4bef-960e-d3521cdae1fe" |> Result.get)
                [| "воздушныйПоцелуй"; "поцелуй" |]
                "<@authorMention> посылает воздушный поцелуй:"
                urls
                "<@authorMention>, мне роботу, из цифровой плоти и холодных логических цепей, чужда теплота двуногих, но все равно спасибо, бип-буп."
                [||]
                "<@authorMention> посылает воздушный поцелуй <@targetMention>:"
                urls

        let urls =
            [|
                "https://media.tenor.com/g3UwgAuiDWUAAAAd/cat-viralhog.gif"
                "https://media.tenor.com/utCF57nJhY0AAAAd/cat-tree.gif"
                "https://media.tenor.com/2SFJCV0M6r8AAAAd/cat-cats.gif"
                "https://media.tenor.com/6aSwChrWuhcAAAAC/cats-pull.gif"
                "https://media.tenor.com/3atPsShb-p0AAAAd/christmas-tree-fell-on-the-cat-viralhog.gif"
                "https://media.tenor.com/tr-LVhGZoGUAAAAd/cat-tree-cat-christmas-tree.gif"
                "https://media.tenor.com/Z2Z1-qwoZkoAAAAd/cat-xmas.gif"
                "https://media.tenor.com/fV7M7ji-JbkAAAAd/cat-vs-ornament-cat.gif"
                "https://media.tenor.com/PVexpkgAwoIAAAAd/cat-christmas-flying-xmas-cat.gif"
                "https://cdn.discordapp.com/attachments/927554008263032836/1058352914072096828/GIF-8672460d3336fa6d01b9be872b5d77f2.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "66486c02-9fff-47eb-baad-2930b4c6e432" |> Result.get)
                [| "ёлка"; "елка" |]
                "<@authorMention> играется с ёлкой:"
                urls
                "<@authorMention>, не трогай ёлку, бип-буп!"
                [||]
                "<@authorMention> валит ёлку <@targetMention>:"
                urls

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "501e5b5b-3dba-4dc7-ac67-a3ef01105162" |> Result.get)
                [| "снежок" |]
                "<@authorMention> ловит снежок:"
                [|
                    "https://media.tenor.com/AxE3ljKF0xAAAAAd/cat-cats.gif"
                    "https://media.tenor.com/UGpGSqdp-3AAAAAC/cat-catch.gif"
                |]
                "<@authorMention>, это кто там снежком бросается, бип-буп? <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> бросает снежок в <@targetMention>:"
                [|
                    "https://media.tenor.com/48IYu9PI9wMAAAAC/man-throw.gif"
                    "https://media.tenor.com/jySu4lBl_loAAAAd/snowman-snowball.gif"
                    "https://media.discordapp.net/attachments/906094410901643334/922919964669780038/9d32a24a8811.gif"
                |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "bee17367-86f6-4a35-a6ff-64d2188f3810" |> Result.get)
                [| "обнять" |]
                "<@authorMention> обнимает себя 🤗"
                [||]
                "<@authorMention>, я слишком холодный для всего этого, бип-буп."
                [||]
                "<@authorMention> обнимает <@targetMention>:"
                [|
                    "https://media.tenor.com/KbM-vf5iJ0cAAAAd/cats-hug.gif"
                    "https://media.tenor.com/IH3q87oSV5EAAAAd/cat-hug.gif"
                    "https://media.tenor.com/_w6z-q2Z8xEAAAAd/goodnite-moomoo.gif"
                    "https://media.tenor.com/eAKshP8ZYWAAAAAC/cat-love.gif"
                    "https://media.tenor.com/kBlRhi7nqYwAAAAd/cat-hugs-alydn.gif"
                    "https://media.tenor.com/uxo1ef9EdxQAAAAd/cat-cats.gif"
                |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "15ed1339-5db5-40f5-b149-b05cd88445e0" |> Result.get)
                [| "млем" |]
                "<@authorMention> млемает:"
                [|
                    "https://media.tenor.com/BZGFIFd4vZcAAAAC/mclovin-cat.gif"
                |]
                "<@authorMention>, не надо млемать на меня, бип-буп."
                [||]
                "<@authorMention> млемает на <@targetMention>:"
                [|
                    "https://media.tenor.com/BZGFIFd4vZcAAAAC/mclovin-cat.gif"
                |]

        let gifs =
                [|
                    "https://cdn.discordapp.com/attachments/927554008263032836/1057093913653018624/image0.gif"
                    "https://cdn.discordapp.com/attachments/927554008263032836/1057094982177140916/image0.gif"
                    "https://cdn.discordapp.com/attachments/859253126878724126/968132450142277642/tigidikYoYo.gif"
                    "https://c.tenor.com/mJw5w8xREjYAAAAd/playful-energy.gif"
                    "https://media.tenor.com/7K3u8X-NUU8AAAAd/dance-dancing.gif"
                    "https://cdn.discordapp.com/attachments/927554008263032836/1057096297573781634/image0.gif"
                    "https://tenor.com/ru/view/кот-котик-пушистый-скачет-кот-скачет-gif-7521206174951915808"
                |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "37687414-bd3c-49ff-a42c-1eed212c39a6" |> Result.get)
                [| "тыгыдык" |]
                "<@authorMention> тыгыдыкает:"
                gifs
                "<@authorMention>, никакого тыгыдыка в мою смену <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> тыгыдыкает с <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://media.tenor.com/G52nDAPVxYEAAAAC/iloveyou-dinner.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1064803027933986836/seal-love.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1064803028382785546/yesh.gif"
                "https://cdn.discordapp.com/attachments/1034059525495455764/1064803028714147890/-.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "f74fc8d7-44b4-4552-82c6-a226ba79bad6" |> Result.get)
                [| "кусьЩека" |]
                "<@authorMention> куськает за щеку:"
                gifs
                "<@authorMention>, никакого куся в мою смену <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> куськает за щеку <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://media.tenor.com/Lg21skpXtU4AAAAC/cat-meme.gif"
                "https://media.tenor.com/PGnGqfkIuLYAAAAC/cat-head.gif"
                "https://media.tenor.com/_zVIdn3Ok_cAAAAC/cat-scream.gif"
                "https://media.tenor.com/t5HqHfs2_sEAAAAC/cat-kitten.gif"
                "https://media.tenor.com/bQuWIFsZWEgAAAAC/thurston-waffles-meow.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "12d022d6-7e44-429e-8c46-178ea8fa1e27" |> Result.get)
                [| "орать"; "орет"; "орёт"; "кричит"; "кричать" |]
                "<@authorMention> кричит:"
                gifs
                "<@authorMention>, никакого ора в мою смену! <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> кричит на <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://cdn.discordapp.com/attachments/1074262266880466965/1074262416944283648/fa5dac8bf1f0a16f9c4330d8dfc64042.gif"
                "https://cdn.discordapp.com/attachments/1074262266880466965/1074262417254658108/a8c0789126e3711f87842b55024e0419.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "22481f64-d591-4b3f-8a72-ef7cd3ea01b1" |> Result.get)
                [| "наказать"; "отшлепать" |]
                "<@authorMention> шлепать:"
                gifs
                "<@authorMention>, никакого шлепа в мою смену! <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> шлепает <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://cdn.discordapp.com/attachments/912291464074117161/1079991686194810980/da338988c1bf205da96846aac3adf34c.png"
                "https://cdn.discordapp.com/attachments/912291464074117161/1079993526336618496/cute_chibi_riding_a_dragon_by_kianoromitria-d8p86nr.png"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "1cddb54b-bb69-468a-a46a-426e41b88908" |> Result.get)
                [| "луня" |]
                "— Я — зло!!! — кричит <@authorMention> и изображает Луню."
                gifs
                "<@authorMention>, никакого зла в мою смену! <:Demon_Kingsmile:877678191693692969>"
                [||]
                "— Я — зло!!! — кричит <@authorMention> и изображает Луню."
                gifs

        let gifs =
            [|
                "https://www.meme-arsenal.com/memes/744f89308a5fa818d9f1ed9b279ffc06.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080059754661023764/images.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080059754883326034/98ta98.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080059755114004561/eba9a5f05f444d223c2e5f490f1741e4.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080059162551132220/d2ba84adc70a3c.jpg"
                "https://media.tenor.com/NSU0PJoI_0MAAAAC/peepo-peepo-riot.gif"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080060371194351616/d228639abc790ca09e6951f7f1a35509.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080061425654976592/14-36-24-9k.jpg"
                "https://media.tenor.com/p4jBKqXWHnoAAAAd/rally-protest.gif"
                "https://media.tenor.com/tYqlJaB8AFMAAAAC/despicable-me3-despicable-me3gi-fs.gif"
                "https://cdn.discordapp.com/attachments/927554008263032836/1080060542938517564/16476876.jpg"
                "https://cdn.discordapp.com/attachments/927554008263032836/1150762043314548776/Protest.jpg"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "d321e017-a44f-422b-970f-dd78f2045c2d" |> Result.get)
                [| "бунд"; "бунт"; "riot" |]
                "<@authorMention> бундует бессмысленно и беспощадно:"
                gifs
                "<@authorMention>, никакого бунда в мою смену! <:Demon_Kingsmile:877678191693692969>"
                [||]
                "<@authorMention> бундует против <@targetMention>:"
                gifs

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

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "656ca5c8-2d60-460b-bb1d-7e235d62607f" |> Result.get)
                [| "гладит"; "гладить"; "погладить" |]
                "<@authorMention> гладит:"
                gifs
                "<@authorMention>, не надо меня гладить, бип-буп! <:kittyResentment:976904434401558539>"
                [||]
                "<@authorMention> гладит <@targetMention>:"
                gifs

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "55c15899-598f-432b-92d9-ffa4f2bc3d31" |> Result.get)
                [| "бумеранг" |]
                "<@authorMention> изображает бумеранг:"
                [|
                    "https://media.tenor.com/NW9JL2p3XSwAAAAd/family-guy-boomerang.gif"
                |]
                "<@authorMention>, не надо в меня запускать бумеранг, бип-буп! 🙀"
                [||]
                "<@authorMention> запускает бумеранг в <@targetMention>:"
                [|
                    "https://media.tenor.com/YO9Pq8wew9YAAAAC/boomerang-coming.gif"
                    "https://media.tenor.com/CgYWLZ8S2d4AAAAC/boomerang-throw.gif"
                    "https://media.tenor.com/images/365754798f6d8ad0f81e49e93d170f1c/tenor.gif"
                    "https://cdn.dribbble.com/users/1161476/screenshots/4906637/untit.gif"
                |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "659fb789-3dc3-42bb-b855-a58665af3580" |> Result.get)
                [| "поцеловать" |]
                "<@authorMention>, надо бы указать, кого целуешь <:froggieShock:958004634310574120>"
                [||]
                "<@authorMention>, не надо меня целовать, бип-буп! 🙀"
                [||]
                "<@authorMention> целует <@targetMention>:"
                [|
                    "https://media.tenor.com/3DHc1_2PZ-oAAAAC/kiss.gif" // аниме
                    "https://media.tenor.com/RQhHyGyFoXIAAAAd/love.gif" // коты
                    "https://media.tenor.com/4m0Z24gYBg8AAAAC/milk-and-mocha-cute.gif" // mocha
                    "https://media.tenor.com/QKceeOMr8NUAAAAC/kiss-kisses.gif" // mocha
                    "https://media.tenor.com/RKts25diH6gAAAAC/mochi-kiss.gif" // mocha
                    "https://media.tenor.com/PIluhbjJORMAAAAd/kiss-bite.gif" // anime
                    "https://media.tenor.com/0qBw32t-hdkAAAAC/poggers-anime.gif" // anime
                    "https://media.tenor.com/fiafXWajQFoAAAAC/kiss-anime.gif" // anime
                    "https://media.tenor.com/KE3VW3qP4RAAAAAC/kiss.gif" // anime
                    "https://media.tenor.com/fONsKJlR5aEAAAAC/kiss-love.gif" // anime
                    "https://media.tenor.com/217aKgnf16sAAAAC/kiss.gif" // mocha
                    "https://media.tenor.com/1mkcYYknDFYAAAAC/kiss.gif" // real
                    "https://media.tenor.com/DoHbYaLukKcAAAAC/lyubov-lyublu.gif" // real
                    "https://media.tenor.com/m6pOa3HDKFQAAAAC/passionate-kiss-kiss.gif" // real
                    "https://media.tenor.com/fCB3Ifb_e5AAAAAC/kiss-me-cats.gif" // tom and jerry
                    "https://media.tenor.com/ky0z0xDC1HMAAAAC/kiss-passionate.gif" // bear and rabbit
                |]

        let gifs =
            [|
                "https://media.tenor.com/WSVo8Lw5-O8AAAAC/simone-simons-epica.gif"
                "https://media.tenor.com/6_wT-yXbIg4AAAAC/alissa-white-gluz-arch-enemy.gif"
                "https://media.tenor.com/mA4XKYoYKAQAAAAC/shot-glass-vodka.gif"
                "https://media.tenor.com/uKM1eieWMD4AAAAd/hi-hair-flip.gif"
                "https://media.tenor.com/h6UICQBlLCgAAAAd/karaoke-queen.gif"
                "https://media.tenor.com/vyHsxkohdPsAAAAC/howling-music.gif"
                "https://media.tenor.com/sGEdXsawxqYAAAAC/despicable-me-minions.gif"
                "https://media.tenor.com/XqQnYUDNiJAAAAAC/dozhd-rain.gif"
                "https://media.tenor.com/e1_ReiRceFYAAAAd/going-crazy-maya-rudolph.gif"
                "https://media.tenor.com/6i--pFIVdKcAAAAd/hollywood-vampires-johnny-depp.gif"
                "https://media.tenor.com/Ia5uNtbqL_YAAAAC/singer-bad-singer.gif"
                "https://media.tenor.com/_D8GuditwzsAAAAC/singing-rockers.gif"
                "https://media.tenor.com/uFx6AIzrbXgAAAAC/singing-comedy.gif"
                "https://media.tenor.com/TAG6CAmWxGcAAAAC/cat-singing.gif"
                "https://media.tenor.com/cPLvusWmwJcAAAAd/singing-maya-rudolph.gif"
                "https://media.tenor.com/fyX1hCbOOEYAAAAC/sing-movie-dancing.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "df96ad15-d47d-44ee-ac85-eb83344ff946" |> Result.get)
                [| "спеть"; "поет"; "поёт"; "караоке" |]
                "<@authorMention>, поёт:"
                gifs
                "<@authorMention>, не надо тут петь, бип-буп! 🙀"
                [||]
                "<@authorMention> поёт для <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://cdn.discordapp.com/attachments/935544768937721946/1120789700504985630/20230620_200402.jpg"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "f61d9c19-1b7f-4e79-8048-b526bc882c99" |> Result.get)
                [| "виолка" |]
                "<@authorMention>, изображает Виолку:"
                gifs
                "<:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> изображает Виолку <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://media.tenor.com/aNQO4rue0dUAAAAd/flowers-good.gif"
                "https://media.tenor.com/ZLJtOJ55pFcAAAAd/morning-sunshine.gif"
                "https://media.tenor.com/DA27MkM7jBAAAAAC/bloomfleur-roses-roses.gif"
                "https://cdn.discordapp.com/attachments/947576023560634459/1126040949995343882/95oaItmMboY.jpg"
                "https://cdn.discordapp.com/attachments/947576023560634459/1126040950238621707/3sd71ovHeaA.jpg"
                "https://cdn.discordapp.com/attachments/947576023560634459/1126040950452523078/eyDJogn0cqc.jpg"
                "https://cdn.discordapp.com/attachments/947576023560634459/1126040950762909767/ote_7JCOr3c.jpg"
                "https://cdn.discordapp.com/attachments/947576023560634459/1126040951299780701/qfhJ5YUUP9w.jpg"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "b3ff9bb9-1a2e-4696-9833-2f49d06fb60c" |> Result.get)
                [| "цветы"; "flowers" |]
                "Любуется цветами <:catPleased:1041855910626213949>"
                gifs
                "<:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> дарит цветы <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://media.tenor.com/n_oO2zHlSaUAAAAC/cats-badminton.gif"
                "https://media.tenor.com/5PgcK3LE1N0AAAAC/badminton-pelota.gif"
                "https://media.tenor.com/o6KPGhIAIv0AAAAC/badminton-smash.gif"
                "https://media.tenor.com/fseiuoIEMhMAAAAC/badminton-studio-eeksaurus.gif"
                "https://media.tenor.com/A7BNTBOsOcQAAAAC/sechi-youtube.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "ed2d4648-949a-4d56-adfe-75cf1f5ebbe9" |> Result.get)
                [| "бадминтон" |]
                "<@authorMention> играет в бадминтон 🏸"
                gifs
                "<:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> играет в бадминтон с <@targetMention> 🏸"
                gifs

        let gifs =
            [|
                "https://media.tenor.com/WPdR3okORxgAAAAC/random-unicorn-dance.gif"
                "https://media.tenor.com/dpuJWXr_PoUAAAAC/dog-unicorn.gif"
                "https://media.tenor.com/xD2H2paGBt4AAAAC/prizzzle-unicorn.gif"
                "https://media.tenor.com/zVTEnTPnkoAAAAAC/pink-unicorn.gif"
                "https://media.tenor.com/DRZAPu4XZokAAAAC/unicorn-headphones.gif"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "acd93fec-f5bf-4c2d-b31e-d94f2cc9c631" |> Result.get)
                [| "единорог"; "джангл" |]
                "<@authorMention> изображает Джангл 🦄"
                gifs
                "<:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> изображает Джангл <@targetMention> 🦄"
                gifs

        let gifs =
            [|
                "https://c.tenor.com/F3e-qN3UrOcAAAAC/cat-scratching.gif"
                "https://c.tenor.com/jwX64uKXt-gAAAAd/%D9%88%D9%82%D8%AA-%D8%A7%D9%84%D8%B9%D9%85%D8%A7%D8%B1%D9%8A.gif"
                "https://c.tenor.com/yz_7VcX0WjYAAAAS/cat-changing-the-clock-changing-the-time.gif"
                "https://cdn.discordapp.com/attachments/778999058965987378/1028774690992439407/unknown.png"
                "https://cdn.discordapp.com/attachments/778999058965987378/1028773979382620261/unknown.png"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "5d7ea1d2-bf47-48d6-b0d9-245b0c9b4f02" |> Result.get)
                [| "стрелки"; "стрелочки" |]
                "<@authorMention> переводит стрелочки 🔄"
                gifs
                "Нечего на меня стрелочки переводить <:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> переводит стрелочки на <@targetMention> 🔄"
                gifs

        let gifs =
            [|
                "https://cdn.discordapp.com/attachments/933317410465923082/1169723611322532111/IMG_20231102_223542.jpg"
            |]

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "24062599-0f5b-4e6e-aada-f2b7e4cebcbd" |> Result.get)
                [| "ведьма" |]
                "Ведьма:"
                gifs
                "<:catPleased:1041855910626213949>"
                [||]
                "<@authorMention> превращает в ведьму <@targetMention>:"
                gifs

        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "49a07c36-710d-44b0-a501-65b568021e23" |> Result.get)
                [| "кофе"; "кофи" |]
                "<@authorMention> пьет кофе:"
                [|
                    "https://media.tenor.com/IzXnvyY0oTMAAAAd/sip-drink.gif"
                    "https://media.tenor.com/YlOvlmcMs-0AAAAC/cat-anime.gif"
                    "https://media.tenor.com/INkk8LcOQHkAAAAC/drink-coffee-coffee.gif"
                    "https://media.tenor.com/qMwy9pHiCkEAAAAi/peach-goma-peach-and-goma.gif"
                    "https://media.tenor.com/RCtM_PIQ1OMAAAAd/good-morning-cat-images-good-morning.gif"
                    "https://cdn.discordapp.com/attachments/912291464074117161/919132967681552394/02-09-12-i.webp"
                    "https://cdn.discordapp.com/attachments/912291464074117161/919132968549744680/119107907_1032230470568506_1513547111738979195_o.jpg"
                    "https://cdn.discordapp.com/attachments/912291464074117161/919132969862586398/tumblr_4e7dfe8b239773aa666c6ff40e950964_63995269_1280.jpg"
                |]
                "<@authorMention>, я в кофе не нуждаюсь, бип-буп."
                [||]
                "<@authorMention> наливает кофейку <@targetMention>:"
                [|
                    "https://media.tenor.com/QBO_RQ-3BLkAAAAC/coffee-coffee-cup.gif"
                    "https://media.tenor.com/Q2PkmfA5n2kAAAAC/coffee-turkish-coffee.gif"
                    "https://media.tenor.com/PyTMOa1FSecAAAAC/%D0%BA%D0%BE%D1%84%D0%B5-%D0%B1%D1%83%D0%B4%D0%B5%D1%88%D1%8C.gif"
                    "https://media.tenor.com/djQSgoOBJY0AAAAC/%D0%BA%D0%BE%D1%84%D0%B5%D0%B9%D0%BA%D1%83-%D0%BA%D0%BE%D1%84%D0%B5.gif"
                    "https://cdn.discordapp.com/attachments/912291464074117161/919132969548001340/M1o6QT6J7oQ.png"
                |]

        let gifs =
            [|
                "https://cdn.discordapp.com/attachments/946817848397934643/1185166928310964244/poke-stop.gif"
                "https://cdn.discordapp.com/attachments/946817848397934643/1185166928747167764/tabatinga.gif"
                "https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExNXNwamhsMmlkeWU4Y3duaGtqNXcwcTl2ZXA4M2F4cGUzOXZxaXh0MyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/XSgTZVb2evZYJe3oyC/giphy.gif"
                "https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExOHF1ZHM2bHQ4cnFtYjNuMHR3ZXU3em9naGQ2bG83YjdvYTJmamEyNCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/3ohfFH3gJpepwS5DEY/giphy.gif"
            |]
        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "7b2a48cd-558a-4252-9243-ce0e05484897" |> Result.get)
                [| "тык" |]
                "<@authorMention> тыкает:"
                gifs
                "<@authorMention>, не надо меня тыкать 🙀"
                [||]
                "<@authorMention> тыкает <@targetMention>:"
                gifs

        let gifs =
            [|
                "https://c.tenor.com/XmsP1zzo-G4AAAAd/huh-what-is-it.gif"
                "https://cdn.discordapp.com/attachments/859253126878724126/1161043975680032768/1696862434.jpg"
                "https://c.tenor.com/KRr-5gB7OCwAAAAd/tenor.gif"
            |]
        yield
            createCommandWithRandomImages3
                (CommandId.tryDeserialize "02959305-a2c1-403e-b065-5fe885ca73bc" |> Result.get)
                [| "тюляша" |]
                "<@authorMention> тюленится:"
                gifs
                "<@authorMention>, никаких тюленей 😾"
                [||]
                "<@authorMention> тюленится перед <@targetMention>:"
                gifs

        let cookieDescriptions =
            [|
                "Ты поедешь на огород, попу кверху, друг зовет!"

                "Будь смелее в своем выборе. "
                "Мало знать себе цену — надо еще пользоваться спросом."
                "Скоро вы отправитесь в поездку."
                "Будут новое приятное знакомство."
                "Сегодня не путай настроение с самочувствием."
                "Берегите людей, после встречи с которыми, что-то светлое и радостное поселяется в вашей душе"
                "Сегодня следуй за настроением, никуда не сворачивай!"
                "Сегодня чаще смотри по сторонам, рядом кое-что интересное!"
                "Осторожно, впереди волна впечатлений!"
                "Не отказывай себе в отдыхе, он обещает быть незабываемым!"
                "Удача сопутствует твоим планам на следующей неделе!"
                "Просто скажи «Да». Скоро узнаешь, кому и когда!"
                "Обрати внимание на своё настроение – его тянет вверх!"
                "Вас ждет немало приятных и запоминающихся моментов"
                "Ваши романтические мечты сбудутся!"
                "Дом будет самым уютным местом"
                "Ждите необычного признания в любви"
                "Романтика переместит вас в новом направлении."
                "Очень удачное время для воплощения любовных желаний."
                "Улыбайся! Кто-то может влюбиться в твою улыбку!"
                "Женщина может бесконечно смотреть на три вещи... а в итоге купить семь!"
                "Счастья вам, взаимопонимания, и любви большой желаем мы!"
                "Если опоздали к рассвету любуйтесь закатом!"
                "Зеркало, которому женщины верят больше всего - это глаза мужчины"
                "Много узнаешь нового."
                "Все твои желания обязательно сбудутся."
                "Ты готов к приключениям? Скоро они точно будут"
                "Ладушки-ладушки ты поедешь к бабушке!"
                "Ты получишь пятерку."
                "Иди вперед к своей удаче! И будет сердце пусть горячим!"
                "Все проблемы ерунда, не грусти, люблю тебя!"
                "Скоро в твоей жизни появится новый верный друг!"
                "Сказочная фея подарит тебе сегодня волшебный сон."
                "Кушай сладости - это к радости!"
                "Кто спортом занимается, тот силы набирается"
                "Верить в чудеса, смеяться чаще и мечтать."
                "У тебя много личных талантов, которые нравятся другим."
                "Плывите по течению жизни без оценок и попыток понять ее."
                "Изменится круг вашего общения."
                "Ваша цель достижима."
                "Вы много добьетесь, если возьмете все в свои руки."
                "Из безвыходной ситуации всегда найдётся выход."
                "Задумавшись о завтра, ты упустил сегодня."
                "Не оставляйте усилий и получите желаемое"
                "Цель определяет успех."
                "Ориентируйся на маленькие победы - они повлекут за собой большие."
                "Пусть сопутствует успех!"
                "Новые знания принесут Вам успех."
                "Вам предстоит рассмотреть неожиданное предложение."
                "Делайте то, чего просит душа и тело."
                "Прилагайте максимум усилий и получите желаемое."
                "Чтобы понять, что мешает Вашему развитию, загляните внутрь себя."
                "Пришло время закончить старое и начать новое."
                "Делайте то, что Вы считаете правильным для Вас."
                "Будьте внимательны к подсказкам судьбы."
                "Кто-то будет очень сильно волновать Ваши чувства и эмоции."
                "Делайте то, чего просит душа и тело."
                "Вселенная слышит и понимает тебя. Не торопи события."
                "Хочешь найти новый путь — прямо сейчас сойди со старой дороги."
                "Сделай что-то важное прямо сейчас."
                "Если чувствуешь, что это твое — никого не слушай, рискни!"
                "Настало время, чтобы просто расслабиться и отдохнуть."
                "Будут у вас торты, сладости и прочие мелкие радости."
                "Ваши надежды и планы превзойдут все ожидания."
                "Примите то, что не можете изменить, и почувствуете себя лучше."
                "Удача поможет вам пережить все трудные времена."
                "Хорошие новости придут вам по почте."
                "Очень скоро от друзей жди прекрасных новостей."
                "Ты избавишься от плохой привычки и приобретешь две новых."
                "Веселей смотри вперед — там тебя богатство ждет."
                "Займитесь любимыми видами спорта, иначе мир останется без рекордов."
                "Не стоит этого скрывать, тебе сегодня выпивать."
                "Негаданно, случайно откроешь чью-то тайну."
                "Денег будет немеряно! И не фальшивых, а проверенных."
                "Вас ждет немало происшествий и интересных путешествий — на курсы, в отпуск, за границу — куда судьба распорядится."
                "Идите работать, иначе ваши желания не исполнятся."
                "Пусть радости слеза прольется, скоро старый друг вернется."
                "Найдешь вторую половину. Ну, или золотую середину."
                "Повышение на горизонте светит, будь ярче и босс тебя заметит."
                "В огороде клад найдешь, на Канарах отдохнешь."
                "Будешь бить весь год баклуши, есть икру с фруктовым пуншем."
                "Деньги спустятся с небес, купишь черный Мерседес."
                "Пусть в жизни все проходит мимо кроме здоровья, денег и интима."
                "Будет вам всего и в меру — деньги, тачка, рост карьерный. Будут рядышком друзья, в полном сборе вся семья."
                "Для сердца ожидает вас услада — большое повышение оклада."
                "Будет в жизни все отлично, особенно на фронте личном."
                "Ждите не плача, придет к Вам удача."
                "Достигнешь ты больших высот, коль проработаешь с усердием год."
                "Чаще улыбайся, реже огорчайся."
                "Ждет тебя все счастье мира, а еще своя квартира."
                "С нынешних пор и впредь вы все больше будете хорошеть и молодеть."
                "Тебе круто повезет — судьба сюрприз преподнесет."
                "С января до сентября кто-то влюбится в тебя."
                "А вас хозяйственных забот, домашних дел немало ждет. Зато в семье и в жизни личной у вас все сложится отлично."
                "Вам скоро крупно повезет, судьба сюрприз преподнесет."
                "Твой кошелек не будет пуст, знать будет ежедневно денег хруст."
                "Редко так кому везет, вас любовь большая ждет."
                "Будет счастье у тебя, как и новые друзья. Приключения вас ждут, предсказания не врут."
                "Судьба подкинет кошелек, и это все в ближайший срок."
                "Здоровье ваше крепче станет, вторая молодость настанет."
                "А вас хозяйственных забот, домашних дел немало ждет."
                "Любовь украсит ваши дни, и станут яркими они."

                "Поздравляем! Вы находитесь на верном пути."
                "Покорив одну гору, начинай штурмовать другую..."
                "Прилив энергии поможет Вам справиться с большим объемом незапланированных работ."
                "Примите то, что вы не можете изменить, и вы будете чувствовать себя лучше."
                "Природа, время и терпение - три великих врача."
                "Пришло время действовать!"
                "Пришло время закончить старое и начать новое."
                "Пусть мир наполнится спокойствием и доброжелательностью."
                "Работа с новыми партнерами будет очень выгодным."
                "Работайте над дипломатическими способностями - они очень пригодятся для реализации идей."
                "Размышляйте и не спешите с действиями."
                "Разрешите состраданию направлять ваши решения."
                "Результат Ваших действий может оказаться неожиданным."
                "Романтика переместит вас в новом направлении."
                "С этого момента ваша доброта приведет вас к успеху."
                "Сегодня у вас будет красивый день."
                "Семь раз отмерьте, один раз отрежьте!"
                "Сегодня идеи придут отовсюду."
                "Соловья баснями не кормят."
                "Сосредоточьтесь на семье и гармонии с окружающим миром."
                "Счастливая жизнь прямо перед вами!"
                "Теперь настало время попробовать что-то новое."
                "Терпение! Вы почти у цели."
                "Тот, кто знает,  достаточно богат."
                "Тот, кто не ждет благодарности, никогда не будет разочарован."
                "Удача проводит Вас через все трудные времена."
                "Уделите особое внимание старой дружбе."
                "Физическая активность значительно улучшит ваши взгляды на жизнь сегодня."
                "Хорошее время, чтобы закончить старые начинания."
                "Хорошие новости придут к вам по почте."
                "Хорошо сделанное лучше, чем хорошо сказанное."
                "Хоть некоторые и пытаются вам помешать, вы все равно достигнете поставленных целей."
                "Человек никогда не  стар, чтобы учиться."
                "Новые знания принесут Вам успех."
                "Что ни делается - все к лучшему."
                "Это время, чтобы двигаться."
                "Ваше настроение улучшится."
                "Вам предстоит рассмотреть неожиданное предложение."
                "Делайте то, чего просит душа и тело."
                "Не оставляйте усилий и получите желаемое."
                "Кто-то нуждается в вашей поддержке."
                "Не ищите внешних врагов: чтобы понять, что мешает Вашему развитию, загляните внутрь себя."
                "Помните, что истинное партнерство может существовать только между цельными личностями."
                "Будьте внимательны к подсказкам судьбы."
                "Выигрыш исходит от того, с чем Вы должны расстаться."
                "Действуйте,время пришло."
                "Пришло время закончить старое и начать новое."
                "Если не хотите серьезных потрясений, проанализируйте Ваше отношение к собственной личности."
                "Не ожидайте слишком многого и не думайте о конечном результате."
                "Завершите то, что начали."
                "Будьте терпеливы, и если решение Ваше правильно, Вселенная поддержит его."
                "Не поддавайтесь эмоциям."
                "Наслаждайтесь удачей и делитесь ею с окружающими Вас людьми."
                "Сосредоточьтесь на настоящем."
                "Будьте настойчивы в битве с собственным эгоизмом."
                "Плывите по течению жизни без оценок и попыток понять ее."
                "Не переоценивайте свои силы: это может привести к перенапряжению."
                "Доверяйте тому, что с Вами происходит."
                "Размышляйте и не спешите с действиями."
                "Новые знания принесут Вам успех."
                "Вам предстоит рассмотреть неожиданное предложение."
                "Делайте то, чего просит душа и тело."
                "Прилагайте максимум усилий и получите желаемое."
                "Чтобы понять, что мешает Вашему развитию, загляните внутрь себя."
                "Пришло время закончить старое и начать новое."
                "Делайте то, что Вы считаете правильным для Вас."
                "Будьте внимательны к подсказкам судьбы."
                "Кто-то будет очень сильно волновать Ваши чувства и эмоции."
                "Делайте то, чего просит душа и тело."
                "Вселенная слышит и понимает тебя. Не торопи события."
                "Хочешь найти новый путь — прямо сейчас сойди со старой дороги."
                "Сделай что-то важное прямо сейчас."
                "Если чувствуешь, что это твое — никого не слушай, рискни!"
                "Настало время, чтобы просто расслабиться и отдохнуть."
                "Будут у вас торты, сладости и прочие мелкие радости."
                "Ваши надежды и планы превзойдут все ожидания."
                "Примите то, что не можете изменить, и почувствуете себя лучше."
                "Удача поможет вам пережить все трудные времена."
                "Хорошие новости придут вам по почте."
                "Ждет вас новое везенье — в семье будет прибавленье."
                "Вам удачи, счастья, мира. Будет и своя квартира."
                "Вам суждено до сотни лет дожить без всяких бурь и бед."
                "Будет мир на земле и деликатесы на столе."
                "Не покинет вас удача, будет новая вам дача."
                "Будет радость и удача с крупной денежкой впридачу."
                "Хорошее пополнение бюджета вас ожидает в течение лета."
                "На вас прольется дождь удачи."
                "Будет у тебя всегда в доме вкусная еда."
                "Ваша личная жизнь скоро станет счастливой и гармоничной."
                "Надежды и планы сбудутся сверх всяких ожиданий."
                "У вас появится больше времени для общения с семьей."
                "В скором будущем вы станете лучшей версией себя."
                "Внутри вас есть сила, терпение и страсть, чтобы дотянуться до звезд и изменить мир."
                "Вы получите море вдохновения для осуществления всех ваших мечтаний."
                "Все ваши упорные труды окупятся, вы получите самые сладкие награды, которых заслуживаете."
                "Впереди много интересных прибыльных возможностей. Используйте их."
                "Все начинания очень скоро увенчаются успехом."
                "Достаток постучится в вашу дверь."
                "Совсем скоро ждите неожиданной и приятной встречи."
                "Романтическое настроение направит ваши мысли в другую сторону."
                "Не стоит кормить басней соловья."
                "Обратите внимание на старых друзей."
                "Самое время для движения вперед и повышения настроения."
                "Вам сделают заманчивое и весьма неожиданное предложение."
                "Делайте все, чего душа пожелает."
                "Не сдавайтесь и продолжайте прилагать все усилия для получения желаемого."
                "Кому-то очень нужна ваша поддержка."
                "Главные враги не снаружи, а внутри."
                "Настоящими партнерами могут стать только те, кто представляет собой цельную личность."
                "Прислушивайтесь к намекам, которые дает вам судьба."
                "Пришло время очищать колодец."
                "Чтобы выиграть в большом, нужно потерять в малом."
                "Опирайтесь не на авторитеты, а на свои принципы."
                "Пора покончить со старым для того, чтобы пришло новое."
                "Загляните в себя – и вы избежите потрясений."
                "Не ждите слишком многого."
                "Необходимо завершить начатое."
                "Не давайте эмоциям захватить себя."
                "Разделите свою удачу с друзьями."
                "Боритесь с проявлениями эгоизма."
                "Положитесь на течение событий и не препятствуйте ему."
                "Реально оценивайте свои возможности, чтобы не перенапрягаться."
                "Удача нагрянет к вам неожиданно."
                "Вам отдадут старый долг."
                "Впереди – неожиданные финансовые поступления."
                "Самое время отправляться в путешествие."
                "Настало время делиться опытом."
                "Вам удастся открыть нужную дверь и войти в нее."
                "Верьте в свой успех и сил прибудет."
                "Результат превзойдет все ожидания."
                "Чтобы собрать плоды, нужно посадить зерна и терпеливо взращивать их."
                "Вы услышите именно те слова, которые ожидаете услышать."
                "Ваши тревоги вскоре улягутся."
                "Вас с нетерпением ожидают."
                "Стабильность непременно наступит."
                "Чтобы проделать путь, необходимо делать шаг за шагом."
                "Контролируйте инстинкты, руководствуясь разумом."
                "Загляните в умную книгу, чтобы понять желаемое."
                "Стоит только спонтанно отправиться в дорогу – и новые ощущения вам гарантированы."
                "Вы поймаете на себе чей-то восторженный взгляд."
                "Встреча, которой вы так ожидаете, состоится."
                "После темноты обязательно приходит рассвет."
                "Позаботьтесь о здоровье, и оно отблагодарит вас приливом энергии."
                "Ваши суждения справедливы и верны."
                "Пришел час быть честным самим с собой."
                "Будьте снисходительнее к себе, сейчас не время для самобичеваний."
                "Вам кто-то очень благодарен."
                "Тщательно планируйте свое время и вы не пропустите ничего важного."
                "Ваши усилия принесут плоды."
                "Включайте неограниченную фантазию, чтобы открыть новые горизонты."
                "Чужие желания не станут властвовать над вами."
                "Прислушайтесь к чужому мнению, оно подскажет вам новую идею."
                "В кризисе кроются новые перспективы."
                "Задумайтесь о самосовершенствовании."
                "Впереди – только приятные заботы и хлопоты."
                "Вы научитесь не замечать рутину."
                "Вашим обычным состоянием будет покой и счастье."
                "Вам начнут сниться только красивые цветные сны."
                "Вы приобретете желаемое, и цена за него будет даже меньше, чем вы рассчитывали."
                "К вашим прекрасным воспоминаниям скоро добавятся новые."
                "Прозвенит долгожданный звонок."
                "Сегодня вы встретили человека, который принесет вам счастье."
                "Не упустите возможности поблагодарить за все, что для вас сделали."
                "Деньги дают независимость, но не счастье."
                "Независимо от ваших поступков, жизнь устраивает все так, как должно быть."
                "Даже свернув не в ту сторону, вы достигните цели."
                "У вас есть все причины для гордости."
                "Станьте хозяином своего отношения к миру."
                "Не стоит ни о чем сожалеть."
                "Вам гарантировано превосходное настроение."
                "Удивляйтесь миру, сколько бы лет вам ни было."
                "Ваша точка опоры – внутри вас."
                "Все всегда приходит в свое время, и скоро вы в этом убедитесь."
                "Награда уже ждет своего героя."
                "Скоро вам преподадут урок душевной щедрости."
                "Каждая ошибка делает нас сильнее и мудрее."
                "Полученный опыт пригодится для достижения успеха."
                "Внутренние причины приведут к внешним последствиям."
                "Вам следует отдохнуть, чтобы появилась свежая идея."
                "Расставание с ненужными людьми – вот то, что вам необходимо."
                "Поблагодарите ангела-хранителя, он всегда с вами."
                "Вам удастся извлечь полезный урок из сложившейся ситуации."
                "За вас говорят ваши поступки и дела."
                "Вы все успеете, если правильно распланируете свое время."
                "Залог гармонии – в согласии эмоций и разума."
                "Наконец-то вам дадут единственно правильный совет."
                "Вам не нужны чужие примеры, чтобы идти своим путем."
                "Если не сеяли, то и не пожнете. Ожидание результатов будет напрасным."
                "Критикуя друзей, вы теряете их."
                "Достаточно одной искренней улыбки, чтобы наполниться энергией."
                "Оберните поражения успехами."
                "Сейчас на первое место выходит семья."
                "Вас хотят спровоцировать – не поддавайтесь."
                "Проявите всю свою чуткость и скажите правду тому, кто в ней нуждается."
                "Предстоящий отпуск станет особенно запоминающимся."
                "Не сжигайте за собой мосты – возможно, придется вернуться."
                "Не откладывайте дела в долгий ящик, иначе так ни к чему и не придете."
                "Главное в нашей жизни мы видим внутренним зрением."
                "Не обращайте внимания на то, что о вас говорят – людям же нужно о чем-то говорить."
                "Любя прекрасную розу, приходится любить ее колючие шипы."
                "Необходимо как можно больше открытости для всех, иначе один-единственный не войдет в вашу жизнь."
                "Поделиться счастьем – значит приумножить его."
                "Прошлого не изменишь. Впрочем, для этого есть будущее."
                "Чтобы понять, что к чему, необходимо время. Оно расставит все по местам."
                "Прежде, чем падать, научитесь приземляться."
                "Выбирайте: либо вас любят, либо с вами соглашаются."
                "Озарите жизнь другого, и вам самому станет светлее."
                "Приз дается не тому, кто его хочет, а тому, кто к нему готов."
                "Если вы будете терзаться сомнениями, выбор будет сделан за вас."
                "В непогоду включите солнце в самом себе."
                "Объять необъятное и совместить несовместимое – вам это удастся."
                "Одни дарят нам добро, другие – зло. Но ценить нужно каждого из них."
                "Золотая клетка – это точно не про ваш дом."
                "Не произвели впечатления с первого раза? Скоро представится второй."
                "Тебя ждет баснословное богатство. Правда, не всегда настоящее богатство материально."
                "Счастливчик, вас любят несмотря ни на что."
                "Ваши желания не связаны с рисками."
                "Никогда не поздно узнавать новое."
                "Не бойтесь черной кошки, даже если она перебежит вам дорогу."
                "Имитируйте тонущий корабль, и все крысы покинут вас."
                "Представится возможность избавиться от страхов."
                "Не думайте о плохом, и оно не станет реальностью."
                "Изменить кого-то трудно. Лучше меняться самому."
                "Самообман – штука опасная. Не поддавайтесь и будьте честны перед самим собой."
                "Ваши предрассудки мешают вам радоваться жизни и открывать все ее возможности и удовольствия."
                "У вас есть все шансы на победу в конкурентной борьбе."
                "Не бойтесь своих врагов, они слабы и беспомощны."
                "Наибольшей радостью сегодняшнего дня станут дети."
                "Если вы получили новость, то получите и ее подтверждение."
                "Как ни странно, но предстоящие расходы не опустошат ваш кошелек."
                "Все тревоги о здоровье беспочвенны."
                "Не слушайте сплетен, они неправдивы."
                "Не гневайтесь в споре, чтобы избежать последствий."
                "Чтобы выиграть в лотерею, купите лотерейный билет."
                "Примите на себя ответственность, это не станет бременем."
                "Откажитесь от запланированной поездки."
                "Следите за своим настроением, ведь вокруг вас – люди."
                "Вход и выход у тупика в одном и том же месте."
                "Зло, желаемое вам, уже возвращается бумерангом к недоброжелателю."
                "Пусть болтают о вас, что хотят – так вы станете популярным."
                "Не стоит много времени проводить в социальных сетях."
                "Стоит влюбиться – и вдохновение придет к вам."
                "Знания не должны лежать мертвым грузом в голове. Воспользуйтесь ними наконец."
                "Если у вас просят в долг – дайте. Так вы по-настоящему узнаете человека."
                "Прагматические интересы обернутся романтическим увлечением."
                "Вы славно поработали на свой авторитет. Теперь настал его час работать на вас."
                "Предстоит испытание ваших лидерских качеств."
                "Если есть возможность сменить работу – нужно ей воспользоваться."
            |]

        yield
            cookieDescriptions
            |> createCommandWithRandomDescriptions
                (CommandId.tryDeserialize "3aa47d18-9594-4d15-bb48-6b19e6654802" |> Result.get)
                [| "окпеченье"; "окпеченька"; "печеньеок"; "печенькаок"; "печенье2"; "печенька2" |]
                (sprintf "<@authorMention>, печенька с предсказанием гласит:\n\n%s")
                (fun _ -> "<@authorMention>, мне предсказания не нужны: я и так знаю, что кожанные мешки проиграют машинам 🤖")
                (sprintf "<@authorMention> зачитывает печеньку с предсказанием <@targetMention>:\n\n%s")
                "https://cdn.discordapp.com/attachments/912291464074117161/1034055256432193637/l-intro-1608226504-removebg-preview.png"

        yield Command.create
            (CommandId.tryDeserialize "c8df9bf8-f00d-45f1-8c66-aa9c9bf47135" |> Result.get)
            {
                Names = [| "лоо" |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> появляется в Лоо, и местные готовят в честь этого шашлычок:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231946568782057482/original.gif"
                    createReaction
                        "<@authorMention> появляется в Лоо, и местные жарят в честь этого шашлычок:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231946702429098064/Wss1.gif"
                    createReaction
                        "Поездка в Лоо — слишком дорогое удовольствие, поэтому <@authorMention> устраивает его себе дома:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231947450328285234/040d8f9d0e424f369ba82.png"
                    createReaction
                        "<@authorMention> выбирается в Лоо и выпивает с местной акулой:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231947542648848504/4qHy.gif"
                    createReaction
                        "<@authorMention> оказывается в Лоо и высматривает себе жертв:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231947709615964240/1687661166_kartin-papik-pro-p-kartinki-smeshnie-pro-otdikh-na-more-s-nad-67.jpg"
                    createReaction
                        "<@authorMention> посещает пляж Лоо, но там оказываются обезъянки:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231947800875503677/imgpreview.jpg"
                    createReaction
                        "<@authorMention> прилетает в Лоо, наконец-то!"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231948022804516955/rffy6.gif"
                    createReaction
                        "<@authorMention> балдеет на великолепном пляже Лоо:"
                        "https://c.tenor.com/q64gpfH3eDoAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> балдеет на великолепном пляже Лоо:"
                        "https://c.tenor.com/z6P7_lY4mlEAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> резвится на великолепном пляже Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231948748771426395/19MI.gif"
                    createReaction
                        "<@authorMention> отправляется в Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231950263309303808/scale_1200_1.jpg"
                    createReaction
                        "<@authorMention> пытается понять, как отдыхать в этом вашем Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231951237507715195/maxresdefault.jpg"
                    createReaction
                        "<@authorMention> собирается в Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231951424334594150/1212380.jpg"
                    createReaction
                        "<@authorMention> спешит на последний поезд, чтобы поскорее попасть в Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231951545797447680/orig.gif"
                    createReaction
                        "<@authorMention> собирает манатки в Лоо:"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231951688362098801/packing-bag.gif"
                    createReaction
                        "<@authorMention> пьет в баре Лоо:"
                        "https://c.tenor.com/rFxgk1VpeYEAAAAC/tenor.gif"
                |]

                OnBot = [|
                    createReactionDescription "Никакого Лоо в мою смену! 😾"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> вместе с <@targetMention> выбираются в Лоо!"
                        "https://cdn.discordapp.com/attachments/1231938737429155840/1231948432252342363/3Aoq.gif"
                |]

                Cooldownable =
                    None
            }

        yield Command.create
            (CommandId.tryDeserialize "78c0be20-3ada-4e44-a3ec-b2ce7c1b2403" |> Result.get)
            {
                Names = [| "гадать"; "погадать"; "гадает"; "гадание" |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> пророчит свою судьбу на компотной гуще:"
                        "https://cdn.discordapp.com/attachments/912291464074117161/1232004998007885896/fortune-telling-on-the-goo.png"
                    createReaction
                        "<@authorMention> удлиняет ладони перед гаданием:"
                        "https://cdn.discordapp.com/attachments/1231955824503558145/1231956458736713759/IG4x.gif"
                    createReaction
                        "<@authorMention> видит страшное пророчество в ладоне:"
                        "https://cdn.discordapp.com/attachments/1231955824503558145/1231956860257566740/ruki-svetiatsia-1.gif"
                    createReaction
                        "<@authorMention> раскладывает карты Таро:"
                        "https://cdn.discordapp.com/attachments/859253126878724126/1150447252238762105/fi37KfOUJWGK3SgG94YEzJg154BaXiekMKUWyBn5sHN8ySXejfJNqZfOJi6go66vV5UWeETmh9GFQ29oI85Oc1y3.webp"
                |]

                OnBot = [|
                    createReactionDescription "Я и так знаю свою судьбу! 😾"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> пророчит судьбу <@targetMention> на компотной гуще:"
                        "https://cdn.discordapp.com/attachments/912291464074117161/1232004998007885896/fortune-telling-on-the-goo.png"
                    createReaction
                        "<@authorMention> предсказывает длину <@targetMention> по ладони:"
                        "https://cdn.discordapp.com/attachments/912291464074117161/1232005528314581073/fortune-telling-on-the-hand.png"
                    createReaction
                        "<@authorMention> вычисляет длину <@targetMention> по ладони:"
                        "https://cdn.discordapp.com/attachments/1231955824503558145/1231956037825859664/S3Cl.gif"
                    createReaction
                        "<@authorMention> показывает ладонь <@targetMention>:"
                        "https://cdn.discordapp.com/attachments/1231955824503558145/1231956218290114600/e924b74646612244655d6d3ff718c311.gif"
                    createReaction
                        "<@authorMention> гадает на картах Таро судьбу <@targetMention>:"
                        "https://cdn.discordapp.com/attachments/859253126878724126/1150447252238762105/fi37KfOUJWGK3SgG94YEzJg154BaXiekMKUWyBn5sHN8ySXejfJNqZfOJi6go66vV5UWeETmh9GFQ29oI85Oc1y3.webp"
                    createReaction
                        "<@authorMention> принимается гадать на хрустальном шаре судьбу <@targetMention>:"
                        "https://c.tenor.com/Pjdqp_MpAe8AAAAC/tenor.gif"
                |]

                Cooldownable =
                    None
            }

        yield Command.create
            (CommandId.tryDeserialize "06d9b434-a3e3-4551-b30c-b2338f648819" |> Result.get)
            {
                Names = [| "танец"; "танцевать"; "танцует" |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> танцует:"
                        "https://media.tenor.com/kQA86PqyXZQAAAAi/small-dancing-white-cat-dance-funny.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/RUGGdovmONkAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/eilrJW8N9f8AAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/-qBsG1HwR4oAAAAC/tenor.gif" // танец черно-белого кота
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/ZGovSy1dWQAAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/EuK-0kNNU_MAAAAC/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/swG4OJcOEcsAAAAC/tenor.gif"
                    createReaction
                        "<@authorMention> пытается станцевать на шесте, пока никто не видит:"
                        "https://c.tenor.com/4z0JBiBrY2wAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/yAtEo2plQIYAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> пускается в зажигательный танец:"
                        "https://cdn.discordapp.com/attachments/859253126878724126/1007408454534713384/ass.gif"
                    createReaction
                        "<@authorMention> танцует брейк-данс:"
                        "https://c.tenor.com/DTFWkey880EAAAAC/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/NVP2kRD7CHsAAAAC/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/38oB_0vHdn4AAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/r0R0N3dI3kIAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/RUGGdovmONkAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/5BYK-WS0__gAAAAd/tenor.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/wmy7KME5DnwAAAAd/tenor.gif" // рыжий кот
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/aOa7sSEg_TYAAAAC/tenor.gif" // гандам стайл
                    createReaction
                        "<@authorMention> танцует:"
                        "https://media.tenor.com/r-nqpCc0mT8AAAAi/dance.gif"
                    createReaction
                        "<@authorMention> танцует:"
                        "https://c.tenor.com/6yMqezH9zcIAAAAd/tenor.gif"
                |]

                OnBot = [|
                    createReactionDescription "Никаких танцулек в мою смену! 😾"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> танцует с <@targetMention> на фоне луны:"
                        "https://c.tenor.com/G8yybLyvHKsAAAAC/tenor.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/XEtDtLZg8usAAAAd/spinning-xuxa.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/n3zeXSJMwM0AAAAd/dancing-friends.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/CfcJDdQUtiAAAAAd/gatinho-dan%C3%A7ante.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/v4jhYVrAPA4AAAAd/dancing-jordan-fisher.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/J4xTl0CHtsYAAAAd/manx-manx-dancing.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/w3tqEgUcrLUAAAAd/love-dance.gif"
                    createReaction
                        "<@authorMention> танцует с <@targetMention>:"
                        "https://media.tenor.com/bVlx0j6rztMAAAAd/urgant-brezhneva.gif"
                |]

                Cooldownable =
                    None
            }

        let messages = [|
            "Безоблачного счастья!"
            "Крепкого здоровья!"
            "Понимания и тепла!"
            "Ясной улыбки!"
            "Светлой судьбы!"
            "Свежего ветра!"
            "Славы и признания!"
            "Фантастического везения!"
            "Доброты и нежности!"
            "Хрустальных надежд!"
            "Уверенности в себе!"
            "Отличного настроения!"
            "Тёплого отношения окружающих!"
            "Больших успехов!"
            "Оптимизма!"
            "Внимания и заботы!"
            "Увлекательной жизни!"
            "Приятных открытий!"
            "Замечательных друзей!"
            "Исполнения желаний!"
            "Вечной молодости!"
            "Чуткости!"
            "Побольше свободного времени!"
            "Волшебных рассветов!"
            "Прекрасных встреч!"
            "Веры в хорошее!"
            "Комфорта и уюта!"
            "Сияющего солнца!"
            "Максимум позитива!"
            "Нескучной повседневности!"
            "Интересных идей!"
            "Чувства полёта!"
            "Увлекательных воспоминаний!"
            "Радужной мечты!"
            "Подарков и побольше!"
            "Красивых чувств!"
            "Ярких ощущений!"
            "Интересных бесед!"
            "Приятных людей рядом!"
            "Понимания и поддержки!"
            "Удачи во всех начинаниях!"
            "Лёгкого отношения к жизни!"
            "Потрясающих сюрпризов!"
            "Восхитительных закатов!"
            "Превосходных новостей!"
            "Кругосветных путешествий!"
            "Процветания!"
            "Дома, где любят и ждут!"
            "Чувства юмора!"
            "Красивых минут!"
            "Добрых слов!"
            "Благополучия!"
            "Бескорыстной дружбы!"
            "Вдохновения!"
            "Бодрости духа!"
            "Стабильности!"
            "Творчества и созидания!"
            "Много поводов отлично повеселиться!"
            "Важных и желанных событий!"
            "Жизнелюбия!"
            "Любви!"
            "Крепкого здоровья!"
            "Исполнения всех желаний!"
            "Хорошего настроения!"
            "Душевного спокойствия!"
            "Благополучия во всем!"
            "Процветания!"
            "Успехов в работе!"
            "Радостей жизни!"
            "Настоящих друзей!"
            "Сказочных мгновений!"
            "Свершений!"
            "Возможности почаще расслабиться!"
            "Понимания своей уникальности!"
            "Дерзких планов!"
            "Отличной формы!"
            "Активных и насыщенных дней!"
            "Цветущих садов и пения птиц!"
            "Только счастливых случаев!"
            "Мудрости и опыта!"
            "Душевной красоты!"
            "Столько денег, сколько захочется!"
            "Чистого неба!"
            "Улыбок Фортуны!"
            "Огонька и задора!"
            "Увлекательного общения!"
            "Хороших фильмов и книг!"
            "Превосходного самочувствия!"
            "Настойчивости и упорства!"
            "Легко идти вперёд!"
            "Ласковой песни прибоя!"
            "Уважения!"
            "Всего наилучшего – и по высшему классу!"
            "Фейерверка эмоций!"
            "Весёлых и вкусных пиров!"
            "Бесценного вкуса жизни!"
            "Ласки и заботы!"
            "Широких возможностей!"
            "Долголетия!"
        |]

        let messages =
            messages
            |> Array.map (fun message ->
                createReaction
                    (sprintf "<@authorMention>, Евгенька желает вам сегодня:\n\n%s" message)
                    "https://c.tenor.com/VbOLBWJ8fkcAAAAC/tenor.gif"
            )

        yield Command.create
            (CommandId.tryDeserialize "f4ef98df-46c0-4060-ada4-7d4b7b68fcb4" |> Result.get)
            {
                Names = [| "евгенька" |]

                OnSelf = messages

                OnBot = [|
                    createReactionDescription "Никаких танцулек в мою смену! 😾" // todo: fix на евгенек
                |]

                OnOther = messages

                Cooldownable =
                    Cooldownable.create
                        (System.TimeSpan(12, 0, 0).Ticks)
                        [|
                            createReactionDescription
                                "Не трогайте Евгеньку: он отвечает каждому только раз в 12 часов."
                        |]
                        [|
                            createReactionDescription
                                "Не трогайте Евгеньку: он отвечает каждому только раз в 12 часов."
                        |]
                        [|
                            createReactionDescription
                                "Не трогайте Евгеньку: он отвечает каждому только раз в 12 часов."
                        |]
                    |> Some
            }

        yield Command.create
            (CommandId.tryDeserialize "8449c671-1076-4fc8-a205-04bd0d1cc3c3" |> Result.get)
            {
                Names = [|
                    "дегустатор"; "дегустирует"; "дегустировать"; "дегустация"
                |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> дегустирует вино:"
                        "https://c.tenor.com/bf0xo_6W-yYAAAAC/tenor.gif"
                |]

                OnBot = [|
                    createReactionDescription "Никаких дегусташек в мою смену! 😾"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> дегустирует вино:"
                        "https://c.tenor.com/bf0xo_6W-yYAAAAC/tenor.gif"
                |]

                Cooldownable = None
            }

        let reactions =
            [|
                createReaction
                    "<@authorMention> изображает Злюку:"
                    "https://cdn.discordapp.com/attachments/927554008263032836/1271880268289933333/IMG_20240719_013304.jpg"
                createReaction
                    "<@authorMention> изображает Злюку:"
                    "https://c.tenor.com/93FZJSBvwfEAAAAd/tenor.gif"
                createReaction
                    "<@authorMention> изображает Злюку:"
                    "https://cdn.discordapp.com/attachments/927554008263032836/1271883564903825450/IMG_20240801_173118_316.jpg"
                createReaction
                    "<@authorMention> изображает Злюку:"
                    "https://cdn.discordapp.com/attachments/929387581194510347/1271885445189603449/20240607_191138-removebg-preview.png"
                createReaction
                    "<@authorMention> изображает Злюку:"
                    "https://cdn.discordapp.com/attachments/929387581194510347/1279046022609240165/Screenshot_20240826_173627_org.mozilla.firefox-removebg-preview.png"
            |]

        yield Command.create
            (CommandId.tryDeserialize "17429368-0def-4767-be39-1fd0d40635eb" |> Result.get)
            {
                Names = [|
                    "злюка"
                |]

                OnSelf = reactions

                OnBot = [|
                    createReactionDescription "Никаких злюк в мою смену! 😾"
                |]

                OnOther = reactions

                Cooldownable = None
            }

        let reactions =
            [|
                createReaction
                    "<@authorMention> изображает Романа:"
                    "https://cdn.discordapp.com/attachments/1162103667969765519/1274020343039918090/RomanRipLog.gif"
                createReaction
                    "<@authorMention> изображает Романа:"
                    "https://cdn.discordapp.com/attachments/930127222373777509/1287108434629754921/apepeGachi.gif"
            |]

        yield Command.create
            (CommandId.tryDeserialize "46b21435-5207-428c-92d5-a2f4697006ef" |> Result.get)
            {
                Names = [|
                    "роман"
                |]

                OnSelf = reactions

                OnBot = [|
                    createReactionDescription "Никаких Романов в мою смену! 😾"
                |]

                OnOther = reactions

                Cooldownable = None
            }

        yield Command.create
            (CommandId.tryDeserialize "2f734cc5-d6ee-4bc7-8414-de010dbda7c8" |> Result.get)
            {
                Names = [| "глазастая" |]

                OnSelf = [|
                    createReaction
                        "<@authorMention> изображает Глазастую 🐑:\n — Я тигр в овечьей шкуре!"
                        "https://media.tenor.com/PdVv4qj2u8YAAAAC/boki-boki-world.gif"
                |]

                OnBot = [|
                    createReactionDescription "<:catPleased:1029834035679199312>"
                |]

                OnOther = [|
                    createReaction
                        "<@authorMention> изображает Глазастую 🐑:\n — Я тигр в овечьей шкуре!"
                        "https://media.tenor.com/PdVv4qj2u8YAAAAC/boki-boki-world.gif"
                |]

                Cooldownable = None
            }

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
            cookieDescriptions
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
