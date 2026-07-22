<div align="center">

# 📚 LPR_2k26

### Exercícios da disciplina de Linguagem de Programação — ETE FMC

<br/>

![C++](https://img.shields.io/badge/C%2B%2B-00599C?style=for-the-badge&logo=c%2B%2B&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%209-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/status-conclu%C3%ADdo-brightgreen?style=for-the-badge)

</div>

---

## 👨‍💻 Sobre o repositório

Este repositório reúne os exercícios práticos desenvolvidos ao longo das aulas de **Linguagem de Programação (LPR)**. Cada exercício é resolvido **duas vezes** — uma em **C++** e outra em **C#** — com o mesmo enunciado e a mesma lógica, para fixar o raciocínio de programação independentemente da sintaxe da linguagem utilizada.

A trilha evolui de forma progressiva: começa com saída de texto simples, passa por seleção, repetição, funções, vetores e matrizes, e termina com `struct`s, listas e dicionários — cobrindo, na prática, os pilares da lógica de programação estruturada.

|                    |                                                                   |
| ------------------ | ----------------------------------------------------------------- |
| 🏫 **Instituição** | Escola Técnica de Eletrônica Francisco Moreira da Costa (ETE FMC) |
| 🎓 **Curso**       | Técnico em Desenvolvimento de Sistemas (DS)                       |
| 📘 **Disciplina**  | Linguagem de Programação (LPR)                                    |
| 👨‍🏫 **Professor**   | José Andery Carneiro                                              |
| 🙋 **Aluno**       | Iury Gonçalves de Souza                                           |
| 📅 **Ano letivo**  | 2026                                                              |

---

## 🗂️ Sumário

- [Estrutura do repositório](#️-estrutura-do-repositório)
- [Conteúdo das aulas](#-conteúdo-das-aulas)
- [Como executar](#️-como-executar)
- [Sobre a revisão de código](#-sobre-a-revisão-de-código)
- [Competências desenvolvidas](#-competências-desenvolvidas)
- [Autor](#-autor)

---

## 🗃️ Estrutura do repositório

Cada exercício possui sua própria implementação em C++ (arquivo solto) e em C# (projeto .NET em subpasta):

```text
LPR_2k26/
├── Aula01/
│   └── helloworld.cpp                # primeiro contato com o console
│   └── helloworld/Program.cs
│
├── Aula02 a Aula05/
│   └── exercicioNN.cpp               # variáveis, seleção e repetição
│   └── exercicioNN/Program.cs
│
├── Aula06 a Aula07/
│   └── exercicioNN.cpp               # funções, vetores e matrizes
│   └── exercicioNN/Program.cs
│
├── Aula08/
│   └── exercicioNN.cpp               # structs
│   └── exercicioNN/Program.cs
│
├── Aula09/
│   └── exercicioNN.cpp               # listas e dicionários
│   └── exercicioNN/Program.cs
│
└── README.md
```

> Cada `exercicioNN/` em C# é um mini-projeto `.csproj` independente (criado com `dotnet new console`), o que permite abrir e rodar qualquer exercício isoladamente pelo Visual Studio, VS Code ou terminal.

---

## 📖 Conteúdo das aulas

| Aula | Tópico                                                      | Exercícios | Destaques                                           |
| :--: | ----------------------------------------------------------- | :--------: | --------------------------------------------------- |
|  01  | Primeiro programa e ambiente de desenvolvimento             |     1      | `cout` / `Console.WriteLine`                        |
|  02  | Tipos de dados e operadores aritméticos                     |     4      | Cálculo de área, folha de pagamento, custo de peças |
|  03  | Git, GitHub e versionamento                                 |     1      | Primeiro commit                                     |
|  04  | Estruturas de seleção (`if` / `switch`)                     |     3      | Paridade, múltiplos, RPG de classes                 |
|  05  | Estruturas de repetição (`while`, `do-while`, `for`)        |     5      | Médias, jogo de adivinhação, treino Jedi            |
|  06  | Funções e modularização                                     |     3      | Reverso de número, menu de funções, equipe Marvel   |
|  07  | Vetores e matrizes                                          |     8      | Busca, matrizes 3×3, multiplicação, mapa de cinema  |
|  08  | `struct`s                                                   |     5      | Filmes, produtos, livros, heróis, chamados          |
|  09  | Listas e dicionários (`list`, `map` / `List`, `Dictionary`) |     8      | Ranking, dicionário de jogos, biblioteca            |

<div align="center">

**Total: 38 exercícios · 76 implementações (C++ + C#)**

</div>

---

## ▶️ Como executar

### C++

Qualquer exercício pode ser compilado com o `g++` (parte do MinGW no Windows, ou já disponível por padrão no Linux/macOS):

```bash
cd Aula09
g++ exercicio08.cpp -o exercicio08
./exercicio08        # no Windows: exercicio08.exe
```

> Os arquivos usam `setlocale(LC_ALL, "pt_BR.UTF-8")` para acentuação correta no console. Em alguns terminais Windows pode ser necessário rodar `chcp 65001` antes, para garantir a codificação UTF-8.

### C#

Cada exercício é um projeto `.csproj` independente:

```bash
cd Aula09/exercicio08
dotnet run
```

> ⚠️ Alguns programas usam `system("cls")` (C++) ou `Console.Clear()` (C#) para limpar a tela — isso é específico do **Windows**. No Linux/macOS, `system("cls")` não tem efeito (o comando equivalente seria `system("clear")`).

---

## 🔍 Sobre a revisão de código

Este repositório passou por uma revisão completa focada em portfólio:

- **Comentários explicativos** foram adicionados ao longo do código, priorizando trechos de lógica não triviais (iteradores, conversões de índice, condições de parada, estruturas de dados) — sem comentar o óbvio.
- **Bugs reais foram corrigidos**, com destaque para dois casos na Aula 09 (exercícios 06 e 07) em que o dicionário era modificado _durante_ a própria iteração `for`/`foreach` — comportamento indefinido em C++ e uma exceção garantida (`InvalidOperationException`) em C#.
- **Pequenas inconsistências de formatação e padrão** (indentação, chamadas de pausa ausentes) foram padronizadas.
- Onde havia uma limitação de design proposital do exercício (ex: `system("cls")` só funcionar no Windows, ou uma leitura ambígua do enunciado), isso foi documentado em comentário, em vez de alterado silenciosamente.

Os enunciados originais no topo de cada arquivo foram mantidos intactos.

---

## 📌 Competências desenvolvidas

- 🧠 Lógica de programação e resolução de problemas
- 🧱 Programação estruturada e modularização através de funções
- 🔢 Manipulação de vetores, matrizes e `struct`s
- 🗂️ Listas e dicionários (`list`/`map` em C++, `List`/`Dictionary` em C#)
- 🔀 Estruturas condicionais e de repetição
- 🌿 Controle de versão com Git e GitHub
- 🔁 Equivalência de lógica entre linguagens distintas (C++ e C#)
- 🐛 Leitura crítica de código: identificação de bugs e inconsistências

---

## 👤 Autor

Projeto acadêmico desenvolvido por **Iury Gonçalves de Souza**, no curso Técnico em Desenvolvimento de Sistemas da **ETE FMC**.

<p>
  <a href="https://github.com/iury-igd1">
    <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"/>
  </a>
  <a href="#">
    <img src="https://img.shields.io/badge/LinkedIn-adicionar%20link-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn"/>
  </a>
  <a href="#">
    <img src="https://img.shields.io/badge/E--mail-adicionar%20e--mail-D14836?style=for-the-badge&logo=gmail&logoColor=white" alt="E-mail"/>
  </a>
</p>
