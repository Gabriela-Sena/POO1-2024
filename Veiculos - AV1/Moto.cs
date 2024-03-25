namespace POO1_2024;

public class Moto : Veiculo
{
    public string  Cilindradas { get; set; }

    public Moto(string marca, string modelo, int ano, string cilindradas) : base(marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Numero de Portas: {Cilindradas}");
    }
}