public class Veterinario : Funcionario, ITratamentoAnimal
{
    public Veterinario(string? nome, int idade, string? cargo) : base(nome, idade, cargo)
    {
    }

    public void ConsultarAnimal(Animal animal)
    {
        Console.WriteLine($"O veterinário {Nome} esta consultando o animal: {animal.Nome}, Idade: {animal.Idade}, Espécie: {animal.Especie}");
    }

    public override void Trabalhar()
    {
        Console.WriteLine($"O veterinário {Nome} esta trabalhando");
    }

    public void RealizarTratamento()
    {
        Console.WriteLine($"O veterinário {Nome} esta realizando tratamento no animal");
    }
}