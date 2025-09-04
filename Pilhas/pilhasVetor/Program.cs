using System;

class Pilha
{
    // Array que guarda os elementos da pilha (implementação por vetor)
    private int[] elementos;

    // Índice do topo atual. -1 significa "vazio".
    // Quando há um elemento no topo, topo é o índice desse elemento em 'elementos'.
    private int topo;

    // Capacidade máxima da pilha (tamanho do array)
    private int capacidade;

    // Construtor: cria a pilha com a capacidade desejada
    public Pilha(int capacidade)
    {
        // Armazena a capacidade solicitada
        this.capacidade = capacidade;

        // Aloca o array que conterá os elementos
        elementos = new int[capacidade];

        // Inicialmente não há elementos, então topo = -1
        // Ex.: capacidade = 5 -> elementos = [0,0,0,0,0], topo = -1
        topo = -1;
    }

    // Adiciona (empilha) um item no topo da pilha
    public void Push(int item)
    {
        // Se topo == capacidade - 1, o array está cheio (não há posição livre)
        // Ex.: capacidade = 5 -> índices válidos: 0..4 ; quando topo == 4 -> cheio
        if (topo == capacidade - 1)
        {
            Console.WriteLine("Pilha cheia!");
            return; // não adiciona nada quando cheia
        }

        // ++topo incrementa topo primeiro e depois usa o novo valor como índice.
        // Assim, se topo estava -1 (vazia), ++topo vira 0 e elementos[0] recebe item.
        // Exemplo passo a passo:
        // estado inicial: topo = -1, elementos = [ , , , , ]
        // Push(10): ++topo => topo = 0 ; elementos[0] = 10
        // estado: topo = 0, elementos = [10, , , , ]
        elementos[++topo] = item;
    }

    // Remove (desempilha) e retorna o item do topo
    public int Pop()
    {
        // Se topo == -1, a pilha está vazia -> nada para remover
        if (topo == -1)
        {
            Console.WriteLine("Pilha vazia!");
            // Retornar -1 aqui é uma escolha simples para sinalizar erro,
            // mas tem duas limitações: 1) -1 pode ser um valor válido na pilha;
            // 2) não diferencia erro de um valor legítimo.
            // Alternativas melhores: lançar exceção, retornar int? (nullable),
            // ou implementar TryPop(out int item) que retorna bool.
            return -1;
        }

        // elementos[topo--] retorna o elemento atual no índice 'topo' e depois decrementa 'topo'.
        // Ou seja, faz: valor = elementos[topo]; topo = topo - 1; return valor;
        // Exemplo: antes: topo = 2, elementos = [10,20,30, , ]
        // Pop() -> retorna 30, depois topo passa a 1.
        return elementos[topo--];
    }

    // Retorna (sem remover) o item do topo
    public int Peek()
    {
        if (topo == -1)
        {
            Console.WriteLine("Pilha vazia!");
            // Mesmo comentário sobre retornar -1: é um sinal simples, mas ambíguo.
            return -1;
        }

        // Retorna o elemento no índice topo sem alterar 'topo'
        return elementos[topo];
    }

    // Indica se a pilha está vazia
    public bool EstaVazia()
    {
        // Retorna true quando topo == -1
        return topo == -1;
    }
}

class Program
{
    static void Main()
    {
        // Cria uma pilha com capacidade para 5 elementos
        Pilha pilha = new Pilha(5);

        // Empilha três valores
        // Situação após cada passo (mostrado entre comentários):
        // 1) Push(10) -> topo: 0, elementos: [10, , , , ]
        pilha.Push(10);

        // 2) Push(20) -> topo: 1, elementos: [10, 20, , , ]
        pilha.Push(20);

        // 3) Push(30) -> topo: 2, elementos: [10, 20, 30, , ]
        pilha.Push(30);

        // Peek mostra o topo sem remover:
        // Porque topo == 2, Peek() retorna elementos[2] == 30
        Console.WriteLine("Topo: " + pilha.Peek()); // Saída esperada: "Topo: 30"

        // Pop remove e retorna o topo:
        // Pop() retorna 30 e decrementa topo para 1
        Console.WriteLine("Desempilhando: " + pilha.Pop()); // Saída: "Desempilhando: 30"

        // Agora o topo mudou para o índice 1 (valor 20)
        Console.WriteLine("Topo agora: " + pilha.Peek()); // Saída: "Topo agora: 20"

        // Observações sobre saída e estado interno final:
        // Estado final dos dados após as operações acima:
        // elementos = [10, 20, 30, , ]  <-- o array ainda contém 30 na posição 2, mas topo == 1,
        // topo == 1 -> significa que elementos válidos são índices 0..1 (10 e 20).
        // Se quiser limpar a posição ao desempilhar, poderia fazer:
        // int val = elementos[topo--];
        // elementos[topo+1] = 0; // ou default(int)
        //
        // Complexidade das operações:
        // Push, Pop e Peek são O(1) (tempo constante).
        //
        // Possíveis melhorias/alternativas:
        // - Em vez de imprimir "Pilha cheia!" / "Pilha vazia!" e retornar -1,
        //   você pode lançar InvalidOperationException para casos de erro,
        //   ou implementar um TryPop(out int item) que retorna bool para indicar sucesso.
        // - Para uma pilha que cresce dinamicamente, você poderia usar List<int> ou Stack<int>
        //   (implementação pronta do .NET) ou realocar o array quando estiver cheio.
    }
}