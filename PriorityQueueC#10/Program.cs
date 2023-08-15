
//Priority Queue
//0 => Dono
//1 => Gerente
//2 => Funcionário
//3 => Estagiário

var queue = new PriorityQueue<string ,int>(); //Int define a prioridade

queue.Enqueue("Item 1", 0);
queue.Enqueue("Item 2", 3);
queue.Enqueue("Item 3", 2);
queue.Enqueue("Item 4", 1);
queue.Enqueue("Item 5", 3);
queue.Enqueue("Item 6", 2);

while (queue.TryDequeue(out var item, out var priority))
{
    switch (priority)
    {
        case 0: 
            Console.WriteLine($"Item: {item}. Prioridade: {priority} => Dono");
            Console.WriteLine($"");
            break;
        case 1:
            Console.WriteLine($"Item: {item}. Prioridade: {priority} => Gerente");
            Console.WriteLine($"");
            break;
        case 2:
            Console.WriteLine($"Item: {item}. Prioridade: {priority} => Funcionário");
            Console.WriteLine($"");
            break;
        case 3:
            Console.WriteLine($"Item: {item}. Prioridade: {priority} => Estagiário");
            Console.WriteLine($"");
            break;
        default:
            break;
    }
    
}
