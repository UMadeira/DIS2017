# Desenho e Implementação de Software 2017/2018 (DIS2017)

Neste projeto será incluído as versões (quase) completas do código em C# analisado e discutidos nas aulas. 

## Exercícios

1. Escreva um programa em C# que leia 10 números inteiros a partir do teclado e escreva no ecrã a soma e a média dessa sequência de entrada.

    [Exercise1](https://github.com/UMadeira/DIS2017/blob/develop/Exercise1/Program.cs)

2. Escreva um programa em C# que leia uma sequência de 10 inteiros e escreva no ecrã a sequência de entrada por ordem inversa.

    [Exercise2](https://github.com/UMadeira/DIS2017/blob/develop/Exercise2/Program.cs)
    
3. Escreva um programa em C# que calcule o máximo divisor comum entre dois naturais.
    
    [Exercise3](https://github.com/UMadeira/DIS2017/blob/develop/Exercise3/Program.cs)

4. Escreva um programa em C# que leia um ficheiro de texto e escreva o conteúdo desse ficheiro no ecrã sem espaços ou mudanças de linha e utilizando somente maiúsculas.

    [Exercise4](https://github.com/UMadeira/DIS2017/blob/develop/Exercise4/Program.cs)

5. Escreva um programa em C# que identifique e calcule a área das figuras descrita num ficheiro de dados com o seguinte formato:

    a) x1,y1,x2,y2,x3,y3,x4,y4
    b) x1,y1,x2,y2,x3,y3
    c) x1,y1,x2,y2
    d) x1,y1,r1 

     onde

         a) corresponde a um retângulo
         b) corresponde a um triângulo
         c) corresponde a um quadrado
         d) corresponde a um círculo

     Implemente um algoritmo de identificação e validação dos dados.

    [Exercise5](https://github.com/UMadeira/DIS2017/blob/develop/Exercise5)

## Exemplos

a. **Rick's Guitar Shop**

    Exemplo baseado no livro [Head First Object-Oriented Analysis & Design](http://www.headfirstlabs.com/books/hfooad/) com o intuito de rever alguns fundamentos de análise e desenho de software.

    > [RickGuitarShop1](https://github.com/UMadeira/DIS2017/tree/develop/RickGuitarShop1)  
    > Solução inicial e elementar para o problema, com recurso a strings para denotar os valores dos atributos utilizados. Esta solução possui vários problemas de desenho e serve só como ponto de partida.   
    
    > [RickGuitarShop2](https://github.com/UMadeira/DIS2017/tree/develop/RickGuitarShop2)  
    > Utilização de enumerados em vez de strings, minimizando os erros na definição das características da guitarra pretendida.  
    > Problemas:   
    > (1) Utilização da classe Guitar como parâmetro do método de pesquisa da classe Inventory (violação do princípio da responsabilidade única).  
    > (2) O método SearchGuitar só retorna uma única guitarra.
    
    > [RickGuitarShop3](https://github.com/UMadeira/DIS2017/tree/develop/RickGuitarShop3)  
    > Introdução da classe GuitarSpec para isolar os aspectos que variam dos que são constantes e utilização desta classe na pesquisa. 
    > A pesquisa retorna o conjunto de guitarras que satisfazem a pretendida especificação (GuitarSpec).  
    > Problemas:  
    > (1) O método SearchGuitar não adere ao princípio do aberto/fechado (novos atributos);   
    > (2) Não suporta várias tipos de instrumentos. 

    > [RickGuitarShop4](https://github.com/UMadeira/DIS2017/tree/develop/RickGuitarShop4)  
    > Introdução da classe GuitarSpec para isolar os aspectos que variam dos que são constantes e utilização desta classe na pesquisa.
 


b. **Starbuzz** - Ultimate Coffee and Tea Maker
c. **Starbuzz Vending Machine** 