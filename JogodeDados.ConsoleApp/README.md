# Jogo de Dados Lageano
![](https://i.imgur.com/pOGZqKp.gif)

Este � um jogo de dados simples onde um jogador e o computador competem para alcan�ar a �ltima casa de um tabuleiro, rolando dados em cada rodada. Durante o jogo, tanto o jogador quanto o computador podem ser afetados por eventos especiais que podem fazer com que avancem ou recuem no tabuleiro.

# Funcionalidades
### Jogador e Computador:
O jogo envolve dois participantes, o jogador e o computador, onde ambos rolam dados para avan�ar no tabuleiro.

### Eventos Especiais:
Existem casas no tabuleiro que, quando atingidas, acionam eventos especiais:

#### Avan�o extra de 3 casas.
#### Recuo de 2 casas.

### Exibi��o de Progresso:
As posi��es do jogador e do computador s�o exibidas a todo momento, garantindo que o usu�rio possa acompanhar o andamento do jogo.

### Reiniciar o Jogo:
O usu�rio pode decidir se quer jogar novamente ap�s o t�rmino de uma rodada.
Como Jogar
O jogo come�a pedindo para o jogador pressionar "ENTER" para rolar os dados.
O jogador joga os dados, e o resultado � somado � sua posi��o no tabuleiro.
O computador faz a mesma coisa, jogando os dados e somando o resultado � sua posi��o.
Quando um jogador (ou o computador) chega na �ltima casa (casa n�mero 30), o jogo termina.
Se o jogador ou computador atingirem casas com eventos especiais, o comportamento ser� alterado:
Avan�o extra de 3 casas: O jogador/CPU avan�a 3 casas extras.
Recuo de 2 casas: O jogador/CPU recua 2 casas.
O jogo oferece a op��o de jogar novamente ap�s o t�rmino de cada partida.
Tecnologias Utilizadas
Linguagem: C#
Plataforma: Console

# Como Rodar o Projeto

Clone o Reposit�rio
```
git clone https://github.com/xleonardoxmed/JogodeDados.git
```
Navegue at� a pasta raiz da solu��o
```
cd JogodeDados
```
Restaure as depend�ncias
```
dotnet restore
```
Navegue at� a pasta do projeto
```
cd JogodeDados.ConsoleApp
```
Execute o projeto
```
dotnet run
```
