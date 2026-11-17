"""
Exercício 02:
    Crie uma consulta para:
      - Buscar um herói pelo nome.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== BUSCA DE HERÓI PELO NOME ===\n")

nome = input("> Digite o nome do herói: ")

# O ponto de interrogação recebe o nome informado pelo usuário
cursor.execute("""
    SELECT *
    FROM Heroi
    WHERE nome = ?
""", (nome,)) # A vírgula em (nome,) cria uma tupla com um único parâmetro
herois = cursor.fetchall() # Recupera os registros encontrados para o nome informado

if len(herois) == 0:
    print("\nHerói não encontrado.")
else:
    for heroi in herois:
        print("\n", heroi)

conexao.close() # Fecha a conexão após concluir as operações
