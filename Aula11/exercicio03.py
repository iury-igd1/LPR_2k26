"""
Exercício 03:
    Crie uma consulta para:
      - Exibir os heróis em ordem alfabética.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== HERÓIS EM ORDEM ALFABÉTICA ===\n")

# Ordena os registros pelo nome do herói
cursor.execute("""
    SELECT *
    FROM Heroi
    ORDER BY nome ASC
""")
herois = cursor.fetchall() # Recupera os heróis na ordem definida pela consulta

for heroi in herois:
    print(heroi)

conexao.close() # Fecha a conexão após concluir as operações
