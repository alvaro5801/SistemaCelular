// Usamos a palavra-chave "abstract" para definir que esta classe não pode ser instanciada diretamente.
public abstract class Celular
{
    // Propriedades (Atributos)
    // A propriedade tem apenas um "get", então só pode ser definida no construtor (imutável).
    public string Marca { get; }
    public string Modelo { get; }
    public int Armazenamento { get; }

    // Este campo é "protected", significando que só pode ser acessado por esta classe ou classes que herdam dela.
    protected bool Ligado;

    // Construtor da classe base
    public Celular(string marca, string modelo, int armazenamento)
    {
        Marca = marca;
        Modelo = modelo;
        Armazenamento = armazenamento;
        Ligado = false; // Todo celular começa desligado.
    }

    // Métodos Abstratos (O "Contrato")
    // Toda classe que herdar de Celular SERÁ OBRIGADA a implementar estes métodos.
    public abstract void FazerLigacao(string numero);
    public abstract void EnviarMensagem(string numero, string mensagem);
    public abstract void TirarFoto();


    // Métodos Concretos (Comportamento Comum)
    public void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine($"O {Modelo} está ligando...");
        }
        else
        {
            Console.WriteLine($"O {Modelo} já está ligado.");
        }
    }

    public void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine($"O {Modelo} está desligando...");
        }
        else
        {
            Console.WriteLine($"O {Modelo} já está desligado.");
        }
    }

    public void MostrarInfo()
    {
        string status = Ligado ? "Ligado" : "Desligado";
        Console.WriteLine("--- Informações do Celular ---");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Armazenamento: {Armazenamento}GB");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine("-----------------------------");
    }
}