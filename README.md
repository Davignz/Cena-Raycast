## Conteúdo

* [Descrição](#descricao)
* [Sobre o Projeto](#sobre-o-projeto)
* [Autores](#autores)

# Cena Unity - Jogo com Raycast e Iluminação

![Cena](https://github.com/Davignz/Cena-Raycast/assets/72495823/eaa87bec-a7da-4cef-94fe-c240c6dc2668)

## Descrição

Esta cena Unity foi criada para fazer o uso dos conceitos de raycast e iluminação em um jogo. Nela, temos um player e um inimigo que o persegue. A cena também apresenta um ambiente com um galpão contendo um cubo giratório, onde foram aplicados efeitos de pós-processamento de Bloom, tanto no cubo quanto na lâmpada.

## Sobre o Projeto

### Ambiente

O ambiente foi feito de forma básica, com um plano sendo o chão, o céu escuro e uma névoa de fundo. Além disso, há um galpão com luzes de emergência, além de um cubo giratório dentro dele.

![Cena](https://github.com/Davignz/Cena-Raycast/assets/72495823/eaa87bec-a7da-4cef-94fe-c240c6dc2668)

![Galpao](https://github.com/Davignz/Cena-Raycast/assets/72495823/6779d96e-2f6c-485e-89bc-a85c860582fc)


### Prefabs

Existem três prefabs no jogo: A munição, o Player e o Inimigo. Os prefabs do Player e do Inimigo possuem semelhanças, como ter o corpo em formato de cápsula, uma "viseira" e uma "arma". O prefab da munição é uma simples esfera com textura.

![Player](https://github.com/Davignz/Cena-Raycast/assets/72495823/e454f302-c1f5-44da-848e-d9d536b279b9)

![Inimigo](https://github.com/Davignz/Cena-Raycast/assets/72495823/81e94909-de48-4b5d-9148-99291fda410c)

![Municao](https://github.com/Davignz/Cena-Raycast/assets/72495823/56713f56-3c1f-42e1-947d-2a090eac6720)

### Materiais

Na cena há alguns materiais que deram vida aos elementos. Algum deles possuem emissão de cor, como as lâmpadas, o cubo e munição.

![Materiais](https://github.com/Davignz/Cena-Raycast/assets/72495823/69949347-d9e2-4c9e-be10-743e540eb2e3)

### Animação

Nas luzes há uma simples animação de "piscar", enfatizando ainda mais a "emergência" do player.

![Animacao](https://github.com/Davignz/Cena-Raycast/assets/72495823/288388a7-bbe7-4908-81c0-28a5a6711cd5)



### Pós-Processamento

Para dar um efeito visual melhor, existem dois perfis de pós processamento, um original da cena e outro para dar o efeito de bloom nos itens.

![PosProc](https://github.com/Davignz/Cena-Raycast/assets/72495823/8b93958a-33b8-4340-a502-5ed6d7af5a94)

### Códigos

Os códigos compõem a parte mais importante da cena, dando toda a funcionalidade para o jogo. Os scripts essenciais são a movimentação do player, a "mira" (raycast), o gerador de inimigos e as funcionalidades da arma e da munição. 

![Codigos](https://github.com/Davignz/Cena-Raycast/assets/72495823/f58e94f8-3b48-4e09-89ca-a636816c226a)

* Mira <br>
 A mira é um código simples de raycast, nele foi adicionado a funcionalidade de quando o Player mirar no inimigo, o raio da mira se exibe na cor vermelha e, caso não mire em nada, o raio se exibe na cor verde. Além disso, foi adicionado um Debug.Log para mostrar quando o jogador acerta ou não o alvo.

![MiraVerde](https://github.com/Davignz/Cena-Raycast/assets/72495823/5ac34062-280a-4547-b047-d057781c7ab4)

![Acertou](https://github.com/Davignz/Cena-Raycast/assets/72495823/5b3d3738-0f30-4ae5-992a-f9d430b14b5e)

![MiraVerm](https://github.com/Davignz/Cena-Raycast/assets/72495823/88f8556a-4ddc-4ff7-8a1c-48db3b441e63)

![NAcertou](https://github.com/Davignz/Cena-Raycast/assets/72495823/a0b779ea-de16-4f1d-a129-0086ede46fe3)

* Gerar Inimigos <br>
  Para gerar inimigos, pegamos o prefab do inimigo e adicionamos um simples código para aparecerem clones dele na cena. Determinamos o prefab a ser gerado e a posição aleatória em que eles apareceriam. Tudo isso dentro de um loop for, gerando 10 inimigos adicionais.

![GerarInimigo](https://github.com/Davignz/Cena-Raycast/assets/72495823/65e6d210-a671-42fd-b7d7-deb9e758123f)

![CloneInimigo](https://github.com/Davignz/Cena-Raycast/assets/72495823/ca9b0467-abcd-497a-9e8e-36ba22b45411)

* Seguir Player <br>
Para seguir o player, definimos o alvo do inimigo, que seria o prefab do player. Após isso adicionamos a função LookAt() que tem como parâmetro o alvo, isso faz com que o inimigo esteja constantemente olhando para o player. Para andar na direção em que o jogador está, adicionamos a função do Vector3 - MoveTowards() - pegando a posição do alvo. Tudo isso dentro do Void Update, carregando frame a frame estas funcionalidades. 

![SeguirPlayer](https://github.com/Davignz/Cena-Raycast/assets/72495823/524d6a12-7eb9-41e8-862d-9f59de0ab4e7)

* Atirar <br>
  Para atirar as munições, adicionamos um código que "pegava" o ponto de spawn da munição, a velocidade dela e o prefab. No Void Update é adicionado o código para ativar o método criado para atirar, acionado quando o botao esquerdo do mouse é ativado. No método void ShootingBullet() ele instancia o prefab da munição e adiciona um RigidBody para ter contato com a superfície do inimigo. 
  
  ![Atirar](https://github.com/Davignz/Cena-Raycast/assets/72495823/164d9fc3-0325-46ad-a4db-45ef15f221d6)


* Rotacionar Cubo <br>
  A rotação do cubo funciona de forma simples: adicionamos apenas um transform.Rotate() no void Update.
  
  ![RotacionaCubo](https://github.com/Davignz/Cena-Raycast/assets/72495823/c493df79-b585-46b3-af7d-3c7fc032b17d)


## Autores

Davi Gonzaga - 3º Jogos Digitais - [@davignz](https://github.com/Davignz) </br>
Pedro Guilherme - 3º Jogos Digitais - [@pedroribeiro07](https://github.com/pedroribeiro07)
