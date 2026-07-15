// criar um sistema que exibe um menu com opções:
//Depositar, Sacar, Ver saldo e Sair.
// deve aparecer no menu pelo menos uma vez. O saldo não pode ficar negativo
// o usuario deve conseguir fazer várias operações até escolher sair.

        double saldo = 10000.0;
        int opcao = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("--- SIMULADOR DE CAIXA ELETRÔNICO ---");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Ver Saldo");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor do depósito: R$ ");
                    double deposito = double.Parse(Console.ReadLine());
                    if (deposito > 0)
                    {
                        saldo += deposito;
                        Console.WriteLine($"Depósito de R$ {deposito:F2} realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Valor de depósito inválido.");
                    }
                    break;

                case 2:
                    Console.Write("Digite o valor do saque: R$ ");
                    double saque = double.Parse(Console.ReadLine());

                    if (saque > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente para realizar esta operação!");
                    }
                    else if (saque <= 0)
                    {
                        Console.WriteLine("Valor de saque inválido.");
                    }
                    else
                    {
                        saldo -= saque;
                        Console.WriteLine($"Saque de R$ {saque:F2} realizado com sucesso!");
                    }
                    break;

                case 3:
                    Console.WriteLine($"Seu saldo atual é: R$ {saldo:F2}");
                    break;

                case 4:
                    Console.WriteLine("Obrigado por usar o Caixa Eletrônico. Até mais!");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 4);
  