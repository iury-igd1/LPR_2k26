"""
Exercício 04:
    Crie uma consulta para:
      - Aumentar em 5 pontos o nível de poder de um herói específico.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== AUMENTO DO NÍVEL DE PODER ===\n")

nome = input("> Digite o nome do herói para aumentar o poder: ")

# Acrescenta 5 ao poder atual e salva a alteração no banco
cursor.execute("""
    UPDATE Heroi
    SET nivel_poder = nivel_poder + 5
    WHERE nome = ?
""", (nome,))
conexao.commit()

# Consulta o herói para mostrar o valor atualizado
cursor.execute("""
    SELECT *
    FROM Heroi
    WHERE nome = ?
""", (nome,)) # A vírgula em (nome,) cria uma tupla com um único parâmetro
herois = cursor.fetchall() # Recupera os dados do herói após a atualização

if len(herois) == 0:
    print("\nHerói não encontrado.")
else:
    for heroi in herois:
        print("\n", heroi)

conexao.close() # Fecha a conexão após concluir as operações
