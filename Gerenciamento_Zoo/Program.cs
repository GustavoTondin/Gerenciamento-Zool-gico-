List<Animal> animais = new List<Animal>();
List<Funcionario> funcionarios = new List<Funcionario>();

bool running = true;
while (running)
{
    Console.WriteLine("\n--- Sistema de Gerenciamento do Zoológico ---");
    Console.WriteLine("1. Cadastro de Animais");
    Console.WriteLine("2. Cadastro de Funcionários");
    Console.WriteLine("3. Interação Animal-Funcionário");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção de 1 a 4: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarAnimal();
            break;
        case 2:
            CadastrarFuncionario();
            break;
        case 3:
            InteracaoFuncionarioAnimal();
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            running = false;
            break;
        default:
            Console.Write("Opção invalida, digite novamente!!");
            break;

    }

    void CadastrarAnimal()
    {
        string? especie;
        do
        {
            Console.WriteLine("Escolha a especie do animal (Ave, Mamifero, Reptil): ");
            especie = Console.ReadLine();
            if (especie != "Mamifero" && especie != "Ave" && especie != "Reptil")
            {
                Console.WriteLine("Especie invalida! Digite novamente.");
            }
        } while (especie != "Mamifero" && especie != "Ave" && especie != "Reptil");

        Console.WriteLine("Escolha o nome do animal: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Qual a idade do animal: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual o peso do animal: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        if (especie == "Mamifero")
        {
            Mamifero mamifero = new Mamifero(nome, idade, especie, peso);
            animais.Add(mamifero);
            Console.WriteLine($"O Mamifero {nome} de {idade} anos de idade e peso {peso} foi criado");
        }
        else if (especie == "Ave")
        {
            Ave ave = new Ave(nome, idade, especie, peso);
            animais.Add(ave);
            Console.WriteLine($"A Ave {nome} de {idade} anos de idade e peso {peso} foi criada");
        }
        else if (especie == "Reptil")
        {
            Reptil reptil = new Reptil(nome, idade, especie, peso);
            animais.Add(reptil);
            Console.WriteLine($"O Reptil {nome} de {idade} anos de idade e peso {peso} foi criado");
        }
    }

    void CadastrarFuncionario()
    {
        string? cargo;
        do
        {
            Console.WriteLine("Qual o cargo do funcionario (Zelador ou Veterinario): ");
            cargo = Console.ReadLine();
            if (cargo != "Zelador" && cargo != "Veterinario")
            {
                Console.WriteLine("Cargo invalido!! Digite novamente.");
            }
        } while (cargo != "Zelador" && cargo != "Veterinario");

        Console.WriteLine("Escolha o nome do Funcionario: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Qual a idade do funcionario: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (cargo == "Zelador")
        {
            Zelador zelador = new Zelador(nome, idade, cargo);
            funcionarios.Add(zelador);
            Console.WriteLine($"O zelador {nome} de idade {idade} foi criado com sucesso!!");
        }
        else if (cargo == "Veterinario")
        {
            Veterinario veterinario = new Veterinario(nome, idade, cargo);
            funcionarios.Add(veterinario);
            Console.WriteLine($"O veterinario {nome} de idade {idade} foi criado com sucesso!!");
        }
    }

    void InteracaoFuncionarioAnimal()
    {
        if (animais.Count == 0 || funcionarios.Count == 0)
        {
            Console.WriteLine("É necessário cadastrar pelo menos um animal e um funcionário.");
            return;
        }

        Console.WriteLine("Lista de Animais:");
        for (int i = 0; i < animais.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {animais[i].Nome} {animais[i].Idade} anos, {animais[i].Peso}Kg ({animais[i].Especie})");
        }

        Console.WriteLine("Escolha o indice do Animal: ");
        int ianimal = Convert.ToInt32(Console.ReadLine());
        Animal animal = animais[ianimal - 1];

        Console.WriteLine("Lista de Funcionarios:");
        for (int i = 0; i < funcionarios.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {funcionarios[i].Nome} {funcionarios[i].Idade} anos ({funcionarios[i].Cargo})");
        }

        Console.WriteLine("Escolha o indice do Funcionario: ");
        int ifuncionario = Convert.ToInt32(Console.ReadLine());
        Funcionario funcionario = funcionarios[ifuncionario - 1];

        funcionario.Trabalhar();
        switch (funcionario)
        {
            case Veterinario veterinario:
                veterinario.ConsultarAnimal(animal);
                veterinario.RealizarTratamento();
                break;
            case Zelador zelador:
                zelador.AlimentarAnimal(animal);
                zelador.CuidarHabitat();
                break;
        }
        Console.WriteLine($"Interação concluída entre {funcionario.Nome} e {animal.Nome}.");

        
    }

}

