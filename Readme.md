#API

Comando para Criar nova API: *dotnet new webapi* || *dotnet new webapi --framework net6.0*

Comando para recompilar a API, de modo que o **watch** fica monitorando alterações no projeto: *dotnet watch run*

Comando para **Entity Framework**: *dotnet tool install --global dotnet-ef* (Usar apenas uma vez)

Comando Design: *dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.25* (Sempre usar quando criar um novo projeto. Versão compatível com net6.0)

Comando Sql Server: *dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.25* (Sempre usar quando criar um novo projeto. Versão compatível com net6.0)

Comando Criar Migrações: *dotnet-ef migrations add <nome-da-migração>*

Comando para Criar o banco: *dotnet-ef database update*
