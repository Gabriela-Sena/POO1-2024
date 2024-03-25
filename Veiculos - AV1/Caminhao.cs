namespace POO1_2024;

public class Caminhao : Veiculo
{
    public int CapacidadeDeCarga { get; set; }

    public Caminhao(string marca, string modelo, int ano, int capacidadeDeCarga) : base(marca, modelo, ano)
    {
        CapacidadeDeCarga = capacidadeDeCarga;
    }
}