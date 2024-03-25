namespace POO1_2024;

class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculoNovo = new Veiculo("Ford", "Fusion", 2012);
        veiculoNovo.ExibirInformacoes();

        Carro carroNovo = new Carro("Fiat", "Punto", 2011, 4);
        carroNovo.ExibirInformacoes();

    }
}
