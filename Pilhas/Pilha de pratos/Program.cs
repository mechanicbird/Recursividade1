using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma pilha de strings (coleção do tipo LIFO - Last In, First Out)
        Stack<string> pilha = new Stack<string>();

        // ================================
        // 1) Empilhando elementos (Push)
        // Cada novo item vai para o topo da pilha
        // Estado após estas inserções: [Prato 1, Prato 2, Prato 3(top)]
        pilha.Push("Prato 1");
        pilha.Push("Prato 2");
        pilha.Push("Prato 3");

        // ================================
        // 2) Peek() -> Lê o topo sem remover
        // Deve mostrar "Prato 3"
        Console.WriteLine("Topo da pilha: " + pilha.Peek());

        // ================================
        // 3) Pop() -> Remove e retorna o topo
        // Remove "Prato 3"
        // Novo estado: [Prato 1, Prato 2(top)]
        Console.WriteLine("Desempilhando: " + pilha.Pop());

        // ================================
        // 4) Novo topo da pilha (Peek novamente)
        // Agora o topo é "Prato 2"
        Console.WriteLine("Novo topo: " + pilha.Peek());

        // ================================
        // 5) Percorrendo a pilha com foreach
        // A iteração da Stack percorre em ordem LIFO (do topo para a base)
        // Com o estado atual imprime:
        // Prato 2
        // Prato 1
        Console.WriteLine("\nElementos restantes na pilha:");
        foreach (string item in pilha)
        {
            Console.WriteLine(item);
        }

        // ================================
        // Observações importantes:
        // - Push, Pop e Peek são operações O(1) (tempo constante).
        // - Se a pilha estiver vazia, Pop() e Peek() lançam InvalidOperationException.
        //   Portanto, é boa prática verificar se pilha.Count > 0 antes.
        // - Para saber quantos elementos existem, use pilha.Count.
    }
}