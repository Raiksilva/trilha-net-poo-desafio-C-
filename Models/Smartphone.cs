namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public string nomeApp{ get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Realizando ligação...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        
         public void LigaçaoAtendida()
        {
            Console.WriteLine("oie, tudo bem? aqui é...");
        }
        
        public void LigaçaoRecebida()
        {
            Console.WriteLine("Alo?");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}