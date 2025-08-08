namespace DesafioPOO.Models
{
    public class iphone : Smartphone
    {
        public iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iphone.");
        }
    }
}