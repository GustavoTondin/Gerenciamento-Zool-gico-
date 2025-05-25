public class Ave : Animal
{ 
    public Ave(string? nome, int idade, string? especie, double peso) : base(nome, idade, especie, peso)
    {
    }

    public void Voar()
    {
        Console.WriteLine("Ave voando");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Ave emitindo som");
    }

    public override void Movimentar()
    {
        Console.WriteLine("Ave se movendo");
    }
}