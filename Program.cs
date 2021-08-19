using System;

namespace  Aprendizado
{
    class Program
    {
        static void Main(string[] args, decimal notaAluno)
        {    
            decimal soma =0;
            decimal media =0;
            Aluno[] alunos = new Aluno [5];
            var indiceAluno = 0;
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                       Console.WriteLine("Informe o nome do aluno:");
                       Aluno aluno = new Aluno();
                       aluno.NomeAluno = Console.ReadLine();

                    
                      
                      for(int i =1 ; i <=3; i++)
                      {
                          Console.WriteLine("Infome a nota "  + i + " " + "do aluno" + " " + aluno.NomeAluno + ":");
                          decimal nota =0;
                          decimal.TryParse(Console.ReadLine(), out nota );
                          soma =+ nota;
                      }
                      if (decimal.TryParse(Console.ReadLine(), out decimal NotaAluno))
                      {
                       aluno.NotaAluno = NotaAluno; 

                      }
                      else
                      {
                          throw new ArgumentException("Infome um valor que seja decimal!");
                      }
                        
                      alunos[indiceAluno] = aluno;
                      indiceAluno++;


                        break;

                    case "2":
                     

                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
                }
               
                 OpcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {   
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir aluno");
            Console.WriteLine("2- Calcular média do aluno");
            Console.WriteLine("Aperte x para sair do menu");
            Console.WriteLine("");
            string OpcaoUsuario = Console.ReadLine();
             Console.WriteLine("");
                
            return OpcaoUsuario;

             
                
        } 
                
    }

    internal class Aluno
    {
        public decimal NotaAluno { get; internal set; }
        public string NomeAluno { get; internal set; }
    }
}
