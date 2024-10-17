using Azure;
using Azure.AI.Inference;
using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Extensions.AI;
using OpenAI;

namespace Util.IA
{
    public class POC
    {
        public async void IAAzure()
        {
            IChatClient client = new ChatCompletionsClient(endpoint: new Uri("https://models.inference.ai.azure.com"),
                new AzureKeyCredential(Environment.GetEnvironmentVariable("GH_TOKEN")))
                .AsChatClient("Phi-3.5-MoE-instruct");

            var response = await client.CompleteAsync("What is AI?");

            Console.WriteLine(response.Message);
        }

        public async void IAAzureOpenAI()
        {
            IChatClient client = new AzureOpenAIClient(new Uri(Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")),
            new DefaultAzureCredential())
            .AsChatClient(modelId: "gpt-4o-mini");

            var response = await client.CompleteAsync("What is AI?");

            Console.WriteLine(response.Message);
        }

        public async void IAOllama()
        {
            IChatClient client = new OllamaChatClient(new Uri("http://localhost:11434/"), "llama3.1");
            var response = await client.CompleteAsync("What is AI?");

            Console.WriteLine(response.Message);
        }

        public async void IAOpenAI()
        {
            IEmbeddingGenerator<string, Embedding<float>> generator = new OpenAIClient(Environment.GetEnvironmentVariable("OPENAI_API_KEY"))
            .AsEmbeddingGenerator(modelId: "text-embedding-3-small");

            var embedding = await generator.GenerateAsync("What is AI?");

            Console.WriteLine(string.Join(", ", embedding[0].Vector.ToArray()));
        }

        public async void IAAzureOpenAIEmbeddingGenerator()
        {
            IEmbeddingGenerator<string, Embedding<float>> generator = new AzureOpenAIClient(
            new Uri(Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")),
             new DefaultAzureCredential()).AsEmbeddingGenerator(modelId: "text-embedding-3-small");

            var embeddings = await generator.GenerateAsync("What is AI?");

            Console.WriteLine(string.Join(", ", embeddings[0].Vector.ToArray()));
        }

        public async void IAOllamaEmbeddingGenerator()
        {
            IEmbeddingGenerator<string, Embedding<float>> generator = new OllamaEmbeddingGenerator(new Uri("http://localhost:11434/"), "all-minilm");
            var embedding = await generator.GenerateAsync("What is AI?");

            Console.WriteLine(string.Join(", ", embedding[0].Vector.ToArray()));
        }
    }
}