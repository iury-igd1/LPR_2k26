<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0F172A,100:2563EB&height=180&section=header&text=LPR%20%7C%202026&fontSize=44&fontColor=FFFFFF&fontAlignY=36" alt="LPR — Linguagem de Programação — 2026" width="100%">

<h3>Exercícios de Linguagem de Programação</h3>

<p>
Repositório desenvolvido durante o curso Técnico em Desenvolvimento de Sistemas da <strong>ETE FMC</strong>.<br>
</p>

<p>
<img src="https://img.shields.io/badge/C%2B%2B-00599C?style=for-the-badge&logo=cplusplus&logoColor=white" alt="C++">
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=dotnet&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/.NET%209-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 9">
<img src="https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white" alt="Python">
<img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" alt="SQLite">
<img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git">
</p>

<p>
<img src="https://img.shields.io/badge/Aulas-11-2563EB?style=flat-square" alt="11 aulas">
<img src="https://img.shields.io/badge/Exerc%C3%ADcios-53-16A34A?style=flat-square" alt="53 exercícios">
<img src="https://img.shields.io/badge/Arquivos%20de%20c%C3%B3digo-100-7C3AED?style=flat-square" alt="100 arquivos de código">
<img src="https://img.shields.io/badge/Ano-2026-475569?style=flat-square" alt="Ano 2026">
</p>

<p>
<a href="#sobre">📘 Sobre</a> &nbsp;·&nbsp;
<a href="#aulas">📚 Aulas</a> &nbsp;·&nbsp;
<a href="#estrutura">📂 Estrutura</a> &nbsp;·&nbsp;
<a href="#execucao">▶️ Execução</a> &nbsp;·&nbsp;
<a href="#autor">👤 Autor</a>
</p>

</div>

---

<a id="sobre"></a>

## 📘 Sobre o repositório

**LPR_2k26** reúne as atividades desenvolvidas na disciplina de **Linguagem de Programação**, durante o curso Técnico em Desenvolvimento de Sistemas da **ETE FMC**, em 2026.

### 🎓 Contexto acadêmico

| Informação | Descrição |
| :--- | :--- |
| **Instituição** | Escola Técnica de Eletrônica "Francisco Moreira da Costa" (ETE FMC) |
| **Curso** | Técnico em Desenvolvimento de Sistemas |
| **Disciplina** | Linguagem de Programação (2026) |
| **Professor** | José Andery Carneiro |
| **Aluno** | Iury Gonçalves de Souza |

Os exercícios acompanham os conteúdos apresentados em aula: entrada e saída no console, operações aritméticas, estruturas de controle, funções, estruturas de dados, classes e consultas SQL.

| Etapa | Abordagem |
| :--- | :--- |
| **Aulas 01 a 10** | Cada exercício possui versões em **C++ e C#**, permitindo comparar a sintaxe e os recursos utilizados para resolver o mesmo problema. |
| **Aula 11** | Utiliza **Python e SQLite** para praticar consultas SQL, atualização de registros e relacionamentos entre tabelas. |

---

<a id="aulas"></a>

## 📚 Conteúdo das aulas

| Aula | Conteúdo principal | Exercícios | Linguagens |
| :---: | :--- | :---: | :--- |
| [**01**](Aula01/) | Primeiro programa e saída no console | 1 | C++ e C# |
| [**02**](Aula02/) | Tipos de dados e operadores aritméticos | 4 | C++ e C# |
| [**03**](Aula03/) | Git, GitHub e versionamento | 1 | C++ e C# |
| [**04**](Aula04/) | Estruturas de seleção | 3 | C++ e C# |
| [**05**](Aula05/) | Estruturas de repetição | 5 | C++ e C# |
| [**06**](Aula06/) | Funções e modularização | 3 | C++ e C# |
| [**07**](Aula07/) | Vetores e matrizes | 8 | C++ e C# |
| [**08**](Aula08/) | Structs e organização de registros | 5 | C++ e C# |
| [**09**](Aula09/) | Listas e dicionários | 8 | C++ e C# |
| [**10**](Aula10/) | Classes, objetos e relacionamentos | 8 | C++ e C# |
| [**11**](Aula11/) | SQL e banco de dados com SQLite | 7 | Python |
| **Total** | | **53** | |

### 📊 O repositório em números

| C++ | C# | Python | Total |
| :---: | :---: | :---: | :---: |
| **46** implementações | **46** implementações | **7** exercícios + **1** script de criação | **100** arquivos de código |

Os **53 exercícios** correspondem a 46 atividades com versões em C++ e C#, mais 7 atividades em Python.

---

<a id="estrutura"></a>

## 📂 Organização dos arquivos

Nas aulas **02 e 04 a 10**, os exercícios ficam separados por linguagem. Cada atividade em C# possui seu próprio projeto e, em C++, cada arquivo representa um programa independente.

As aulas **01 e 03** mantêm os arquivos C++ e os projetos C# diretamente na pasta da aula. Na **aula 11**, os scripts Python ficam diretamente em `Aula11/`.

```text
Aula10/
├── C#/
│   ├── exercicio01/
│   │   ├── Program.cs
│   │   └── exercicio01.csproj
│   └── ...
└── C++/
    ├── exercicio01.cpp
    └── ...
```

---

<a id="execucao"></a>

## ▶️ Como executar

Os exemplos utilizam **PowerShell no Windows** e devem ser executados a partir da **raiz do repositório**.

### 🧰 Prepare o ambiente

Instale as ferramentas correspondentes à linguagem que deseja utilizar:

| Linguagem | Ferramenta necessária |
| :--- | :--- |
| **C++** | Compilador `g++` com suporte a C++17 |
| **C#** | SDK do .NET 9 — os projetos utilizam `net9.0` |
| **Python** | Python 3 com o módulo `sqlite3` |

O módulo `sqlite3` integra a biblioteca padrão do Python. Não é necessário instalar pacotes com `pip` nem configurar um servidor de banco de dados.

### 📥 Obtenha o repositório

```powershell
git clone https://github.com/iury-igd1/LPR_2k26.git
cd LPR_2k26
```

### 💻 Escolha uma linguagem

<details open>
<summary><strong>C++ — compilar e executar</strong></summary>

<br>

Exemplo com o exercício de **Minecraft Dungeons**:

```powershell
g++ -std=c++17 "Aula10/C++/exercicio04.cpp" -o "exercicio04.exe"
.\exercicio04.exe
```

Cada arquivo `.cpp` possui seu próprio programa principal. Compile **um exercício por vez**.

</details>

<br>

<details>
<summary><strong>C# — executar o projeto</strong></summary>

<br>

Para executar a versão em C# do mesmo exercício:

```powershell
dotnet run --project "Aula10/C#/exercicio04/exercicio04.csproj"
```

Para escolher outra atividade, altere a aula e o número do exercício no caminho.

</details>

<br>

<details>
<summary><strong>Python e SQLite — preparar o banco e executar</strong></summary>

<br>

**1. Prepare o banco**

Se `Aula11/marvel.db` ainda não existir, execute uma vez:

```powershell
python "Aula11/criacao-db.py"
```

**2. Execute um exercício**

Exemplo com a consulta de heróis e equipes:

```powershell
python "Aula11/exercicio05.py"
```

**3. Observe a persistência dos dados**

Os exercícios compartilham o mesmo banco. Alterações realizadas por um exercício permanecem disponíveis nas próximas execuções.

> [!IMPORTANT]
> Execute o script de criação somente uma vez para cada banco novo. Reexecutá-lo sobre um banco preenchido repete inserções e pode gerar duplicações e conflitos.

Para recomeçar a prática com os dados iniciais, remova o arquivo local `Aula11/marvel.db` e execute novamente `criacao-db.py`.

</details>

<br>

> [!NOTE]
> Alguns programas utilizam comandos de limpeza de tela próprios do Windows. Em outros sistemas, esses comandos podem precisar de adaptação.

---

## 🧩 Conceitos praticados

| Área | Aplicação nos exercícios |
| :--- | :--- |
| 🧮 **Lógica de programação** | Entrada, processamento, saída e operações aritméticas |
| 🔀 **Controle de fluxo** | Condições, seleção de opções e laços de repetição |
| 🛠️ **Modularização** | Divisão dos programas em funções |
| 🗂️ **Estruturas de dados** | Vetores, matrizes, structs, listas e dicionários |
| 🧱 **Orientação a objetos** | Classes, atributos, métodos e relacionamentos |
| 🗃️ **Banco de dados** | Consultas, atualizações e associação de tabelas com SQL |
| 🔎 **Comparação entre linguagens** | Resolução dos mesmos exercícios em C++ e C# |
| 🌿 **Versionamento** | Organização do código com Git e GitHub |

As soluções mantêm uma abordagem didática, acompanhando os conteúdos apresentados em aula. Os enunciados e os comentários podem ser consultados diretamente nos arquivos de código.

---

<a id="autor"></a>

## 👤 Autor

**Iury Gonçalves de Souza**  
Curso Técnico em Desenvolvimento de Sistemas · **ETE FMC** · **2026**

<p>
<a href="https://github.com/iury-igd1">
<img src="https://img.shields.io/badge/GitHub-iury--igd1-181717?style=for-the-badge&logo=github&logoColor=white" alt="Perfil de Iury no GitHub">
</a>
</p>

<div align="center">

<sub>Linguagem de Programação · Repositório acadêmico · ETE FMC</sub>

</div>

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0F172A,100:2563EB&height=90&section=footer" alt="" width="100%">