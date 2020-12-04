namespace AulaPOOCelular.classes
{
    public class Celular
    { 
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public int telefone;
        public string mensagem;
        public int numero;       
        public string Ligar(){
            return "Foi ligado";
        }
        public string Desligar(){
            return "Está desligado";
        }
        public string Ligacao(int telefone){
            System.Console.WriteLine("Digite o número que você quer ligar");
            telefone = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Fazendo Ligação para o número {telefone}");
            return "O número que você ligou está fora de área ou desligado";
        }
        public string Mensagem(int numero){
            System.Console.WriteLine("Digite a mensagem");
            mensagem = System.Console.ReadLine();
            System.Console.WriteLine("Digite o número do destinatário");
            numero = int.Parse(System.Console.ReadLine());
            return ($"Mensagem enviada para o número {numero}");
        }
    }
}