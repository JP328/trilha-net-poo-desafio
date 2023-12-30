namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} está sendo instalado no seu aparelho Iphone...");
        }
    }
}