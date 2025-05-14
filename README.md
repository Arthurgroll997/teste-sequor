# Teste de Seleção Sequor

## Backend

##### Rotas de API: 

- api/orders/GetOrders
- api/orders/SetProduction
- api/orders/GetProduction?email=email_para_consulta@email.com

## Frontend

#### Telas:
- Tela de apontamento para produção e de visualização de ordens;
- Tela de visualização das ordens apontadas para produção.

## Tecnologias utilizadas

- Banco de Dados Microsoft SQL Server e Entity Framework;
- ASP.NET Core para a Web API;
- Windows Forms no Frontend;
- xUnit para testes da API do Backend.

## Requisitos para rodar

- Versão 8 do .NET
- xUnit
- dotnet CLI tools/.NET Tools
- Banco de Dados SQL Server com a porta 1433 e senha #$3quoR123 no usuário "sa" (caso você utilize/tenha Docker, há um docker compose na raiz do projeto - basta rodar docker-compose up --build -d que o banco irá subir normalmente se a porta 1433 estiver disponível)
- Portas 1433 e 5066 aberta
- Preferível ter instalado os pacotes recomendados de desenvolvimento Web e Desktop disponibilizados no Visual Studio Installer

## Como rodar

- Basta acessar o diretório OrderManagerBack e rodar o comando "dotnet run", esperar o banco estar disponível para conexões e iniciar o Windows Forms pelo depurador do Visual Studio 2022.
- Para rodar os testes, basta acessar o diretório dos testes (OrderManagerTests) e rodar "dotnet test" que eles serão executados automaticamente.

##### Autor: Arthur Von Groll dos Santos