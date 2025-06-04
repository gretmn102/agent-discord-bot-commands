module AgentDiscordBot.Commands.Commands.Lunaris
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
    let gifs =
        [|
            "https://cdn.discordapp.com/attachments/912291464074117161/1079991686194810980/da338988c1bf205da96846aac3adf34c.png"
            "https://cdn.discordapp.com/attachments/912291464074117161/1079993526336618496/cute_chibi_riding_a_dragon_by_kianoromitria-d8p86nr.png"
        |]
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "1cddb54b-bb69-468a-a46a-426e41b88908" |> Result.get)
        [| "луня" |]
        "— Я — зло!!! — кричит <@authorMention> и изображает Луню."
        gifs
        "<@authorMention>, никакого зла в мою смену! <:Demon_Kingsmile:877678191693692969>"
        [||]
        "— Я — зло!!! — кричит <@authorMention> и изображает Луню."
        gifs
