
É Necessário:
SQL server express.
Configurar Conection Strings no arquivo Web.Config;
* para criação do usuário sql server existe um arquivo chamado CreateUser.sql dentro da pasta DBquery
* para mandar adicionar GameResult's no sistema é necessario realizar um post para o endpoint /api/gameresult
* com  o parametro no header do post [tokenAcesso: 72571b66-805a-40f4-9869-06e8c633a0a5]
* o post recebe um objeto no formato json com os seguintes parametros
						{ 
							"PlayerId": long,
							"GameId": long,
							"Win": long,
							"TimeStamp": DateTime
						}