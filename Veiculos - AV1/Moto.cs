namespace POO1_2024;

public class Moto : Veiculo
{
    public bool TemSidecar { get; set; }

    public Moto(string marca, string modelo, int ano, bool temSidecar) : base(marca, modelo, ano)
    {
        TemSidecar = temSidecar;
    }
}