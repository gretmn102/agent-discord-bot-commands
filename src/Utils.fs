module AgentDiscordBot.Commands.Utils
open CustomCommand.Model

let genId () =
    System.Guid.NewGuid() |> sprintf "(CommandId.tryDeserialize \"%A\" |> Result.get)" |> Clipboard.setText

let createReaction description imageUrl =
    Reaction.create
        1
        {
            Content = None
            Embed =
                {
                    Description = Some description
                    ImageUrl = Some imageUrl
                }
        }

let createReactionDescription description =
    Reaction.create
        1
        {
            Content = None
            Embed =
                {
                    Description = Some description
                    ImageUrl = None
                }
        }

let createCommandWithRandomImages3 id names onSelfDescription onSelfImgs onBotDescription onBotImgs onOtherDescription onOtherImgs =
    let create description images =
        if Array.isEmpty images then
            [|
                createReactionDescription description
            |]
        else
            images
            |> Array.map (fun imageUrl ->
                createReaction description imageUrl
            )

    Command.create
        id
        {
            Names = names
            OnSelf =
                create onSelfDescription onSelfImgs

            OnBot =
                create onBotDescription onBotImgs

            OnOther =
                create onOtherDescription onOtherImgs

            Cooldownable =
                None
        }

let createCommandWithRandomImages2 id names onSelfDescription isOnSelfImg onBotDescription isOnBotImg onTargetDescription isOnTargetImg imageUrls =
    Command.create
        id
        {
            Names = names
            OnSelf =
                imageUrls
                |> Array.map (fun imageUrl ->
                    Reaction.create
                        1
                        {
                            Content = None
                            Embed =
                                {
                                    Description = Some onSelfDescription
                                    ImageUrl = if isOnSelfImg then Some imageUrl else None
                                }
                        }
                )
            OnBot =
                imageUrls
                |> Array.map (fun imageUrl ->
                    Reaction.create
                        1
                        {
                            Content = None
                            Embed =
                                {
                                    Description = Some onBotDescription
                                    ImageUrl = if isOnBotImg then Some imageUrl else None
                                }
                        }
                )
            OnOther =
                imageUrls
                |> Array.map (fun imageUrl ->
                    Reaction.create
                        1
                        {
                            Content = None
                            Embed =
                                {
                                    Description = Some onTargetDescription
                                    ImageUrl = if isOnTargetImg then Some imageUrl else None
                                }
                        }
                )

            Cooldownable =
                None
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
            OnSelf =
                descriptions
                |> Array.map (fun description ->
                    Reaction.create
                        1
                        {
                            Content = None
                            Embed =
                                {
                                    Description = Some (onSelfDescription description)
                                    ImageUrl = Some imageUrl
                                }
                        }
                )
            OnBot =
                descriptions
                |> Array.map (fun description ->
                    createReactionDescription (
                        onBotDescription description
                    )
                )
            OnOther =
                descriptions
                |> Array.map (fun description ->
                    Reaction.create
                        1
                        {
                            Content = None
                            Embed =
                                {
                                    Description = Some (onTargetDescription description)
                                    ImageUrl = Some imageUrl
                                }
                        }
                )
            Cooldownable = None
        }
