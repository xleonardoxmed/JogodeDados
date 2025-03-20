# Jogo de Dados Lageano
![](https://i.imgur.com/pOGZqKp.gif)

Este é um jogo de dados simples onde um jogador e o computador competem para alcançar a última casa de um tabuleiro, rolando dados em cada rodada. Durante o jogo, tanto o jogador quanto o computador podem ser afetados por eventos especiais que podem fazer com que avancem ou recuem no tabuleiro.

# Funcionalidades
### Jogador e Computador:
O jogo envolve dois participantes, o jogador e o computador, onde ambos rolam dados para avançar no tabuleiro.

### Eventos Especiais:
Existem casas no tabuleiro que, quando atingidas, acionam eventos especiais:

#### Avanço extra de 3 casas.
#### Recuo de 2 casas.

### Exibição de Progresso:
As posições do jogador e do computador são exibidas a todo momento, garantindo que o usuário possa acompanhar o andamento do jogo.

### Reiniciar o Jogo:
O usuário pode decidir se quer jogar novamente após o término de uma rodada.
Como Jogar
O jogo começa pedindo para o jogador pressionar "ENTER" para rolar os dados.
O jogador joga os dados, e o resultado é somado à sua posição no tabuleiro.
O computador faz a mesma coisa, jogando os dados e somando o resultado à sua posição.
Quando um jogador (ou o computador) chega na última casa (casa número 30), o jogo termina.
Se o jogador ou computador atingirem casas com eventos especiais, o comportamento será alterado:
Avanço extra de 3 casas: O jogador/CPU avança 3 casas extras.
Recuo de 2 casas: O jogador/CPU recua 2 casas.
O jogo oferece a opção de jogar novamente após o término de cada partida.
Tecnologias Utilizadas
Linguagem: C#
Plataforma: Console

# Como Rodar o Projeto

Clone o Repositório
```
git clone https://github.com/xleonardoxmed/JogodeDados.git
```
Navegue até a pasta raiz da solução
```
cd JogodeDados
```
Restaure as dependências
```
dotnet restore
```
Navegue até a pasta do projeto
```
cd JogodeDados.ConsoleApp
```
Execute o projeto
```
dotnet run
```
