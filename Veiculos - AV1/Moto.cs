namespace POO1_2024;

public class Moto : Veiculo
{
    public float  Cilindradas { get; set; }

    public Moto(string marca, string modelo, int ano, float cilindradas) : base(marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Cilindradas: {Cilindradas}");
    }

    public override float CalcularImposto()
    {
        float imposto = 150  * Cilindradas;
        return imposto;
    }
}