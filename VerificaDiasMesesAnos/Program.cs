using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosSala
{
    public class VerificarDiasMesesAnos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int dia, mes, ano;

            Console.Write("Coloque o Dia: ");
            dia = int.Parse(Console.ReadLine());
            
           if (dia <= 31){

                Console.Write("Lendo Mes: ");
                mes = int.Parse(Console.ReadLine());

                if (mes <= 12){
                    Console.WriteLine("Anos entre 1900 e 2100\n");
                    Console.Write("Lendo Ano: ");

                    ano = int.Parse(Console.ReadLine());

                    if (ano >= 1900 && ano <= 2100)
                     {
                         Console.WriteLine("Tudo Correto");
                         Console.WriteLine("\n");

                         Console.ReadKey();
            
                        //tem que chamar main() aqui


                     }else{

                        Console.WriteLine("Ano Invalido");
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        //tem que chamar main() aqui
                     }

                }
                else{
                    Console.WriteLine("Mes Invalido, digite novamente! ");
                    Console.WriteLine("\n");
                    Console.ReadKey();

                    
                    //tem que chamar main() aqui
                }

            }
            else{
                Console.WriteLine("Dia Invalido, digite novamente!");
                Console.WriteLine("\n");
                Console.ReadKey();

                //tem que chamar main() aqui
            }
        }
    }
}
