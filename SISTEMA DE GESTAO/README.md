# DSS Estoque

Sistema desktop desenvolvido em **C# com Windows Forms**, integrado a um banco de dados MySQL para o gerenciamento de informações relacionadas a clientes, produtos e estoque.

O projeto foi desenvolvido no contexto do curso Técnico em Desenvolvimento de Sistemas, com o objetivo de aplicar conceitos de programação, desenvolvimento de interfaces gráficas e manipulação de dados relacionais.

## Tecnologias utilizadas

| Tecnologia | Aplicação |
|---|---|
| C# | Linguagem de programação |
| Windows Forms | Desenvolvimento da interface gráfica desktop |
| .NET | Plataforma de execução da aplicação |
| MySQL Community Server 8.4.7 | Sistema de gerenciamento de banco de dados |
| MySQL Workbench | Administração e execução de comandos SQL |
| WampServer 3.4.0 (64 bits) | Ambiente de servidor local |
| Visual Studio | Ambiente de desenvolvimento integrado (IDE) |
| Git | Controle de versão |
| GitHub | Hospedagem do repositório |

## Funcionalidades e módulos

O projeto possui formulários separados para organizar as áreas do sistema.

- **Clientes:** formulário destinado aos dados cadastrais dos clientes.
- **Produtos:** formulário destinado às informações dos produtos.
- **Estoque:** formulário destinado às informações relacionadas ao estoque.

Os formulários identificados no projeto são `FrmCliente.cs`, `FrmProduto.cs` e `FrmEstoque.cs`.

## Banco de dados

O sistema utiliza o banco de dados `IloveDellaTorre`, executado localmente no ambiente de desenvolvimento.

### Estrutura identificada

| Tabela | Descrição |
|---|---|
| `Produto` | Armazena código, descrição, valor e data de vencimento dos produtos. |
| `tb_estoque` | Armazena código, descrição, quantidade e data relacionada ao estoque. |
| `tb_cliente` | Armazena dados cadastrais, como CPF, nome, celular, e-mail e gênero. |

A estrutura do banco é definida por comandos SQL, incluindo criação de tabelas, inserção de registros e consultas.

### Ambiente do banco de dados

- **Servidor:** MySQL Community Server 8.4.7
- **Endereço local identificado:** `127.0.0.1:3306`
- **Banco de dados:** `IloveDellaTorre`
- **Ferramenta de gerenciamento:** MySQL Workbench
- **Ambiente local:** WampServer 3.4.0 (64 bits)

O WampServer também possui MariaDB instalado, mas a conexão exibida no MySQL Workbench durante o desenvolvimento utiliza o MySQL Community Server.

## Estrutura do projeto

Os principais arquivos identificados na solução do Visual Studio são:

```text
DSS_ESTOQUE_24-10-26/
├── DSS_PROJ_BD_21_09.sln 
├── ClsConexao.cs ==> Classe de conexão com o banco de dados
├── Form1.cs ==> Formulario de lançamento, menu para ida dos forms
├── FrmCliente.cs ==> Formulario de Clientes (cadastro de clientes novos, exclução e pesquisa)
├── FrmEstoque.cs ==> Formulario de Estoque (atualização de saida e entradas de produtos no estoque)
├── FrmProduto.cs ==> Formulario de Produtos (Cadastro de novos produtos, exclusão e atualização de produtos)
├── Program.cs
├── App.config
└── README.md
```

A estrutura acima representa os principais arquivos observados no projeto. Outros arquivos, como os arquivos `.Designer.cs`, `.resx` e `.csproj`, podem estar presentes na solução.

## Como executar o projeto

### Pré-requisitos

- Windows.
- Visual Studio com suporte ao C# e Windows Forms.
- MySQL Community Server compatível com a configuração do projeto.
- WampServer, caso utilizado para iniciar o serviço local do banco.
- Banco de dados e tabelas necessários para a aplicação.

### Passos para execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/Menezes-Gabs/DSS_ESTOQUE_24-10-26.git
   ```

2. Entre na pasta do repositório:

   ```bash
   cd DSS_ESTOQUE_24-10-26
   ```

3. Abra o arquivo `DSS_PROJ_BD_21_09.sln` no Visual Studio.

4. Inicie o serviço do MySQL pelo ambiente local e confirme que o servidor está disponível.

5. Crie ou importe o banco de dados `IloveDellaTorre` e suas tabelas utilizando o script SQL do projeto, caso disponível.

6. Confira a configuração da conexão no arquivo `ClsConexao.cs` e ajuste os parâmetros para o ambiente local.

7. Restaure as dependências necessárias, compile e execute a aplicação pelo Visual Studio.

## Segurança e configuração

As credenciais de acesso ao banco de dados devem ser configuradas de acordo com o ambiente de execução.

**Não publique senhas, credenciais ou dados pessoais reais no repositório.** Antes de compartilhar scripts SQL ou arquivos de configuração, verifique se eles contêm informações sensíveis.

## Objetivos de aprendizagem

- Desenvolver aplicações desktop utilizando C# e Windows Forms.
- Organizar o código por meio de formulários e classes.
- Modelar e manipular dados em um banco de dados relacional.
- Executar comandos SQL para criação, inserção e consulta de dados.
- Trabalhar com ferramentas de desenvolvimento e administração de bancos de dados.
- Utilizar Git e GitHub para versionamento e compartilhamento do código-fonte.

## Status do projeto

Projeto acadêmico desenvolvido durante o curso Técnico em Desenvolvimento de Sistemas.

## Autor

**Menezes-Gabs**

Estudante de Desenvolvimento de Sistemas.

## Licença

Nenhuma licença de uso foi definida neste repositório até o momento. Para permitir formalmente a reutilização e distribuição do código, recomenda-se definir uma licença apropriada.
