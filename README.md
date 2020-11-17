# Console .NET Game Application
Infelizmente o projeto ainda está incompleto. Quando eu for capaz de programar bem, venho-o terminar.

![Sad cat](https://i.imgur.com/0Togsm0.png)

[Clique aqui](https://hastebin.com/imucayuhuh.yaml) para ver a meta final do projeto.

## Autor

* **Bernardo Medeiros** - [BsouzaM Github](https://github.com/BsouzaM).
  * *Desenvolvimento do projeto e relatório*;
  * *Identação e comentários das partes do código*;
  * *Realizou os commits no GitBash*;
  * *Desenvolvimento do diagrama UML*;
  * *Desenvolvimento do fluxograma*.

## Descrição da solução

Um jogo roguelike em C# (.NET Core console app) com níveis em grelha gerados procedimentalmente e com vários graus de dificuldade. O jogador começa no lado esquerdo da grelha (1ª coluna), e o seu objetivo é encontrar a saída do nível, que se encontra do lado direito dessa mesma grelha (última coluna). Pelo meio o jogador pode encontrar inimigos, encontrar itens (comida, armas, mapas) e cair em armadilhas.

**Arquitetura da solução**
* O projeto é organizado com o objetivo em usar vários métodos e evitar de muitas linhas de código em cada classe. Para desenvolver o jogo, cada classe chama um método específico para fazer sua função, por exemplo na classe WriteLines, onde há todos os textos do jogo e estão definidos por vários métodos.
* Para fazer o algoritmo de construir a grelha de jogo foram utilizados dois "For Loops" que geram o mapa de acordo com a decisão do utilizador.

**Diagrama UML**
* [Clique aqui para ver o Diagrama UML](https://imgur.com/a/YATHNfq)

**Fluxograma do jogo**
* [Clique aqui para ver o Fluxograma](https://imgur.com/a/WhNXiUe)

**Referências**

[[1]](https://www.youtube.com/watch?v=-V_vHZPOZfY), [[2]](https://www.youtube.com/watch?v=UI6lqHOVHic), [[3]](https://www.youtube.com/watch?v=2dSq0Vu1GFo), [[4]](https://www.youtube.com/watch?v=wfWxdh-_k_4), [[5]](https://www.youtube.com/watch?v=GhQdlIFylQ8), [[6]](https://stackoverflow.com/a/17201334), [[7]](https://stackoverflow.com/a/8868363), [[8]](https://stackoverflow.com/a/19732384), [[9]](https://stackoverflow.com/a/17912035) e [[10]](https://stackoverflow.com/a/46144705).

## Linguagem

* **C#** - Linguagem de programação obrigatória para o projeto.

## Licença

Acesse LICENSE para mais informações.
