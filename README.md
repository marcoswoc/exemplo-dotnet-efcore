# exemplo-dotnet-efcore

## Introdução

Como desenvolvedores de software sabemos que ao criar novas features ou corrigir um bug pode surgir a necessidade de uma alteração no banco de dados, a migração (migrations) é um recurso do EF Core que utilizamos para versionar o modelo de dados proporcionando assim um controle maior do banco de dados e mantendo a sicronia entra o banco e a aplicação. []!! neste !!! [] artigo iremos abordar alguns comando CLI para trabalhar com migrações no EF Core.


## Pré-Requisitos
- .NET 5 +
- SQl Server Express 2019 (LocalDB)

## Criando o projeto

Com o comando **`dotnet new console`** vamos criar um projeto console, o parametro **`-o`** indica o nome do diretorio onde o projeto sera criado.

    dotnet new console -o exemplo-dotnet-efcore


## Installando o pacote SqlServer

O comando  **`dotnet add package`** adiciona pacotes ao projeto, Os comandos precisam ser executados no mesmo diretorio do arquivo .csproj, vamos adicionar o pacote do SqlServer com o seguinte comando:

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer



O EF Core oferece duas opçoes de mapeamento Code First e Database First:

### Code First

Code First é a abordagem mais comum onde o banco de dados é gerado apartir do codigo, utilizando Data Annotations que são atributos adicionados na sua classe, ou Fluent API que são métodos de extensão que oferece mais opções de configuração para criar mapeamentos mais completos de suas tabelas.
### Database First
No Database First o processo de mapeamento é diferente do Code First a partir de um banco de dados existente o Ef Core utiliza o processo Scaffold para gerar classes C# em seu projeto, em determinadas configurações é necessario realizar algumas correções.

Nesse exemplo vamos utlizar o Code First

## DbContext

DbContext é a classe mais importante para o EF Core, utilizando metodos para gravar e ler informações essa classe tem como objetivo facilitar a interação da aplicação com o banco de dados.


## Ef


    dotnet tool isntall --global dotnet-ef 

![img-1](Img/img-1.png)


    dotnet ef

![img-2](Img/img-2.png)

**`Microsoft.EntityFrameworkCore.Design`**

**`Microsoft.EntityFrameworkCore.Tools`**