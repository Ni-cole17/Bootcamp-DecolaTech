using System;
using Colecoes.Helper;
using System.Collections.Generic;

namespace Colecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //OPERAÇÕES LINQ
           int[] arrayNumeros = new int[10] {1,1,4,8,8,15,19,7,100,180};

           var minimo = arrayNumeros.Min();
           var maximo = arrayNumeros.Max();
           var medio = arrayNumeros.Average();

           System.Console.WriteLine($"Mínimo {minimo}, Máximo {maximo}, médio: {medio}");

           //Por sintaxe
           var numerosParesQuery = 
                    from num in arrayNumeros
                    where num % 2 == 0
                    orderby num
                    select num;

           var numerosParesMetodo = arrayNumeros.Where(x => x % 2 ==0).OrderBy(x => x).ToList();
        
           Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
           Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));

            var Soma = arrayNumeros.Sum();
            Console.WriteLine($"Soma: {Soma}");
            var arrayUnico = arrayNumeros.Distinct().ToArray();
            Console.WriteLine($"Array Original: {string.Join(",",arrayNumeros)}");
            Console.WriteLine($"Array Original: {string.Join(",",arrayUnico)}");
           
           /*
           Dictionary<string, string> estados = new Dictionary<string, string>();
           
           estados.Add("CE","Ceará");
           estados.Add("PB","Paraíba");
           estados.Add("BA","Bahia");
           string valorProcurado = "PB";
           Console.WriteLine(estados[valorProcurado]);

           estados[valorProcurado] = "Paraíba - Novo"; // altera o valor correspondente a determinada chave

           Console.WriteLine($"Removendo o valor: {valorProcurado}");

           estados.Remove(valorProcurado); // remove uma determinada chave.
        
            foreach (var item in estados)
             {
               Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
             }

            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine(estadoEncontrado);
            }
            else
            {
                Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            }
           


           
           Stack<string> pilhaLivros = new Stack<string>();

           pilhaLivros.Push(".NET");
           pilhaLivros.Push("DDD");
           pilhaLivros.Push("Código Limpo");

           while(pilhaLivros.Count > 0)
           {
               Console.WriteLine($"Próximo Livro para leitura: {pilhaLivros.Peek()}");
               Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
           }

           Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

           
           
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Leonardo");
            fila.Enqueue("Eduardo");
            fila.Enqueue("André");

            while(fila.Count > 0)
            {
                Console.WriteLine($"Vez de {fila.Peek()}");
                Console.WriteLine($"{fila.Dequeue()} atendido");
            }
                Console.WriteLine($"Pessoas na fila: {fila.Count}");
            */
            /*
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>{"SE","AL","BA"};
            string[] estadosArray = new string[2] {"PI","MA"};
            
            estados.Add("CE");
            estados.Add("PE");
            estados.Add("RN");

            Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");            
            
            opLista.ImprimirListaString(estados);
            //estados.Remove("RN"); //Removendo o elemento
            estados.AddRange(estadosArray);
            opLista.ImprimirListaString(estados);
            estados.Insert(1,"ES");

            //Coleções Arrays         
            OperacoesArrays op = new OperacoesArrays();
            int[] array = new int[5] {6 ,3 ,8 ,1 ,9 };
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParraArrayString(array);


            bool existe = op.Existe(array, 1);
            int valorProcurado = 10;

            bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            
            int valorAchado = op.ObterValor(array, valorProcurado);
            
            int indice = op.ObterIndice(array, valorProcurado);

            Console.WriteLine($"Capacidade atual do array: {array.Length}");
            
            op.RedimensionarArray(ref array, array.Length * 2);

            Console.WriteLine($"Capacidade do array após redimensionar: {array.Length}");

            if (indice > -1)
            {
                Console.WriteLine("O indice do elemento {0} é: {1}",valorProcurado, indice);
            }
            else
            {
                Console.WriteLine("Valor não existente no array");
            }




            if(valorAchado > 0)
            {
                Console.WriteLine("Encontrei o valor");
            }
            else
            {
                Console.WriteLine("Não encontrei o valor");
            }
            
            
            
            
            if(todosMaiorQue)
            {
                Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            }
            else
            {
                Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            }



            if(existe)
            {
                Console.WriteLine($"Encontrei o valor {valorProcurado}");
            }
            else
            {
                Console.WriteLine($"Não encontrei o valor {valorProcurado}");
            }
            Console.WriteLine("Array Original: ");
            op.ImprimirArray(array);

            op.OrdenarBubbleSort(ref array);
            op.Ordenar(ref array);

            Console.WriteLine("Array Ordenado: ");
            op.ImprimirArray(array);



            op.ImprimirArray(arrayCopia);
            op.Copiar(ref array, ref arrayCopia);
            Console.WriteLine("Array após cópia");
            op.ImprimirArray(arrayCopia);



            
            int[,] matriz = new int[4,2]
            {
                {8,8},
                {10,10},
                {5,6},
                {0,0}
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i,j]);
                }
            }

            

            
            
            
            
            
            int[] arrayInteiros = new int[4];

            arrayInteiros[0] = 12;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 60;
            arrayInteiros[3] = int.Parse("59"); //só recebe do mesmo tipo, por isso temos que fazer a conversão.




            foreach(var i in arrayInteiros)
            {
                Console.WriteLine(i);
            }
            */


        }
    }
}