namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string _modelo;
        protected string _imei;
        protected int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            
            if(string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(imei))
                    throw new ArgumentException();

            if(memoria <= 0)
                throw new ArgumentException("Parâmetro inválido",nameof(memoria));

            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;

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
}