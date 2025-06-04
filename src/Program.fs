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
