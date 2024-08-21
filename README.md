# TaskManager

**TaskManager** é uma aplicação de gerenciamento de tarefas desenvolvida em C# e ASP.NET Core. O objetivo do projeto é fornecer uma solução robusta e escalável para o gerenciamento de tarefas e usuários, utilizando uma arquitetura de software modular e limpa.

## Sumário

- [Descrição do Projeto](#descrição-do-projeto)
- [Arquitetura](#arquitetura)
- [Funcionalidades](#funcionalidades)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Instalação e Configuração](#instalação-e-configuração)
- [Uso](#uso)
- [Contribuição](#contribuição)
- [Licença](#licença)

## Descrição do Projeto

**TaskManager** é uma aplicação que permite:

- **Gerenciamento de Usuários:** Adicionar, editar, remover e recuperar informações de usuários.
- **Gerenciamento de Tarefas:** Criar, editar, excluir e visualizar tarefas associadas a usuários.
- **Arquitetura Modular:** Separação em camadas para manter a aplicação organizada e facilitar a manutenção e escalabilidade.

## Arquitetura

O projeto está estruturado em camadas, seguindo uma arquitetura limpa:

- **Camada Web (MVC):** Apresentação da inferface do usuario.
- **Camada de Apresentação (API):** Responsável por expor endpoints para interação com o sistema.
- **Camada de Aplicação:** Contém a lógica de negócios e regras da aplicação.
- **Camada de Infraestrutura:** Gerencia o acesso ao banco de dados e implementa os repositórios.
- **Camada de Domínio:** Define os modelos de dados e as interfaces de repositório.

## Funcionalidades

**Usuários:**

- Cadastro de novos usuários.
- Edição de dados de usuários existentes.
- Remoção de usuários.
- Recuperação de informações de usuários.

**Tarefas:**

- Adição de novas tarefas.
- Atualização e exclusão de tarefas.
- Visualização de tarefas associadas a usuários.

## Tecnologias Utilizadas

- **ASP.NET Core:** Framework para desenvolvimento da API.
- **Entity Framework Core:** ORM para gerenciamento de banco de dados.
- **SQL Server:** Sistema de gerenciamento de banco de dados.

