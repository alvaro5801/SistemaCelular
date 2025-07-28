// A sintaxe ": Celular" indica que Iphone herda da classe Celular.
public class Iphone : Celular
{
    // Construtor do Iphone
    // A sintaxe ": base(...)" chama o construtor da classe pai (Celular).
    public Iphone(string modelo, int armazenamento) 
        : base("Apple", modelo, armazenamento)
    {
    }

    // Implementação dos métodos abstratos usando a palavra-chave "override"
    public override void FazerLigacao(string numero)
    {
        if (Ligado)
            Console.WriteLine($"iPhone: Ligando para {numero} com o som característico 'bip bip'.");
        else
            Console.WriteLine("Não é possível fazer ligação, o iPhone está desligado.");
    }

    public override void EnviarMensagem(string numero, string mensagem)
    {
        if (Ligado)
            Console.WriteLine($"iPhone: Enviando iMessage para {numero}: '{mensagem}'");
        else
            Console.WriteLine("Não é possível enviar mensagem, o iPhone está desligado.");
    }

    public override void TirarFoto()
    {
        if (Ligado)
            Console.WriteLine("iPhone: Foto capturada com o sistema de câmera TrueDepth. *click*");
        else
            Console.WriteLine("Não é possível tirar foto, o iPhone está desligado.");
    }

    // Método específico do iPhone
    public void UsarSiri()
    {
        if (Ligado)
            Console.WriteLine("Ouvindo... 'E aí, Siri?'");
        else
            Console.WriteLine("A Siri não funciona com o iPhone desligado.");
    }
}