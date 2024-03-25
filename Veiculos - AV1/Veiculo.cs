namespace POO1_2024;

public class Veiculo
{

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public virtual void ExibirInformacoes()//precisa ser virutal ou abstrata para ser herdada
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }

    public virtual float CalcularImposto()
    {
        return 0; // Implementação padrão para veículos genéricos
    }

}