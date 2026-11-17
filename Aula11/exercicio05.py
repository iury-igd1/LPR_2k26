"""
Exercício 05:
    Crie uma consulta para:
      - Consultar o nome de cada herói e sua equipe utilizando JOIN.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== HERÓIS E SUAS EQUIPES ===\n")

# Une as tabelas usando a associação entre herói e equipe
cursor.execute("""
    SELECT Heroi.nome, Equipe.nome
    FROM Heroi
    JOIN Heroi_Equipe ON Heroi.id = Heroi_Equipe.heroi_id
    JOIN Equipe ON Equipe.id = Heroi_Equipe.equipe_id
""")
associacoes = cursor.fetchall() # Recupera os pares formados pelo nome do herói e pelo nome da equipe

for associacao in associacoes:
    print(associacao)

conexao.close() # Fecha a conexão após concluir as operações
