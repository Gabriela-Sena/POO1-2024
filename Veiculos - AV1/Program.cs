namespace POO1_2024;

class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculoNovo = new Veiculo("Ford", "Fusion", 2012);
        veiculoNovo.ExibirInformacoes();
        veiculoNovo.CalcularImposto();

        Carro carroNovo = new Carro("Fiat", "Punto", 2011, 4);
        carroNovo.ExibirInformacoes();
        carroNovo.CalcularImposto();
        

        Moto motoNova = new Moto("Yamaha", "Factor", 2008, 9);
        motoNova.ExibirInformacoes();
        motoNova.CalcularImposto();

        Caminhao caminhaoNovo = new Caminhao("Accelo", "F3500", 2020, 300);
        caminhaoNovo.ExibirInformacoes();
        caminhaoNovo.CalcularImposto();
    }
}
