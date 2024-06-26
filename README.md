---
ArtifactType: website
Language: C#
Platform: Linux Container
Tags: Container, Azure, WebSite, Inventory, ServerInfo
---

![GitHub](https://img.shields.io/github/license/marcosoikawa/server-info-container) 
![GitHub repo size](https://img.shields.io/github/repo-size/marcosoikawa/server-info-container) 
[![Azure](https://badgen.net/badge/icon/azure?icon=azure&label)](https://azure.microsoft.com)

![GitHub last commit](https://img.shields.io/github/last-commit/marcosoikawa/server-info-container)
![GitHub top language](https://img.shields.io/github/languages/top/marcosoikawa/server-info-container)


# Server Info
This application exposes Server and Client informations, resulted of a list from Environment.GetEnvironmentVariables method of dotnet.

Usefull in development time to know environment virables and other informations.

Not recommended to leave on production environments with public access.

This is the portable version to run in a Docker container.

## 1) Site Overview

<br/>

- The home site exposes information about your infrastructure in a clean and very easy table. 

<br/>

![Overview](images/server-info-1.png)

<br/>

- Client site exposes information about client (browser) that is accessing the site, as well some client informations that is available in code.

<br/>

![Overview](images/server-info-2.png)
## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
