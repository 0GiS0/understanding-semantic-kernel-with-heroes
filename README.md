# Understanding Semantic Kernel with Super Heroes

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](/LICENSE)
[![Twitter: elbruno](https://img.shields.io/twitter/follow/elbruno.svg?style=social)](https://twitter.com/elbruno)
![GitHub: elbruno](https://img.shields.io/github/followers/elbruno?style=social)

✨ 
Understanding Semantic Kernel with Heroes is a set of Polyglot notebooks that explores the concept of Semantic Kernel. The notebooks demonstrates how to learn the basis of Semantic Kernel using comic book heroes based on their descriptions. For more details, check out the repository. 🚀📚

## Getting started - Semantic Kernel

This repository contains a set of notebooks, in different languages, that helps you learn how to use Semantic Kernel. For more information, check out the [Semantic Kernel Overview](https://learn.microsoft.com/en-us/semantic-kernel/overview/?WT.mc_id=academic-00000-brunocapuano).

Semantic Kernel is a powerful tool that allows developers to integrate cutting-edge language models into their applications with ease. Semantic Kernel provides a unified interface to access various language models from different sources, such as OpenAI, AzureOpenAI, and Hugging Face. Semantic Kernel also enables developers to store and retrieve memories, create dynamic prompts, and combine functions together with planners.

With Semantic Kernel, developers can supercharge their problem-solving creativity and build AI solutions that can understand natural language, generate content, answer questions, and more. Semantic Kernel is an open-source project that can be run on any local machine or cloud environment. Semantic Kernel offers tutorials, guides, and examples to help developers get started quickly and learn how to use its features.

## Topics

1. Understanding Semantic Kernel
2. (Optional) - Creating an Azure Open AI 🤖 Service and Deployments
3. How to get started with Semantic Kernel
4. Using Semantic Kernel plugins
5. Semantic Functions
6. Native Functions
7. Planner
8. Advanced Planner Labs
9. Kernel Memory

## Semantic Kernel C# Notebooks

The current folder contains a few C# Polyglot Notebooks that demonstrate how to get started with the Semantic Kernel. 

To run the notebooks, we recommend the following steps:

- [Install .NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Install Visual Studio Code (VS Code)](https://code.visualstudio.com)
- Launch VS Code and [install the "Polyglot" extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode).
  Min version required: v1.0.4606021 (Dec 2023).

The steps above should be sufficient, you can now **open all the C# notebooks in VS Code**.

VS Code screenshot example:

![image](/images/10VSCodeDemo.png)

## Troubleshooting

## Nuget

If you are unable to get the Nuget package, first list your Nuget sources:

```sh
dotnet nuget list source
```

If you see `No sources found.`, add the NuGet official package source:

```sh
dotnet nuget add source "https://api.nuget.org/v3/index.json" --name "nuget.org"
```

Run `dotnet nuget list source` again to verify the source was added.

## Polyglot Notebooks

If somehow the notebooks don't work, run these commands:

- Install .NET Interactive: `dotnet tool install -g Microsoft.dotnet-interactive`
- Register .NET kernels into Jupyter: `dotnet interactive jupyter install` (this might return some errors, ignore them)
- If you are still stuck, read the following pages:
  - https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode
  - https://devblogs.microsoft.com/dotnet/net-core-with-juypter-notebooks-is-here-preview-1/
  - https://docs.servicestack.net/jupyter-notebooks-csharp
  - https://developers.refinitiv.com/en/article-catalog/article/using--net-core-in-jupyter-notebook

Note: ["Polyglot Notebooks" used to be called ".NET Interactive Notebooks"](https://devblogs.microsoft.com/dotnet/dotnet-interactive-notebooks-is-now-polyglot-notebooks/),
so you might find online some documentation referencing the old name.

## Author

👤 **Bruno Capuano**

* Website: https://elbruno.com
* Twitter: [@elbruno](https://twitter.com/elbruno)
* Github: [@elbruno](https://github.com/elbruno)
* LinkedIn: [@elbruno](https://linkedin.com/in/elbruno)

## 🤝 Contributing

Contributions, issues and feature requests are welcome!

Feel free to check [issues page](https://github.com/elbruno/understanding-semantic-kernel-with-heroes/issues).

## Show your support

Give a ⭐️ if this project helped you!


## 📝 License

Copyright &copy; 2024 [Bruno Capuano](https://github.com/elbruno).

This project is [MIT](/LICENSE) licensed.

***