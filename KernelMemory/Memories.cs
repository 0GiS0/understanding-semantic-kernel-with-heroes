using System.ComponentModel;
using System.Text.Json;
using Microsoft.KernelMemory;

public class MemoryKernel
{
    static MemoryServerless memory;

    public static void Init(string openApiKey)
    {

        KernelMemoryBuilder kernelMemoryBuilder;

        kernelMemoryBuilder = new KernelMemoryBuilder()
                     .WithOpenAIDefaults(openApiKey);

        memory = kernelMemoryBuilder.BuildServerlessClient();

        LoadTextMemories();
        LoadDocs();
    }

    static async void LoadTextMemories()
    {
        await memory.ImportTextAsync("El súper héroe favorito de Gisela es Batman", documentId: "gis01", tags: new TagCollection { { "type", "people" } });
        await memory.ImportTextAsync("La última película que Gisela vio de súper héroes fue Guardianes de la Galaxia Vol. 3 ", documentId: "gis02", tags: new TagCollection { { "type", "people" } });
        await memory.ImportTextAsync("El súper héroe favorito de Bruno es Invencible", documentId: "bru01", tags: new TagCollection { { "type", "people" } });
        await memory.ImportTextAsync("La última película que Bruno vio de súper héroes fue Batman de Tim Burton ", documentId: "bru02", tags: new TagCollection { { "type", "people" } });
    }

    static async void LoadDocs()
    {
        await memory.ImportDocumentAsync("docs/Norma editorial - Septiembre 2020.pdf", documentId: "doc001", tags: new TagCollection { { "type", "document" } });
    }

    [SKFunction, Description("Sobre el volumen")]
    public static async Task<string> AboutTheDocuments(string ask)
    {
        var answer = await memory.AskAsync(ask, filter: new MemoryFilter().ByTag("type", "document"));

        // Answer
        Console.WriteLine($"\nAnswer: {answer.Result}");

        // Sources
        foreach (var x in answer.RelevantSources)
        {
            Console.WriteLine($"  - {x.SourceName}  - {x.Link} [{x.Partitions.First().LastUpdate:D}]");
        }

        // return a json string with the answer and the sources
        return JsonSerializer.Serialize(new { answer = answer.Result, references = answer.RelevantSources.Select(x => x.SourceName) });
    }

    [SKFunction, Description("Responde preguntas sobre Bruno y Gisela")]
    public static async Task<string> AboutMe(string ask)
    {
        var answer = await memory.AskAsync(ask, filter: new MemoryFilter().ByTag("type", "people"));

        // Answer
        Console.WriteLine($"\nAnswer: {answer.Result}");

        // Sources
        foreach (var x in answer.RelevantSources)
        {
            Console.WriteLine($"  - {x.SourceName}  - {x.Link} [{x.Partitions.First().LastUpdate:D}]");
        }

        // return a json string with the answer and the sources
        return JsonSerializer.Serialize(new { answer = answer.Result, references = answer.RelevantSources.Select(x => x.SourceName) });

    }
}