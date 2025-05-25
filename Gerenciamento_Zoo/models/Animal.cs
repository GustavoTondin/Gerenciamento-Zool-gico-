public abstract class Animal
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Especie { get; set; }
    public double Peso { get; set; }

    public Animal(string? nome, int idade, string? especie, double peso)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
        Peso = peso;
    }

    public abstract void EmitirSom();
    public abstract void Movimentar();
} 