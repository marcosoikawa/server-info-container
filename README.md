---
ArtifactType: website
Language: C#
Platform: Linux Container
Tags: Container, Azure, WebSite, Inventory, ServerInfo
---

![GitHub](https://img.shields.io/github/license/microsoft/server-info-container) ![GitHub repo size](https://img.shields.io/github/repo-size/microsoft/server-info-container) [![Azure](https://badgen.net/badge/icon/azure?icon=azure&label)](https://azure.microsoft.com)

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
