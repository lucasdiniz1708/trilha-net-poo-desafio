namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string valor)
        {
            Console.WriteLine($"Instalando Aplicativo: {valor} no Iphone");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}