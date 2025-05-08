# 📝 Simple Todo Project

Este é um projeto full stack de uma aplicação de lista de tarefas (Todo List), desenvolvido com um **frontend em HTML/CSS/JavaScript puro** e um **backend em ASP.NET Core**. A aplicação permite criar, listar, marcar como concluídas e excluir tarefas. O objetivo é demonstrar a integração entre o frontend e uma API RESTful, utilizando um banco de dados para persistência.

---

## Tecnologias Utilizadas

### 🧩 Backend (API):
- **C#**
- **.NET 6 / ASP.NET Core**
- **Entity Framework Core**
- **Banco de dados: SQLite (pode ser alterado para outro via configuração)**
- **Padrão REST**
- **ViewModel para entrada de dados**

### 🎨 Frontend:
- **HTML5**
- **CSS3**
- **JavaScript (Vanilla JS)**
- **Fetch API para consumir a API REST**

---

## 📁 Estrutura do Projeto

TodoProject

- backend - API ASP.NET Core
   - Controllers/
   - Data/
   - Models/
   - ViewModels/
   - Program.cs

- frontend - Aplicação Web (estática)
   - index.html
   - style.css
   - script.js


---

## 🛠️ Como rodar o projeto localmente

### Pré-requisitos

- [.NET 5 SDK ou superior](https://dotnet.microsoft.com/en-us/download)
- [Git](https://git-scm.com/)
- Navegador atualizado

---

### Clonar o repositório

```bash
git clone https://github.com/wescaetano/simple-todo-api.git
cd simple-todo-api
```

### Rodando o Frontend
- Abra o arquivo index.html que está na pasta frontend/ com seu navegador.

- Dica: Para evitar problemas de CORS durante testes locais, você pode usar uma extensão no navegador como CORS Unblock ou hospedar o frontend em um servidor local (como o Live Server do VSCode).

## 📬 API Endpoints

### GET `/v1/todos`
- Retorna a lista de todas as tarefas.

**Resposta:**
```json
[
  {
    "id": 1,
    "title": "Fazer compras",
    "done": false,
    "date": "2025-05-08T12:34:56"
  }
]
```

### POST /v1/todos
- Cria uma nova tarefa.
Corpo da requisição:

```json
{
  "title": "Estudar ASP.NET Core"
}
```

### PUT /v1/todos/{id}
- Atualiza os dados de uma tarefa (por exemplo, título e status done).

Corpo da requisição:

```json
{
  "title": "Estudar Java e Spring",
  "done": true
}
```

### DELETE /v1/todos/{id}
- Remove uma tarefa com base no ID.

Resposta:

- 200 OK ou 404 Not Found se não existir.
