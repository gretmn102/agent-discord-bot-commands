module AgentDiscordBot.Commands.Commands.Loo
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    Command.create
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
