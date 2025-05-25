public class Reptil : Animal
{
    public Reptil(string? nome, int idade, string? especie, double peso) : base(nome, idade, especie, peso)
    {
    }

    public void Rastejar()
    {
        Console.WriteLine("Réptil rastejando");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Réptil emitindo som");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Réptil se movendo");
    }
}