# Calculadora de Investimento CDB

Este projeto consiste em uma Web API ASP.NET Core para calcular investimentos CDB e um aplicativo Angular que consome a API para exibir os resultados.

## Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

- Node.js (https://nodejs.org/)
- Angular CLI (https://angular.io/cli)
- .NET 7 SDK (https://dotnet.microsoft.com/download/dotnet/7.0)

## Executando a API ASP.NET Core

1. Abra o terminal e navegue até a pasta `GS.DesafioCDB.API`:
2. Execute o comando para iniciar a API: dotnet run
3. A API estará disponível em `https://localhost:5001`. Você pode testar a API acessando esta URL no navegador ou usando ferramentas como o Postman.

## Executando o Aplicativo Angular

1. Abra outro terminal e navegue até a pasta `GS.DesafioCDB.WebApp`:
2. Instale as dependências do aplicativo: npm install
3. Execute o aplicativo Angular: ng serve
4. O aplicativo estará disponível em `http://localhost:4200`. Abra seu navegador e acesse esta URL para usar a calculadora de investimento CDB.
5. Certifique-se de que a API ASP.NET Core esteja em execução enquanto usa o aplicativo Angular.

## Executando o Projeto pelo Visual Studio

1. Altere a execução para multiplos projetos incluindo a API e o projeto WebApp
   ![image](https://github.com/gsilvasts/DesafioCDB/assets/17418160/63e8f9f6-ac4e-4703-b561-473e8ab435cd)
2. Execute os projetos   
   ![image](https://github.com/gsilvasts/DesafioCDB/assets/17418160/90d136f9-7e4e-4d64-826c-d652198c062c)
3. A API estará disponível em `https://localhost:5001`
4. O aplicativo estará disponível em `http://localhost:4200`. Abra seu navegador e acesse esta URL para usar a calculadora de investimento CDB.

## Como Usar

1. No aplicativo Angular, insira o valor inicial do investimento (em reais) e o número de meses para o resgate.
2. Clique no botão "Calcular" para calcular o investimento CDB.
3. Os resultados, incluindo o valor bruto e líquido do CDB, serão exibidos na tela.
