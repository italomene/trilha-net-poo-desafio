namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    // Resolução: 
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        // Resolução:
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando {nomeApp} no smartphone Nokia...");
        }
    }
}