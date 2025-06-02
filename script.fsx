type Source = {
    moduleName: string
    fileName: string
    content: string
}

module Source =
    let template moduleName content =
        [
            sprintf "module AgentDiscordBot.Commands.Commands.%s" moduleName
            "open FsharpMyExtension.ResultExt"
            "open CustomCommand.Model"
            ""
            "open AgentDiscordBot.Commands.Utils"
            ""
            "let command ="
            content
        ] |> String.concat "\n"

    let create moduleName fileName content : Source = {
        content = content
        moduleName = moduleName
        fileName = fileName
    }

    let write isDry path (source: Source) =
        let content = template source.moduleName source.content
        printfn "Write %s with content:\n%s" path content
        if not isDry then
            System.IO.File.WriteAllText(path, content)

type FsProjApi = System.Xml.XmlDocument

module FsProjApi =
    let read (path: string) =
        let d = System.Xml.XmlDocument()
        d.Load(path)
        d

    let addSource sourcePath (proj: FsProjApi) =
        let xpath = "/Project/ItemGroup[2]"
        let itemsGroup = proj.SelectSingleNode(xpath)
        if isNull itemsGroup then failwithf "not found %s" xpath

        // let xpath = "./Compile[@Include='Program.fs']"
        // let programSourceNode = proj.SelectSingleNode(xpath)
        // if isNull itemsGroup then failwithf "not found %s" xpath

        let sourceNode = proj.CreateElement("Compile")
        sourceNode.SetAttribute("Include", sourcePath)

        ignore <| itemsGroup.InsertBefore(sourceNode, itemsGroup.LastChild)

    [<RequireQualifiedAccessAttribute>]
    type PathOrStream =
        | Path of string
        | Stream of System.IO.Stream

    let write isDry (path: string) (proj: FsProjApi) =
        let utf8 = System.Text.UTF8Encoding.UTF8
        let write (pathOrStream: PathOrStream) =
            use writer =
                match pathOrStream with
                | PathOrStream.Stream stream ->
                    new System.Xml.XmlTextWriter(stream, utf8)
                | PathOrStream.Path path ->
                    new System.Xml.XmlTextWriter(path, utf8)
            writer.Formatting <- System.Xml.Formatting.Indented
            proj.WriteTo writer
        do
            use memoryStream = new System.IO.MemoryStream()
            write (PathOrStream.Stream memoryStream)
            let content = utf8.GetString(memoryStream.ToArray())
            printfn "Write %s with content:\n%s" path content
        if not <| isDry then
            write (PathOrStream.Path path)

let f isDry moduleName content =
    let root = "src"
    let fileName = sprintf "%s.fs" moduleName
    let projPath = System.IO.Path.Combine(root, "AgentDiscordBotCommands.fsproj")

    let source = Source.create moduleName fileName content
    let relativeSourcePath = System.IO.Path.Combine("commands", source.fileName)
    let path = System.IO.Path.Combine(root, relativeSourcePath)
    Source.write isDry path source

    let fsProj = FsProjApi.read projPath
    FsProjApi.addSource relativeSourcePath fsProj
    FsProjApi.write isDry projPath fsProj

do
    let content =
        [
            "    [|"
            "        \"https://c.tenor.com/_SHZ8ZyLYL8AAAAC/flirty-flirt.gif\""
            "        \"https://c.tenor.com/bNSOiEO_0loAAAAd/cat-tail.gif\""
            "        \"https://c.tenor.com/TnXmJgMoU5IAAAAC/cat-tail.gif\""
            "        \"https://c.tenor.com/kWJaRBz4jzYAAAAC/elephant-omg.gif\""
            "        \"https://media.tenor.com/NaaUB2i0EjsAAAAd/cat-lazy.gif\""
            "    |]"
            "    |> createCommandWithRandomImages"
            "        (CommandId.tryDeserialize \"177afdd0-c24c-4b16-bc17-c8ff9dcf1c9a\" |> Result.get)"
            "        [| \"хвост\"; \"махатьХвостом\"; \"tail\" |]"
            "        \"Нельзя себе хвостом махать, хотя...\""
            "        \"Мне не нужно хвостом махать! :scream_cat:\""
            "        \"<@targetMention>, <@authorMention> машет тебе хвостом.\""
        ] |> String.concat "\n"
    f false "Tail" content
