namespace POO1_2024;

public class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }

    public Carro(string marca, string modelo, int ano, int numeroDePortas) : base(marca, modelo, ano)
    {
        NumeroDePortas = numeroDePortas;
    }
}