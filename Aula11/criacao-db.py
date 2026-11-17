"""
Prática - SQL na prática: Banco de dados de heróis
    Objetivo: criar e gerenciar um banco de dados relacional utilizando comandos SQL.

    Neste exercício, vamos utilizar o SQLite, um sistema de banco de dados relacional que funciona sem a 
    necessidade de instalar ou configurar um servidor. O foco é compreender e executar comandos SQL.
"""

import os

os.system('cls')
print("========================")
print("   PRÁTICA COM SQLITE   ")
print("========================")
# ----------------------------------
# ETAPA 1 - Criando o banco de dados
# ----------------------------------

import sqlite3 # Importa a biblioteca sqlite3, que permite trabalhar com bancos SQLite

# Muda o diretório atual para a pasta onde o script está
os.chdir(os.path.dirname(__file__))
# Cria (ou abre, se já existir) o arquivo do banco de dados
conexao = sqlite3.connect("marvel.db")
# Cria um cursor: objeto utilizado para executar comandos SQL
cursor = conexao.cursor()

# ----------------------------------
# ETAPA 2 - Criando uma tabela
# ----------------------------------

# Cria a tabela Heroi
cursor.execute("""
    CREATE TABLE IF NOT EXISTS Heroi (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT NOT NULL,
        identidade TEXT,
        universo TEXT,
        nivel_poder INTEGER
    );
""")

# Confirma as alterações no banco
conexao.commit()

# ----------------------------------
# ETAPA 3 - Inserindo registros
# ----------------------------------

# Insere cinco heróis na tabela
herois = [
    ("Homem de Ferro", "Tony Stark", "Marvel", 95),
    ("Homem-Aranha", "Peter Parker", "Marvel", 85),
    ("Capitão América", "Steve Rogers", "Marvel", 80),
    ("Thor", "Thor Odinson", "Marvel", 100),
    ("Hulk", "Bruce Banner", "Marvel", 98)
]

# Executa a mesma inserção para cada tupla da coleção de heróis
cursor.executemany(
    """
        INSERT INTO Heroi (nome, identidade, universo, nivel_poder)
        VALUES (?, ?, ?, ?);
    """,
    herois
)

# Confirma as alterações no banco
conexao.commit()

# ----------------------------------
# ETAPA 4 - Consultando os registros
# ----------------------------------

# Consulta todos os registros da tabela Heroi
cursor.execute("SELECT * FROM Heroi;")
# fetchall() retorna todos os resultados da consulta
resultado = cursor.fetchall()

# Exibe os registros retornados
print("\nEtapa 4 - Consultando todos os registros:")
for linha in resultado:
    print(linha)

# Consulta apenas o nome e a identidade de cada herói
cursor.execute("SELECT nome, identidade FROM Heroi;")
resultado = cursor.fetchall()

print("\nEtapa 4 - Consultando registros específicos:")
for linha in resultado:
    print(linha)

# ----------------------------------
# ETAPA 5 - Filtrando e ordenando resultados
# ----------------------------------

# Heróis cujo nivel_poder seja maior ou igual a 90
cursor.execute("""
    SELECT *
    FROM Heroi
    WHERE nivel_poder >= 90;
""")

print("\nEtapa 5 - Heróis com poder maior ou igual a 90:")
for linha in cursor.fetchall():
    print(linha)

# Nome e nivel_poder de todos os heróis, ordenados do maior para o menor nivel_poder
cursor.execute("""
    SELECT nome, nivel_poder FROM Heroi
    ORDER BY nivel_poder DESC;
""")

print("\nEtapa 5 - Heróis ordenados em ordem decrescente de poder:")
for linha in cursor.fetchall():
    print(linha)

# ----------------------------------
# ETAPA 6 - Atualizando registros
# ----------------------------------

# Atualiza para 90 o nível de poder do Homem-Aranha
cursor.execute("""
    UPDATE Heroi
    SET nivel_poder = 90
    WHERE nome = 'Homem-Aranha';
""")

conexao.commit()

# Confira se a atualização ocorreu
cursor.execute("SELECT nome, nivel_poder FROM Heroi;")

print("\nEtapa 6 - Registro atualizado para Homem-Aranha:")
for linha in cursor.fetchall():
    print(linha)

# ----------------------------------
# ETAPA 7 - Excluindo registros
# ----------------------------------

# Exemplo: remover o Capitão América da tabela
cursor.execute("""
    DELETE FROM Heroi
    WHERE nome = 'Capitão América';
""")

conexao.commit()

# Confira os registros restantes
cursor.execute("SELECT * FROM Heroi;")

print("\nEtapa 7 - Capitão América removido da tabela:")
for linha in cursor.fetchall():
    print(linha)

# ----------------------------------
# ETAPA 8 - Criando uma segunda tabela
# ----------------------------------

# Cria a tabela Equipe
cursor.execute("""
    CREATE TABLE IF NOT EXISTS Equipe (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT NOT NULL
    );
""")

# Insere algumas equipes
cursor.executemany(
    "INSERT INTO Equipe (nome) VALUES (?);",
    [
        ("Vingadores",),
        ("Defensores",),
        ("Guardiões da Galáxia",)
    ]
)

conexao.commit()

# Consulta as equipes cadastradas
cursor.execute("SELECT * FROM Equipe;")

print("\nEtapa 8 - Criação da tabela Equipe:")
for linha in cursor.fetchall():
    print(linha)

# ----------------------------------
# ETAPA 9 - Relacionando tabelas
# ----------------------------------

# Habilita a verificação de chaves estrangeiras 
cursor.execute("PRAGMA foreign_keys = ON;")

# Cria uma nova tabela de relacionamento
# Cada registro associa um herói a uma equipe
cursor.execute("""
    CREATE TABLE IF NOT EXISTS Heroi_Equipe (
        heroi_id INTEGER,
        equipe_id INTEGER,
        PRIMARY KEY (heroi_id, equipe_id), 
        FOREIGN KEY (heroi_id) REFERENCES Heroi(id),
        FOREIGN KEY (equipe_id) REFERENCES Equipe(id)
    );
""")

conexao.commit()

# Primeiro, consultamos os IDs para conferir os valores disponíveis
cursor.execute("SELECT id, nome FROM Heroi;")
print("\nEtapa 9 - id dos Heróis:")
for linha in cursor.fetchall():
    print(linha)

cursor.execute("SELECT id, nome FROM Equipe;")
print("\nEtapa 9 - id das Equipes:")
for linha in cursor.fetchall():
    print(linha)

# Homem de Ferro (id 1) -> Vingadores (id 1)
# Homem-Aranha (id 2) -> Defensores (id 2)
# Thor (id 4) -> Vingadores (id 1)
# Hulk (id 5) -> Vingadores (id 1)

cursor.executemany("""
    INSERT INTO Heroi_Equipe (heroi_id, equipe_id)
    VALUES (?, ?);
""", [
    (1, 1),
    (2, 2),
    (4, 1),
    (5, 1)
])

# Confirma as inserções no banco
conexao.commit()

# Consulta as relações cadastradas
cursor.execute("""
SELECT * FROM Heroi_Equipe;
""")

print("\nEtapa 9 - Heróis e Equipes associadas:")
for linha in cursor.fetchall():
    print(linha)

# Mostra o nome do herói e o nome da equipe
cursor.execute("""
    SELECT Heroi.nome, Equipe.nome
    FROM Heroi
    JOIN Heroi_Equipe ON Heroi.id = Heroi_Equipe.heroi_id
    JOIN Equipe ON Equipe.id = Heroi_Equipe.equipe_id;
""")

print("\nEtapa 9 - Nomes dos Heróis e suas respectivas Equipes:")
for linha in cursor.fetchall():
    print(linha)

# Fecha a conexão com o banco de dados
conexao.close()
print("\nFim dos registros.")
