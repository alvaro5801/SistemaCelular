class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias (objetos) de cada celular
        // Note que podemos declarar a variável como "Celular" (a base),
        // mas instanciar como "Iphone" (a classe derivada). Isso é polimorfismo!
        Celular meuIphone = new Iphone("iPhone 15 Pro", 256);
        Celular meuSamsung = new Samsung("Galaxy S23 Ultra", 512);

        Console.WriteLine("### Testando o iPhone ###");
        meuIphone.Ligar();
        meuIphone.MostrarInfo();
        meuIphone.FazerLigacao("99999-1111");
        meuIphone.TirarFoto();
        
        // Para usar um método específico do Iphone, precisamos fazer um "cast"
        if (meuIphone is Iphone iphone)
        {
            iphone.UsarSiri();
        }
        
        meuIphone.Desligar();
        Console.WriteLine("\n"); // Apenas para dar um espaço

        Console.WriteLine("### Testando o Samsung ###");
        meuSamsung.Ligar();
        meuSamsung.MostrarInfo();
        meuSamsung.EnviarMensagem("88888-2222", "Olá, tudo bem?");
        meuSamsung.TirarFoto();

        if (meuSamsung is Samsung samsung)
        {
            samsung.AtivarModoDex();
        }
        
        meuSamsung.Desligar();
    }
}