using Dumpify;
using Src;
using System.Linq;

/*
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OLA");    
        }
    }
}
*/


/*
                                    * Diferenca entre IEnumerable e List *
 
 * IEnumerable é uma interface que define um conjunto de membros que permitem iterar sobre uma coleção de objetos.
 Em outras palavras, IEnumerable é uma forma de dizer que um objeto pode ser iterado, ou seja, que você pode
 percorrer seus elementos um a um.

 * List é uma classe concreta que implementa a interface IEnumerable.
 List é uma coleção de objetos que pode ser acessada por índice e que pode ser modificada dinamicamente
 (ou seja, você pode adicionar ou remover elementos).

                      * Aqui estão algumas diferenças importantes entre IEnumerable e List: *

 * IEnumerable não é uma coleção em si, mas sim uma interface que pode ser implementada por várias classes,
 incluindo List, Array, Collection, entre outras.
 * IEnumerable não permite modificar a coleção, enquanto List permite adicionar ou remover elementos dinamicamente.
 
 * List é uma classe concreta que implementa IEnumerable e fornece métodos adicionais para manipular a coleção,
 como Add, Remove, Insert, entre outros. 
  
 */

//<OBS IMPORTANTE>
//Dump -> da lib Dumpify, serve para mostrar o resultado no console, sem precisar usar o Console.WriteLine();
//Ele transforma o resultado em uma tabela bonitinha no console.

IEnumerable<int> IEnumerableNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
List<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

IEnumerable<Pessoa> pessoas = [
    new ("Joao", 20),
    new ("Maria", 30),
    new ("Pedro", 40)
    ];


// * Metodo Where (filtro de elementos) *
IEnumerableNumeros.Where(cadaElementoDaLista => cadaElementoDaLista > 2).Dump(); 
listaNumeros.Where(cadaElementoDaLista => cadaElementoDaLista > 2).Dump(); 

// * Metodo Skip (pula os 5 primeiros) *
IEnumerableNumeros.Skip(5).Dump();

// * Metodo Take (pega os 5 primeiros) *
IEnumerableNumeros.Take(5).Dump();

// * Metodo SkipLast (pula os 5 ultimos) *
IEnumerableNumeros.SkipLast(5).Dump(); 

// * Metodo TakeLast (pega os 5 ultimos) *
IEnumerableNumeros.TakeLast(5).Dump();

// * Metodo SkipWhile (Pula os elementos menores que 5) *
IEnumerableNumeros.SkipWhile(cadaElementoDaLista => cadaElementoDaLista < 5).Dump();

// * Metodo TakeWhile (Pega os elementos menores que 5) *
IEnumerableNumeros.TakeWhile(cadaElementoDaLista => cadaElementoDaLista < 5).Dump();

// * Metodo Chunk (vai criar 5 listas separando os numeros da IEnumerableNumeros para que caibam nas 5 listas que ele criar) *
IEnumerableNumeros.Chunk(5).Dump();

// * Metodo Any (vai retornar true or false de acordo com a condicao) *
IEnumerableNumeros.Any(cadaElementoDaLista => cadaElementoDaLista < 5).Dump();

// * Metodo All (vai retornar true or false e vai verifica se todos elementos respeitam a condicao) *
IEnumerableNumeros.All(cadaElementoDaLista => cadaElementoDaLista < 5).Dump();

// * Metodo Contains (vai retornar true or false e vai verificar se algum elemento faz parte da lista) *
IEnumerableNumeros.Contains(5).Dump();

// * Metodo Append (adiciona o numero passado no final da lista) *
IEnumerableNumeros.Append(15).Dump();

// * Metodo Prepend (adiciona o numero passado no inicio da lista) *
IEnumerableNumeros.Prepend(20).Dump();

// * Metodo Count (vai mostrar a quantidade de itens da lista) *
IEnumerableNumeros.Count().Dump();

// * Metodo Max (vai mostrar o maior numero) *
IEnumerableNumeros.Max().Dump();

// * Metodo Min (vai mostrar o menor numero) *
IEnumerableNumeros.Min().Dump();

// * Metodo MaxBy (vai pegar uma propriedade de uma classe e mostrar a pessoa com maior idade em forma de objeto) *
pessoas.MaxBy(x => x.Idade).Dump();

// * Metodo MinBy (vai pegar uma propriedade de uma classe e mostrar a pessoa com menor idade em forma de objeto) *
pessoas.MinBy(x => x.Idade).Dump();

// * Metodo Sum (vai somar a lista toda) *
IEnumerableNumeros.Sum().Dump();

// * Metodo Average (vai somar a lista toda, dividir e nos mostrar a media) *
IEnumerableNumeros.Average().Dump();

// * Metodo First (vai retornar o primeiro item, e se nao tiver item ele vai retornar uma execao) *
IEnumerableNumeros.First().Dump();

// * Metodo FirstOrDefault (vai retornar o primero item, e se nao tiver item ele so me retorna o numero 0, sem me dar uma execao, se eu passar -1 ele vai retornar -1 como default) *
IEnumerableNumeros.FirstOrDefault().Dump();

// * Metodo Single (se a lista tiver 1 elemento ele retorna esse elemento, caso nao tenha ou tenha mais de 1 elemento ele retorna uma execao) *
IEnumerableNumeros.Single().Dump();

// * Metodo SingleOrDefault (se a lista tiver 1 elemento ele retorna esse elemento, caso nao tenha ele retorna 0, caso tenha mais de 1 elemento ele retorna uma execao) *
IEnumerableNumeros.SingleOrDefault().Dump();

// * Metodo Last (pega o ultimo elemento de uma lista, se nao tiver item ele retorna uma execao) *
IEnumerableNumeros.Last().Dump();

// * Metodo LastOrDefault (pega o ultimo elemento de uma lista, se nao tiver item ele retorna 0) *
IEnumerableNumeros.LastOrDefault().Dump();

// * Metodo ElementAt (retorna o elemento do index que eu passar como parametro, caso eu passe um index que nao existe ele retorna uma execao) *
IEnumerableNumeros.ElementAt(4).Dump();

// * Metodo ElementAtOrDefault (retorna o elemento do index que eu passar como parametro, caso eu passe um index que nao existe ele retorna 0) *
IEnumerableNumeros.ElementAtOrDefault(1).Dump();

// * Metodo ToList (transforma em uma lista) *
IEnumerableNumeros.ToList().Dump();

// * Metodo Range (cria uma lista com a quantidade de itens que eu quero, aqui no caso eu quero uma lista com 10 elementos comecando pelo 1) *
IEnumerable<int> listRange = Enumerable.Range(1, 10);
listRange.ToList().Dump(); //-> para mostrar no console

// * Metodo Repeat (vai repetir o elemento que eu passar, aqui no caso eu quero que repita o numero 1 - 10 vezes) *
IEnumerable<int> listRepeat = Enumerable.Repeat(1, 10);
listRepeat.ToList().Dump(); //-> para mostrar no console

// * Metodo Distinct (vai remover os elementos duplicados) *
IEnumerableNumeros.Distinct().Dump(); 

// * Metodo DistinctBy (vai remover os elementos duplicados de acordo com a propriedade que eu passar) *
pessoas.DistinctBy(x => x.Nome).Dump();

// * Metodo Union (vai unir duas listas, e vai remover os elementos duplicados) *
IEnumerable<int> listUnion = [1, 2, 3, 4, 5];
IEnumerable<int> listUnion2 = [4, 5, 6, 7, 8];
listUnion.Union(listUnion2).Dump();
IEnumerableNumeros.Distinct().Dump();

// * Metodo Intersect (vai mostrar os elementos que estao nas duas listas) *
listUnion.Intersect(listUnion2).Dump();
listUnion2.Intersect(listUnion2).Dump();

// * Metodo Except (vai mostrar os elementos que estao na primeira lista e nao estao na segunda lista) *
listUnion.Except(listUnion2).Dump();
listUnion2.Except(listUnion).Dump();
listUnion2.Except(listUnion2).Dump();

// * Metodo Zip (vai juntar duas listas, e vai me retornar uma lista de tuplas) *
IEnumerable<int> listZip = [1, 2, 3, 4, 5];
IEnumerable<int> listZip2 = [6, 7, 8, 9, 10];
listZip.Zip(listZip2, (x, y) => (x, y)).Dump();
IEnumerableNumeros.Distinct().Dump();

// * Metodo ToDictionary (vai transformar a lista em um dicionario) *
IEnumerableNumeros.ToDictionary(x => x).Dump();

// * Metodo ToLookup (vai transformar a lista em um lookup) *
IEnumerableNumeros.ToLookup(x => x).Dump();

// * Metodo ToHashSet (vai transformar a lista em um hashset) *
IEnumerableNumeros.ToHashSet().Dump();

// * Metodo ToArray (vai transformar a lista em um array) *
IEnumerableNumeros.ToArray().Dump();


// * Metodo Concat (vai concatenar duas listas) *
IEnumerable<int> listConcat = [1, 2, 3, 4, 5];
IEnumerable<int> listConcat2 = [6, 7, 8, 9, 10];
listConcat.Concat(listConcat2).Dump();

// * Metodo Reverse (vai inverter a lista) *
IEnumerableNumeros.Reverse().Dump();

// * Metodo OrderBy (vai ordenar a lista em ordem crescente) *
IEnumerableNumeros.OrderBy(x => x).Dump();

// * Metodo OrderByDescending (vai ordenar a lista em ordem decrescente) *
IEnumerableNumeros.OrderByDescending(x => x).Dump();

// * Metodo ThenBy (vai ordenar a lista em ordem crescente, e se tiver elementos iguais ele vai ordenar por outro criterio) *
pessoas.OrderBy(x => x.Nome).ThenBy(x => x.Idade).Dump();

// * Metodo ThenByDescending (vai ordenar a lista em ordem crescente, e se tiver elementos iguais ele vai ordenar por outro criterio em ordem decrescente) *
pessoas.OrderBy(x => x.Nome).ThenByDescending(x => x.Idade).Dump();

// * Metodo GroupBy(agrupa pela propriedade que eu passar, ou seja as idades iguais ele vai agrupar em um objeto) *
pessoas.GroupBy(x => x.Idade).Dump();


var list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);

// * Metodo Remove (vai remover o elemento que eu passar) *
list.Remove(2);
list.Dump();
pessoas.Dump();

// * Metodo RemoveAll (vai remover todos os elementos que eu passar) *
list.RemoveAll(x => x > 2);
list.Dump();

// * Metodo RemoveAt (vai remover o elemento do index que eu passar) *
list.RemoveAt(0);
list.Dump();

// * Metodo RemoveRange (vai remover os elementos do index que eu passar) *
list.RemoveRange(0, 2);
list.Dump();


var list2 = new List<int>();
list2.Add(1);
list2.Add(2);
list2.Add(3);

// * Metodo Add (vai adicionar o elemento que eu passar) *
list2.Add(4);
list2.Dump();

// * Metodo AddRange (vai adicionar os elementos que eu passar) *
list2.AddRange(new List<int> { 5, 6, 7 });
list2.Dump();

// * Metodo Insert (vai adicionar o elemento no index que eu passar) *
list2.Insert(0, 0);
list2.Dump();

// * Metodo InsertRange (vai adicionar os elementos no index que eu passar) *
list2.InsertRange(0, new List<int> { -1, -2, -3 });
list2.Dump();


var list3 = new List<int>();
list3.Add(1);
list3.Add(2);


// * Metodo Clear (vai limpar a lista) *
list3.Clear();
list3.Dump();


// * Metodo Contains (vai verificar se o elemento que eu passar esta na lista) *
list3.Contains(1).Dump();
list3.Contains(2).Dump();
list3.Contains(3).Dump();


// * Metodo Find (vai retornar o primeiro elemento que eu passar) *
list3.Find(x => x == 1).Dump();

var list4 = new List<int>();
list4.Add(1);

// * Metodo FindAll (vai retornar todos os elementos que eu passar) *
list4.FindAll(x => x == 1).Dump();


// * Metodo FindIndex (vai retornar o index do elemento que eu passar) *
list4.FindIndex(x => x == 1).Dump();

// * Metodo FindLast (vai retornar o ultimo elemento que eu passar) *
list4.FindLast(x => x == 1).Dump();

// * Metodo FindLastIndex (vai retornar o ultimo index do elemento que eu passar) *
list4.FindLastIndex(x => x == 1).Dump();

// * Metodo IndexOf (vai retornar o index do elemento que eu passar) *
list4.IndexOf(1).Dump();

// * Metodo LastIndexOf (vai retornar o ultimo index do elemento que eu passar) *
list4.LastIndexOf(1).Dump();

// * Metodo TrueForAll (vai retornar true se todos os elementos respeitarem a condicao) *
list4.TrueForAll(x => x == 1).Dump();

// * Metodo ConvertAll (vai converter todos os elementos da lista) *
list4.ConvertAll(x => x * 2).Dump();

// * Metodo Exists (vai retornar true se existir o elemento que eu passar) *
list4.Exists(x => x == 1).Dump();

// * Metodo ForEach (vai percorrer todos os elementos da lista) *
list4.ForEach(x => Console.WriteLine(x));
Console.ReadLine();
Console.ReadKey();

// * Metodo GetRange (vai retornar os elementos do index que eu passar) *
list4.GetRange(0, 1).Dump();
Console.ReadKey();

// * Metodo RemoveAll (vai remover todos os elementos que eu passar) *
list4.RemoveAll(x => x == 1);
list4.Dump();

// * Metodo RemoveAt (vai remover o elemento do index que eu passar) *
list4.RemoveAt(0);
list4.Dump();

// * Metodo RemoveRange (vai remover os elementos do index que eu passar) *
list4.RemoveRange(0, 1);
list4.Dump();

// * Metodo Sort (vai ordenar a lista) *
list4.Sort();
list4.Dump();

// * Metodo Sort (vai ordenar a lista de acordo com a condicao que eu passar) *
list4.Sort((x, y) => y.CompareTo(x));
list4.Dump();
