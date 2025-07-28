public class Samsung : Celular
{
    public Samsung(string modelo, int armazenamento) 
        : base("Samsung", modelo, armazenamento)
    {
    }

    // Implementação dos métodos abstratos
    public override void FazerLigacao(string numero)
    {
        if (Ligado)
            Console.WriteLine($"Samsung: Discando para {numero} pela rede da operadora.");
        else
            Console.WriteLine("Não é possível fazer ligação, o Samsung está desligado.");
    }

    public override void EnviarMensagem(string numero, string mensagem)
    {
        if (Ligado)
            Console.WriteLine($"Samsung: Enviando SMS para {numero}: '{mensagem}'");
        else
            Console.WriteLine("Não é possível enviar mensagem, o Samsung está desligado.");
    }

    public override void TirarFoto()
    {
        if (Ligado)
            Console.WriteLine("Samsung: Foto tirada com o 'Space Zoom'. Qualidade aprimorada por IA.");
        else
            Console.WriteLine("Não é possível tirar foto, o Samsung está desligado.");
    }

    // Método específico do Samsung
    public void AtivarModoDex()
    {
        if (Ligado)
            Console.WriteLine("Modo DeX ativado. Transformando seu celular em um desktop.");
        else
            Console.WriteLine("Ligue o celular para ativar o modo DeX.");
    }
}