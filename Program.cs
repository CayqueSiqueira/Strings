using System;
using System.Text;

namespace MyApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Clear();
                Menu();
            } 
            static void Menu(){
                Console.WriteLine("");
                Console.WriteLine("Modulo strings");
                Console.WriteLine("1 - Acessar Guids");
                Console.WriteLine("2 - Acessar Interpolação");
                Console.WriteLine("3 - Acessar Comparação");
                Console.WriteLine("4 - Acessar StartsWithEndsWith");
                Console.WriteLine("5 - Acessar Equals");
                Console.WriteLine("6 - Acessar Indices");
                Console.WriteLine("7 - Acessar Metodos Adicionais");
                Console.WriteLine("8 - Acessar Manipulando Strings");
                Console.WriteLine("9 - Acessar StringBuilder");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Guids();
                        break;
                    case "2":
                        Interpolacao();
                        break;
                    case "3":
                        Comparacao();
                        break;
                    case "4":
                        StartsWithEndsWith();
                        break;
                    case "5":
                        Equals();
                        break;
                    case "6":
                        Indices();
                        break;
                    case "7":
                        MetodosAdicionais();
                        break;
                    case "8":
                        ManipulandoStrings();
                        break;
                    case "9":
                        StringBuilder();
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            static void Guids(){
                Console.Clear();
                Console.WriteLine("Guids");
                //Guids são identificadores globais únicos
                //Herda do tipo base system

                var id = Guid.NewGuid(); // gera um novo valor pro identificador
                id.ToString();

                id = new Guid("d4f5e6d7-8f9a-4b3c-8d2e-1f2a3b4c5d6e");//podemos passar uma string pro guid num formato valido
                Console.WriteLine(id);
                Console.WriteLine(id.ToString().Substring(0, 8));//pegar os 8 primeiros caracteres
                Console.WriteLine(id.ToString().Substring(9, 4));
                Console.WriteLine(id.ToString().Substring(14, 4));
                Console.WriteLine(id.ToString().Substring(19, 4));
                Console.WriteLine(id.ToString().Substring(24, 12));

                id = new Guid(); // inicializa o dentificador
                Console.WriteLine(id);
                Menu();
            }

            static void Interpolacao(){
                Console.Clear();
                Console.WriteLine("Interpolação de strings");
                var price = 10.2;
                //diferentes formas de interpolar
                //var texto = "O preço do produto é " + price + " apenas na promoção.";
                //var texto =  string.Format("O preço do produto é {0} apenas na promoção.", price);
                
                //var texto = $"O preço do produto é {price} apenas na promoção.";
                var texto = $@"O preço do produto 
                é {price} apenas na promoção."; // o @ na frente do $ permnite quebra de linha e ignorar caracteres de escape/especiais
                Console.WriteLine(texto);
                Console.WriteLine("");
                Menu();
            }

            static void Comparacao(){
                Console.Clear();
                Console.WriteLine("Comparação de strings CompareTo e Contains");

                var texto = "Teste";
                Console.WriteLine(texto.CompareTo("Teste")); // retorna 0 se for igual
                Console.WriteLine(texto.CompareTo("teste")); // retorna 1 se for diferente

                Console.WriteLine(texto.Contains("Teste")); // retorna true se encontrar a string
                Console.WriteLine(texto.Contains("teste")); // retorna false se não encontrar a string
                Console.WriteLine(texto.Contains("teste", StringComparison.OrdinalIgnoreCase)); // retorna true ignorando o case sensitive
                //Console.WriteLine(texto.Contains(null)); // retorna erro

                Menu();
            }
        
            static void StartsWithEndsWith(){
                Console.Clear();
                Console.WriteLine("Comparação de strings StartsWith e EndsWith");

                var texto = "Texto de teste";
                Console.WriteLine(texto.StartsWith("Texto")); // retorna true se começar com a string
                Console.WriteLine(texto.StartsWith("Te")); // retorna true se começar com a string
                Console.WriteLine(texto.StartsWith("texto", StringComparison.OrdinalIgnoreCase)); // retorna true ignorando o case sensitive
                Console.WriteLine(texto.StartsWith("texto")); // retorna false se não começar com a string

                Console.WriteLine(texto.EndsWith("teste")); // retorna true se terminar com a string
                Console.WriteLine(texto.EndsWith("te")); // retorna true se terminar com a string
                Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); // retorna true ignorando o case sensitive
                Console.WriteLine(texto.EndsWith("Teste")); // retorna false se não terminar com a string


                Menu();
            }
        
            static void Equals(){
                Console.Clear();
                Console.WriteLine("Comparação de strings Equals");

                var texto = "Texto de teste";
                Console.WriteLine(texto.Equals("Texto de teste")); // retorna true se for igual
                Console.WriteLine(texto.Equals("texto de teste")); // retorna false se for diferente
                Console.WriteLine(texto.Equals("texto de teste", StringComparison.OrdinalIgnoreCase)); // retorna true ignorando o case sensitive

                Menu();
            }
        
            static void Indices(){
                Console.Clear();
                Console.WriteLine("Indices de strings");

                var texto = "Texto de teste";
                // var indice = texto.IndexOf("de");
                // Console.WriteLine(indice);
                Console.WriteLine(texto.IndexOf("de")); // retorna a posição da primeira ocorrência da string
                Console.WriteLine(texto.LastIndexOf("e")); // retorna a posição da última ocorrência da string
                Console.WriteLine(texto.IndexOf("te")); // retorna a posição da primeira ocorrência da string
                Console.WriteLine(texto.IndexOf("te", StringComparison.OrdinalIgnoreCase)); // retorna a posição da primeira ocorrência da string ignorando o case sensitive

                Menu();
            }
        
            static void MetodosAdicionais(){
                Console.Clear();
                Console.WriteLine("Métodos adicionais de strings");

                var texto = "Texto de teste";
                Console.WriteLine(texto.Length); // retorna o tamanho da string
                Console.WriteLine(texto.ToLower());// retorna a string em minúsculo
                Console.WriteLine(texto.ToUpper());// retorna a string em maiúsculo
                Console.WriteLine(texto.Trim());// remove os espaços em branco do início e do fim da string
                Console.WriteLine(texto.Insert(5, " inserido"));// insere uma string na posição informada
                Console.WriteLine(texto.Remove(5, 3));// remove uma quantidade de caracteres a partir da posição informada


                Menu();
            }

            static void ManipulandoStrings(){
                Console.Clear();
                Console.WriteLine("Manipulando strings");
                var texto = "Texto de teste";
                Console.WriteLine(texto.Replace("de", "para")); // substitui a primeira string pela segunda
                Console.WriteLine(texto.Replace("aaa", "bbb")); 

                var divisao = texto.Split(" "); // divide a string em um array de strings
                foreach (var item in divisao)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(divisao[0]);
                Console.WriteLine(divisao[1]);
                Console.WriteLine(divisao[2]);

                var resultado = texto.Substring(9); // retorna a string a partir da posição informada
                Console.WriteLine(resultado);
                resultado = texto.Substring(5, 3); // retorna a string a partir da posição informada e com o tamanho informado
                Console.WriteLine(resultado);
                Console.WriteLine(resultado.Trim());

                Menu();
            }
        
            static void StringBuilder(){
                Console.Clear();
                Console.WriteLine("StringBuilder");

                var texto = "testo de teste";
                texto += " maior";
                Console.WriteLine(texto);


                var texto2 = new StringBuilder();// o stringbuild permite manipular strings de forma mais eficiente
                texto2.Append("testo de teste");
                texto2.Append(" maior");
                texto2.Append(" de maneira");
                texto2.Append(" mais eficiente");

                texto2.ToString();//conbversão pois o text2 é do tipo stringbuilder e nao string
                Console.WriteLine(texto2);

                Menu();
            }
        }
    }
