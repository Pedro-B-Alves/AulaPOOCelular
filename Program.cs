using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();
            do
            {
                celular.ligado = false;
                Console.WriteLine("Digite qual celular você quer");
                Console.WriteLine($"Modelo: {celular.modelo = "Samsung Galaxy S20"}");
                Console.WriteLine($"Cor: {celular.cor = "Preto"}");
                Console.WriteLine($"Tamanho: {celular.tamanho = "151.7 x 69.1 x 7.9 mm"}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Modelo: {celular.modelo = "Xiaomi Mi Note 10"}");
                Console.WriteLine($"Cor: {celular.cor = "Branco"}");
                Console.WriteLine($"Tamanho: {celular.tamanho = "157.8 x 74.2 x 9.67 mm"}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Modelo: {celular.modelo = "Samsung Galaxy S10 Plus"}");
                Console.WriteLine($"Cor: {celular.cor = "Preto"}");
                Console.WriteLine($"Tamanho: {celular.tamanho = "157.6 x 74.1 x 7.8 mm"}");
                bool modeloValido = false;
                do
                {
                    Console.WriteLine("Digite [1] - Samsung Galaxy S20 [2] - Xiaomi Mi Note 10 [3] - Samsung Galaxy S10 Plus");
                    int modelo = int.Parse(Console.ReadLine());
                        switch (modelo)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu o Samsung Galaxy S20");
                            modeloValido = true;
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu o Xiaomi Mi Note 10");
                            modeloValido = true;
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu o Samsung Galaxy S10 Plus");
                            modeloValido = true;
                            break;
                        default:
                            Console.WriteLine("Você digitou um celular inválido");
                            break;
                    }
                } while (modeloValido == false);
                
                Console.WriteLine("Dejesa ligar o celular s/n");
                string resposta = Console.ReadLine();
                if (resposta == "s"){
                    celular.ligado = true;
                    Console.WriteLine(celular.Ligar());
                }else{
                    celular.ligado = false;
                    Console.WriteLine(celular.Desligar());
                    return;
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
                            Console.WriteLine(celular.Ligacao(celular.telefone));
                            break;
                        case 2:
                            Console.WriteLine(celular.Mensagem(celular.numero));
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
            } while (celular.ligado != false);

             
        }
    }
}
