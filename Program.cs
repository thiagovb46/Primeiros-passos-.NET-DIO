using System;
using System.Collections;
namespace revisao
{
    class Program
    {    private static ArrayList data = new ArrayList();
        static void Main(string[] args)
        {   String name;
            float sum=0;
            int menu_option = 1;
            while (menu_option!=0)
            {   menu_option=startsMenu();
                switch(menu_option)
                {   case 0:
                    Console.WriteLine("Obrigado, volte sempre.");
                    break;
                    case 1: 
                        Console.WriteLine("Digite o Nome do aluno");
                        name = Console.ReadLine();
                        Console.WriteLine("Digite a nota do Aluno");
                        if(float.TryParse(Console.ReadLine(), out float nota))
                        {
                            data.Add(new Aluno(name,nota));
                            Console.WriteLine($"O Aluno {name} foi inserido com sucesso");
                            finalMessage();
                        }
                        else 
                        {
                            Console.WriteLine("Você digitou informações incorretas, por favor digite um valor numérico no campo nota !");
                            finalMessage();
                        }
                    break;
                    case 2:
                        Console.WriteLine("Notas por aluno: "); 
                        foreach(Aluno obj in data)
                        {
                           Console.Write($"Nome: {obj.getName()}    ");
                           Console.WriteLine($"Nota: {obj.getNota()}");
                        }
                        finalMessage();
                    break;
                    case 3:
                        foreach(Aluno obj in data)
                        {
                            sum+=obj.getNota();
                        }
                        Console.WriteLine($"A média de notas dos alunos é: {sum/data.Count}");
                        finalMessage();
                    break;
                    default:
                        throw new ArgumentOutOfRangeException("Digite uma opção válida");
                }
            }
        }
        
        public static int startsMenu()
        {   Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("Opção 1 - Inserir Aluno");
            Console.WriteLine("Opção 2 - Listar Alunos");
            Console.WriteLine("Opção 3 - Média Geral");
            Console.WriteLine("Opção 0 - Sair");
            if(int.TryParse(Console.ReadLine(), out int option))
            {
                return option;
            }
            else 
            {
                throw new ArgumentException("Digite uma opção Válida");

            } 
        }
        public static void finalMessage()
        {
            Console.WriteLine("Tecle Enter para continuar");
            Console.ReadLine();
            return;
        }
      
    }
}