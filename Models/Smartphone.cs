namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementando as propriedades
        public string Numero { get; set; }
        private string modeloPrivate = "";
        private string imeiPrivate = "";
        private string memoriaPrivate = "";
        
        public string numero { get; set; }
        public string Modelo 
        { 
            get {return modeloPrivate;} 
            set {modeloPrivate = value;} 
        }
        public string IMEI 
        { 
            get {return imeiPrivate;} 
            set {imeiPrivate = value;} 
        }
        public string Memoria 
        { 
            get {return memoriaPrivate;} 
            set {memoriaPrivate = value;} 
        }

        //Métodos
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