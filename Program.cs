using System;

    Console.WriteLine("Escolha uma opção: 1 - Novo Pedido 2 - Cancelar");
    
    var input = Console.ReadLine();

    if(input == "1"){

    var cliente = new Cliente();

    Console.WriteLine("Digite o nome: ");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("Digite o CPF: ");
    cliente.CPF = Console.ReadLine();

    Console.ReadLine();
    
    var pizza = new Pizza();

    Console.WriteLine("Escolha um sabor: ");
    pizza.Sabor = Console.ReadLine();
    Console.WriteLine("Escolha um tamanho: ");
    pizza.Tamanho = Console.ReadLine();
    Console.WriteLine("R$: ");
    pizza.Preco = Convert.ToDouble(Console.ReadLine());
    

    Console.ReadLine();

    var pedido = new Pedido();
    
    Console.WriteLine("Gerador de ID: ");

    var n = new Random();
    
    Console.WriteLine("Seu ID é: # " + n.Next(1000));
    Console.WriteLine(cliente.Nome);
    Console.WriteLine(Cliente.validarNomeCpf(cliente.CPF));
    Console.WriteLine(pizza.Sabor);
    Console.WriteLine(pizza.Tamanho);
    Console.WriteLine($"{pizza.valorTotal():0.00##}");


    } else {
        Console.WriteLine("Faça o pedido!");
    }