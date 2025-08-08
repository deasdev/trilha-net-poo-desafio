namespace DesafioPOO.Models
{
    // A classe Nokia herda da classe Smartphone
    public class Nokia : Smartphone
    {
        // Construtor para a classe Nokia, que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Adicione a sua lógica aqui. Por exemplo, você pode imprimir uma mensagem específica.
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia.");
        }
    }
}