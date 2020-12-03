namespace AulaPOOCelular.classes
{
    public class Celular
    { 
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public string Ligar(){
            return "Foi ligado";
        }
        public string Desligar(){
            return "Está desligado";
        }
        public string Ligacao(int telefone){
            return ($"Fazendo Ligação para o número {telefone}");
        }
        public string Mensagem(int numero){
            return ($"Mensagem enviada para o número {numero}");
        }
    }
}