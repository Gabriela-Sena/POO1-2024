namespace POO1_2024;

public class Caminhao : Veiculo
{
    public int CapacidadeDeCarga { get; set; }

    public Caminhao(string marca, string modelo, int ano, int capacidadeDeCarga) : base(marca, modelo, ano)
    {
        CapacidadeDeCarga = capacidadeDeCarga;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Capacidade em Toneladas: {CapacidadeDeCarga}");
    }

    public override float CalcularImposto()
    {
        float imposto = 780  * CapacidadeDeCarga + 445;
        return imposto;
    }
}