public class Zelador : Funcionario, ICuidador
{
    public Zelador(string? nome, int idade, string? cargo) : base(nome, idade, cargo)
    {
    }
    
    public void AlimentarAnimal(Animal animal)
    {
        Console.WriteLine($"O zelador {Nome} esta alimentando o animal: {animal.Nome}, Idade: {animal.Idade}, Espécie: {animal.Especie}");
    }

    public void CuidarHabitat()
    {
        Console.WriteLine($"O zelador {Nome} esta cuidando do habitat do animal");
    }

    public override void Trabalhar()
    {
        Console.WriteLine($"O zelador {Nome} trabalhando");
    }
}