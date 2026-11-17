"""
Exercício 07:
    Crie uma consulta para:
      - Exibir o maior e o menor nível de poder registrado.
"""

import os
import sqlite3

# Usa a pasta do script para localizar o banco de dados
os.chdir(os.path.dirname(__file__))

# Abre o banco existente e cria o cursor utilizado para executar os comandos SQL
conexao = sqlite3.connect("marvel.db")
cursor = conexao.cursor()

os.system('cls')
print("=== MAIOR E MENOR NÍVEL DE PODER ===\n")

# Consulta o maior e o menor nível de poder cadastrados
cursor.execute("""
    SELECT MAX(nivel_poder), MIN(nivel_poder) 
    FROM Heroi
""")
poderes = cursor.fetchone() # Obtém uma linha com dois valores: maior poder na posição 0 e menor na posição 1

print("Maior nível de poder =", poderes[0])
print("Menor nível de poder =", poderes[1])

conexao.close() # Fecha a conexão após concluir as operações
