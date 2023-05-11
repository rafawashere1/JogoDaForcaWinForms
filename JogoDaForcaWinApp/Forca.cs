namespace JogoDaForcaWinApp
{
    public class Forca
    {
        public string tentativas;
        public string palavraSecreta;

        public char letra;
        public char[] escondido;

        public bool achou;
        public bool tentou;

        public int quantidade;
        public int faltam;
        public int erros;

        public Forca()
        {
            this.tentativas = "";
            this.palavraSecreta = ObterPalavraSecreta();

            this.letra = ' ';
            this.escondido = new char[10];

            this.achou = false;
            this.tentou = false;

            this.quantidade = 0;
            this.faltam = 0;
            this.erros = 0;
        }

        private string? ObterPalavraSecreta()
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA" };

            int indiceAleatorio = new Random().Next(palavras.Length);

            return palavras[indiceAleatorio];
        }
    }
}
