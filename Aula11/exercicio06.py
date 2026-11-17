"""
Exercício 06:
    Crie uma consulta para:
      - Contar quantos heróis estão cadastrados na tabela.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== QUANTIDADE DE HERÓIS ===\n")

# COUNT conta quantos registros existem na tabela Heroi
cursor.execute("""
    SELECT COUNT(*) 
    FROM Heroi
""")
quantidade = cursor.fetchone()[0] # Obtém a primeira coluna da única linha retornada pela contagem

print("Total de heróis:", quantidade)

conexao.close() # Fecha a conexão após concluir as operações
