module AgentDiscordBot.Commands.Commands.Riot
open FsharpMyExtension.ResultExt
open CustomCommand.Model

open AgentDiscordBot.Commands.Utils

let command =
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
    createCommandWithRandomImages3
        (CommandId.tryDeserialize "d321e017-a44f-422b-970f-dd78f2045c2d" |> Result.get)
        [| "бунд"; "бунт"; "riot" |]
        "<@authorMention> бундует бессмысленно и беспощадно:"
        gifs
        "<@authorMention>, никакого бунда в мою смену! <:Demon_Kingsmile:877678191693692969>"
        [||]
        "<@authorMention> бундует против <@targetMention>:"
        gifs
