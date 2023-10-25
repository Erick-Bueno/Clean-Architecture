# Projeto Clean Architecture com C# e Entity Framework

Este é um exemplo de projeto que demonstra a implementação de uma arquitetura limpa (Clean Architecture) em uma aplicação C# usando o Entity Framework para a camada de persistência de dados.

## Estrutura do Projeto

O projeto segue uma estrutura típica de Clean Architecture, dividida em várias camadas:

- **API**: Esta camada é responsável por expor os endpoints da aplicação, geralmente usando um framework web como ASP.NET Core.

- **Application**: Nesta camada, a lógica de negócios da aplicação é implementada. Ela atua como uma camada intermediária entre a API e o domínio.

- **Domain**: Aqui, definimos as entidades de domínio, objetos de valor, regras de negócios e interfaces de repositorios que são agnósticos à infraestrutura.

- **Infrastructure**: Esta camada é onde implementamos a lógica de infraestrutura, como o acesso a banco de dados, serviços de terceiros, etc. O Entity Framework é comumente usado aqui.

- **Presentation**: O projeto de apresentação é responsável pela interface do usuário, que pode ser uma aplicação web, desktop ou mobile. 

## Requisitos

- Visual Studio ou Visual Studio Code (ou qualquer outra IDE de sua escolha).
- .NET Core SDK instalado.
- Entity Framework Core (EF) para acesso ao banco de dados.

## Configuração do Banco de Dados

Para configurar o banco de dados, siga os passos abaixo:

1. crie um arquivo .env com a chave CONNECTION_STRING e adicione a string de conexão do banco que você estiver usando.
2. No Visual Studio, abra o Console do Gerenciador de Pacotes (Tools > NuGet Package Manager > Package Manager Console).
3. Execute o comando `Update-Database` para criar o banco de dados e aplicar as migrações.

## Executando o Projeto

1. Abra o projeto na IDE de sua escolha.
2. Certifique-se de definir o projeto de API como projeto de inicialização.
3. Execute a aplicação.

## Contribuindo

Sinta-se à vontade para contribuir para este projeto! Você pode ajudar a melhorar o código, adicionar recursos ou corrigir bugs. Basta seguir os passos abaixo:

1. Faça um fork deste repositório.
2. Crie uma branch com a sua feature: `git checkout -b minha-feature`.
3. Faça commit das suas mudanças: `git commit -m 'Adicionando nova feature'`.
4. Envie as alterações para o seu fork: `git push origin minha-feature`.
5. Envie um pull request para este repositório.

## Licença

Este projeto é licenciado sob a Licença MIT. Consulte o arquivo [LICENSE](LICENSE) para obter mais detalhes.

## Contato

Se você tiver alguma dúvida ou precisar de assistência, sinta-se à vontade para entrar em contato conosco através do email erickjb93@gmail.com ou abrindo uma issue neste repositório.

Espero que este README seja útil para o seu projeto de Clean Architecture com C# e Entity Framework. Boa sorte com o desenvolvimento!
