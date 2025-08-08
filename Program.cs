namespace DesafioPOO
{

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string Imei { get; set; }
    public int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia...");
    }
}

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no iphone...");
    }
}

  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Smartphone Nokia:");
      Smartphone nokia = new Nokia(numero: "123456", modelo: "Tijolão", imei: "111111111", memoria: 64);
      nokia.Ligar();
      nokia.InstalarAplicativo("WhatsApp");           
      Console.WriteLine("\n-----------------------------\n");

      Console.WriteLine("Smartphone iPhone:");
      Smartphone iphone = new Iphone(numero: "987654", modelo: "14 Pro", imei: "222222222", memoria: 128);
      iphone.ReceberLigacao();
      iphone.InstalarAplicativo("Telegram");
      
      
      
      
    }
  }
}