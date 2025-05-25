public class Mamifero : Animal
{
    public Mamifero(string? nome, int idade, string? especie, double peso) : base(nome, idade, especie, peso)
    {
    }

    public void Amamentar()
    {
        Console.WriteLine("Mamífero amamentando");
    }
    public override void EmitirSom()
    {
        Console.WriteLine("Mamífero emitindo som");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Mamífero se movendo");
    }
}