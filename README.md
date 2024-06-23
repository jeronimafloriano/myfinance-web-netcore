# myfinance-web-netcore: Plano de Contas e Registro de Transações

## Descrição do Projeto
Uma aplicação web para registro e análise de receitas e despesas de famílias, permitindo um melhor planejamento financeiro.

## Arquitetura Utilizada
- Backend: ASP.NET MVC
- Banco de Dados: SQL Server

## Tecnologias
- ASP.NET MVC
- Entity Framework
- SQL Server
- Bootstrap

## Configuração para Startup do Projeto
1. Clone o repositório.
2. Configure a string de conexão do banco na MyFinanceDbContext.cs caso necessário.
4. Execute o projeto a partir do Visual Studio.

## Estrutura do Projeto
- **Controllers:** PlanoContaController, TransacaoController
- **Domain:** PlanoConta, Transacao
- **Infrastructure:** MyFinanceDbContext
- **Mappers:** PlanoContaMap, TransacaoMap
- **Models:** ErrorViewModel, PlanoContaModel, TransacaoModel
- **Views:** CRUDs para PlanoConta e Transacao
- **SQL:** ScriptSqlQuery para criação de tabelas iniciais
- **Documentation:** README.md

## Telas do Projeto
Ao executar o projeto, as telas de listagem de plano de contas e transação serão como:
<br>
Plano de Contas:
<br>

![Plano de Contas](https://github.com/jeronimafloriano/myfinance-web-netcore/blob/main/plano-conta.png)

<br>
Transações:
<br>

![Transações](https://github.com/jeronimafloriano/myfinance-web-netcore/blob/main/transacoes.png)