
# Lista de contatos

Projeto com intuito acadêmico, com o objetivo de colocar o aprendizado teórico na prática.

## Sobre o projeto

Um projeto CRUD que armazena dois tipos de meios de contato, e-mail e telefone também o nome referente a eles. Utiliza 
uma interface feita a partir do windows-form onde o usuário é capaz de inserir um novo contato, atualizar ou deletar um 
existente e pesquisar pelos contatos salvos.

## Tecnologias utilizadas

- C#
- Windows Form
- SQL
- MySQL

## Funcionalidades

- [x] CREAT
- [x] READ
- [x] UPADATE
- [x] DELETE

## Estrutura do banco de dados

![Diagrama](./assets/diagrama-banco.png)

## Como executar

1. Clone o repositório.
2. Acesse a pasta do projeto.
3. Utilize o script SQL para cria o schema.
4. Acesse a classe DbConneciton.cs e adicione as credenciais do seu localhost.
5. Inicialize o arquivo .exe ou execute o arquivo pela IDE.

## Limitações conhecidas do projeto

- Baixa escalabilidade: Não foi feita para receber grandes volumes de dados.
- Interface limitada: O sistema funciona exclusivamente como aplicação desktop windows, não possuindo uma interface web.
- Limitações de conexão: O banco de dados roda em localhost.
- Limitações de segurança: Não possui sistema de autenticação ou gerenciamento
   de usuários ou controle de acesso.

## Aprendizados

Foi possível por meio deste projeto entender na prática como interligar um banco de dados a uma interface através de
uma linguagem, permitindo com que dados sejam inseridos e alterados.

- LinkedIn: [linkedin/nicolas-machado-carlos](www.linkedin.com/in/nicolas-machado-carlos)
