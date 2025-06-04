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
