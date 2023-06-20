<h1 align="center">Gerenciador de Tarefas Infantis - TASK MANAGER KIDS</h1>

## Descrição

**Task Manager Kids** é um sistema projetado para auxiliar pais e filhos no gerenciamento de suas tarefas diárias. Com foco na organização e no incentivo, o aplicativo oferece uma plataforma interativa para dois tipos de usuários: o responsável e a criança.

**Papel do Responsável:** Os pais ou responsáveis têm acesso a uma visão abrangente de todas as tarefas a serem feitas, em andamento e concluídas por seus filhos. Eles podem criar novas tarefas, atribuindo um título, descrição e pontuação correspondente para cada uma delas. Além disso, os responsáveis têm a opção de cadastrar recompensas que serão concedidas aos filhos ao alcançarem seus objetivos.

**Papel da Criança:** As crianças têm a capacidade de visualizar e dar início às tarefas atribuídas a elas. À medida que concluem cada tarefa, podem marcá-la como finalizada e acompanhar seu score, que é atualizado ao longo do mês. Esse score reflete o desempenho das crianças e serve como uma forma motivadora de acompanhar seu progresso.

Com o Task Manager Kids, pais e filhos podem trabalhar juntos de forma mais eficiente na gestão das responsabilidades diárias, incentivando a disciplina e estabelecendo metas alcançáveis. O aplicativo oferece uma maneira divertida e interativa de promover o desenvolvimento de habilidades e a autonomia das crianças, enquanto fortalece o vínculo familiar.

## Requisitos

- **Entity Framework:** O sistema utiliza o Entity Framework como ORM (Object-Relational Mapping) para interagir com o banco de dados. Certifique-se de ter o Entity Framework instalado e configurado corretamente no ambiente de desenvolvimento.

### Instalando o Entity Framework

Para instalar o Entity Framework, siga os seguintes passos:

1. Abra o Visual Studio e abra o projeto do Task Manager Kids.
2. No menu "Ferramentas", selecione "Gerenciador de Pacotes NuGet" e clique em "Console do Gerenciador de Pacotes".
3. No console do Gerenciador de Pacotes, digite o seguinte comando e pressione Enter:

   ```
   Install-Package EntityFramework
   ```

4. O NuGet irá baixar e instalar o pacote do Entity Framework no projeto.

Certifique-se de que todas as dependências e configurações necessárias para o Entity Framework estão corretamente configuradas no projeto.

## Diagramas

### 2.1 Caso de Uso

![casodeuso](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/3147f035-129a-4a4f-8edf-aaa66a89803b.png)

### 2.2 Diagrama de Classe

![DiagramaClasse](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/07c4c140-2cfc-4712-b5df-cbbbc74e97cb.png)

### 2.3 BPMN

#### 2.3.1 Fluxo Criar Tarefa

![criarTarefa](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/e527e074-f63e-4dd7-89c8-b0f627e1b370.png)

#### 2.3.2 Fluxo Iniciar Tarefa

![realizarTarefa](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/7f8e0282-478a-4536-8222-ce9b022e25dd.png)

#### 2.3.3 Fluxo Finalizar Tarefa

![finalizarTarefa](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/331e87ad-9273-4a9c-b0d2-653f4c02916b.png)

#### 2.3.4 Fluxo Resgatar Recompensa

![resgatarRecompensa](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/8bb89a92-9f5b-4c53-b07a-e2a30bb24057.png)

## Rodando o Projeto

#### Init Project

![initProject](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/c65ac303-ca7a-4da1-b8af-225016442079.png)

#### GET - KIDS

![step1](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/f4c3b5f5-214a-444a-b522-bd4b7d3d63d4.png)

#### Execultando Método GET

![step2](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/73c81720-cf21-4436-aa98-e0931e11005c.png)

#### Response da Pesquisa

![step3](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/3e13aa55-7353-4ad7-9101-ef1d5710c65b.png)

#### Swagger Completa

![swagger](https://github.com/ryannlopes/Task_Manager_Kids/assets/61668167/073a6e43-ecb1-4903-b244-d22b0ee7f973.png)
