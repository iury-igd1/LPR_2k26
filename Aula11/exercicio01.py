"""
Exercício 01:
    Crie uma consulta para:
      - Exibir somente os heróis com nível de poder inferior a 90.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== HERÓIS COM PODER ABAIXO DE 90 ===\n")

# Consulta somente os heróis com nível de poder inferior a 90
cursor.execute("""
    SELECT *
    FROM Heroi
    WHERE nivel_poder < 90;
""")
herois = cursor.fetchall() # Recupera todos os registros retornados pela consulta

if len(herois) == 0:
    print("Nenhum herói encontrado.")
else:
    for heroi in herois:
        print(heroi)

conexao.close() # Fecha a conexão após concluir as operações
