# AgendaContato

O projeto CRUD criado API utilizando as seguinte ferramentas:
    Microsoft.EntityFrameworkCore Version="5.0.0"
    Microsoft.EntityFrameworkCore.Design Version="5.0.0"
    Microsoft.EntityFrameworkCore.SqlServer Version="5.0.0"
    Microsoft.EntityFrameworkCore.Tools Version="5.0.0"
    Swashbuckle.AspNetCore Version="5.6.3" 

## Configuração antes de Excutar
    Modificar a conexão com o banco de dados. 
    No arquivo appsettings.json na variavel  "ServerConnection": alterar para o seu link de conexão base de dados SqlServe.
  
## Migrations
    Verificar se as migrations esta no projeto, caso não estaja executar os seguintes procedimentos:
    Na aba do Visual Studio ir em 'Ferramentas', 'Gerenciador de Pacotes do NuGet', 'Console do Gerenciador de Pacotes' 
    e digitar os sequintes comandos:
    Add-Migration Inicial-Criacao -Context Conexao
    Update-database -Context Conexao
    
   <h2> Caso no projeto ja esteja com as Migrations executar somente esse procedimentos </h2>
    Na aba do Visual Studio ir em 'Ferramentas', 'Gerenciador de Pacotes do NuGet', 'Console do Gerenciador de Pacotes' e digitar os sequintes comandos:
    Update-database -Context Conexao
    
    Logo apos a execução desse comando sera criado a base de dados no banco de dados.
    Finalizado todos esses procedimentos o projeto já esta configurado para ser executado.
    
    Executar API e logo apos o front end.
