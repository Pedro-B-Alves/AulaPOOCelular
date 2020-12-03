using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

             Console.WriteLine("Digite a cor do celular");
             celular.cor = Console.ReadLine();
             Console.WriteLine("Digite o modelo do celular");
             celular.modelo = Console.ReadLine();
             Console.WriteLine("Digite o tamanho do celular");
             celular.tamanho = float.Parse(Console.ReadLine());
             Console.WriteLine("Digite se o celular está ligado ou desligado s/n");
             string resposta = Console.ReadLine();
             if (resposta == "s"){
                 celular.ligado = true;
             }else{
                 celular.ligado = false;
                 Console.WriteLine("Deseja ligar o celular? s/n");
                 string resposta2 = Console.ReadLine();
                 if (resposta2 == "s"){
                     celular.ligado = true;
                     Console.WriteLine(celular.Ligar());
                 }else{
                     Console.WriteLine(celular.Desligar());
                     return;
                 }
             }
             int opcao = 0;
             do
             {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Fazer ligação");
                Console.WriteLine("[2] - Enviar mensagem");
                Console.WriteLine("[0] - Desligar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o telefone");
                        int telefone = int.Parse(Console.ReadLine());
                        Console.WriteLine(celular.Ligacao(telefone));
                        Console.WriteLine("O número que você ligou está fora de área ou desligado");
                        break;
                    case 2:
                        Console.WriteLine("Digite a mensagem");
                        string mensagem = Console.ReadLine();
                        Console.WriteLine("Digite o número do destinatário");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine(celular.Mensagem(numero));
                        
                        break;
                    case 0:
                        celular.ligado = false;
                        Console.WriteLine(celular.Desligar());
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
                
             } while (celular.ligado != false);
             
        }
    }
}
