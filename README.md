# Meus-produtos

API Rest  <br/>
feito por: Rodrigo Nativo do Brasil Brochardt

## Como rodar o projeto

Para configurar o banco de dados será necessário ir no arquivo Meus_produtos > Infra > Data > Context > MySqlContext no método OnConfiguring() adicionar o server,a senha do mysql,o database e o user.
![configMysql](https://github.com/rodrigobrochardt/images/blob/main/configMysql.png)




## Desafios da implementação

Durante o desenvolvimento do projeto tive várias dificuldades que foram superadas, a mais trabalhosa foi a separação do projeto em camadas com a abordagem Driven Domain Design, para aplicar a abordagem do zero precisa de bastante tempo e esforço tive que refazer algumas vezes as camadas para a separação ficar adequada, porém, depois de já concluida a adição de novos elementos para o sistema fica mais organizado e sistemático, poupando tempo a longo prazo.
Na implementação da autenticação JWT também tive algums desafios que me tomou algumas horas para serem feitas, como a configuração adequada para funcionamento no Swagger, porém, depois que configurei no ambiente ficou mais simples o resto, como a geração do token e validação nas requisições.
