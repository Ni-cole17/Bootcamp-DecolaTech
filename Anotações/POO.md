# Programação Orientada a Objetos
 É um dos tipos paradigmas de programação, visto que é uma técnica utilizada para a solução de um problema. Cada linguagem, contempla uma dessas técnicas, por isso que existem
 várias linguagens e cada uma delas tem seu foco em resolver certo tipo de problema, como: Python para dados, C# para jogos, JavaScript para web e assim por diante.
 Falando um pouco mais do paradigma abordado no curso, a POO tem 4 pilares, listados abaixo, e seus principais conceitos são Classes e Objetos nos quais, 
 o primeiro é visto como uma forma de definir dados e "comportamentos" que vão ser utilizados pelo segundo, os Objetos.
 Exemplo: Informações do tipo (nome, idade, altura, ....) são dados gerais de uma pessoa, certo?. Logo podemos considerar que uma pessoa é um Objeto e suas informações pertencem
 a sua classe de definição.
#### Pilares da POO:
 - Abstração
 - Encapsulamento
 - Herança
 - Polimorfismo
  

## Abstração
O conceito de Abstração já foi exemplificado acima, é uma forma de trazer um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.
Isto é, se estou em um parque de diversões e preciso de uma certa altura para entrar, a única informação importante para aquele contexto é a minha altura, já se estou de recuperação
em um contexto escolar, a única informação importante são minhas notas, mesmo que o Objeto "eu" seja o mesmo nas duas situações, são exploradas diferentes características minhas e
isso acontece da mesma forma na Programação a Objetos, onde são divididos em Classes e Objetos, como já comentado acima.
#### Exemplo de declaração de uma classe:
public void nome_da_clase()
{
 
}
#### Exemplo de declaração de um objeto da classe acima:
nome_da_classe nome_do_objeto = new nome_da_classe();

## Encapsulamento

A utilização de um encapsulamento consegue proteger as propriedades de uma classe de sofrer alterações quando não são desejadas ou permitidas, logo ele consegue definir limites
para as alterações ou ocultar certos comportamentos, permitindo ser alterado somente o necessário.

## Herança 

A Herança é uma forma, digamos assim, de reaproveitamento de código, visto que a sua utilização nos permite reutilizar atributos, métodos ou outros comportamentos de uma classe
em outras classes, sem precisar escrever novamente o código. Assim, ela serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.
Por exemplo: Novamente no contexto escolar, um aluno possui: Nome, idade, endereço e notas, já um professor possui, nome, idade, endereço e salário. Pode-se ver no exemplo anterior
que o Aluno e o professor possuem algumas características semelhantes, visto que são "objetos - pessoa", ao escrever isso em um código, seria interessante para não repetir o mesmo
código, criar uma classe pessoa com todas as informações iguais entre as pessoas, e as classes alunos e professores herdarem essas características da classe pessoa.

## Polimorfismo

O polimorfismo vem do grego e significa “muitas formas”. Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente
e ter sua própria implementação. O polimorfismo pode se apresentar de duas formas o polimorfismo em tempo de compilação e o polimorfismo em tempo de execução.
#### Polimorfismo em tempo de compilação:
Um método somar, por exemplo, pode somar uma quantidade n de atributos, dependendo de como for declarado. No entando ambas tem o mesmo princípio, visto que o que diferencia um
método somar de outro são as quantidades de atributos declarados. Portanto, se caso declarar um método que soma 2 números e um que soma 3, ao chamar esse método, se eu colocar apenas
2 números, ele identifica automaticamente qual método utilizar, mesmo que ambos tenham o mesmo nome.
#### Polimorfismo em tempo de execução:
Já esse outro tipo de polimorfismo permite que métodos de uma classe mãe sejam "reaproveitados" e modificados dentro das classes filhas, de acordo com a necessidade.


## Classes Abstratas

## Interfaces

## Manipulação de Arquivos
