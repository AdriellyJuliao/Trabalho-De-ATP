using System;
class TrabalhoFinal
{

    static void exibirMensagemBoasVindas()
    {

        Console.WriteLine(@"
    ███╗░░██╗░█████╗░██████╗░███╗░░██╗██╗░█████╗░
    ████╗░██║██╔══██╗██╔══██╗████╗░██║██║██╔══██╗
    ██╔██╗██║███████║██████╔╝██╔██╗██║██║███████║
    ██║╚████║██╔══██║██╔══██╗██║╚████║██║██╔══██║
    ██║░╚███║██║░░██║██║░░██║██║░╚███║██║██║░░██║
    ╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░╚═╝

    ██████╗░░█████╗░░██████╗░██████╗░█████╗░░██████╗░███████╗███╗░░██╗░██████╗
    ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔══██╗██╔════╝░██╔════╝████╗░██║██╔════╝
    ██████╔╝███████║╚█████╗░╚█████╗░███████║██║░░██╗░█████╗░░██╔██╗██║╚█████╗░
    ██╔═══╝░██╔══██║░╚═══██╗░╚═══██╗██╔══██║██║░░╚██╗██╔══╝░░██║╚████║░╚═══██╗
    ██║░░░░░██║░░██║██████╔╝██████╔╝██║░░██║╚██████╔╝███████╗██║░╚███║██████╔╝
    ╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═════╝░╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░

    ░█████╗░███████╗██████╗░███████╗░█████╗░░██████╗
    ██╔══██╗██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝
    ███████║█████╗░░██████╔╝█████╗░░███████║╚█████╗░
    ██╔══██║██╔══╝░░██╔══██╗██╔══╝░░██╔══██║░╚═══██╗
    ██║░░██║███████╗██║░░██║███████╗██║░░██║██████╔╝
    ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░");
        Console.WriteLine(" \nSeja bem vindo a Narnia Passagens Aéreas ");

    }

    static void exibirOpcoesDoMenu()
    {


        Console.WriteLine(" \n--------- MENU --------- ");

        Console.WriteLine("\nDigite 1 para Cadastrar vôos.");
        Console.WriteLine("Digite 2 Cadastrar passageiros.");
        Console.WriteLine("Digite 3 Ver vôos.");
        Console.WriteLine("Digite 4 Ver passageiros.");
        Console.WriteLine("Digite 5 Alterar um passageiro.");
        Console.WriteLine("Digite 6 Excluir passageiro.");
        Console.WriteLine("Digite 7 Alterar um vôo.");
        Console.WriteLine("Digite 8 Excluir vôo.");
        Console.WriteLine("Digite 0 para sair do menu.");

        Console.Write("\nDigite sua opção:");
        int OpcaoEscolhida = int.Parse(Console.ReadLine()!);



        switch (OpcaoEscolhida)
        {
            case 1:
                CadastrarVoos();
                break;

            case 2:
                CadastroDePassageiros();
                break;

            case 3:
                verVoos();
                break;

            case 4: verTodosPassageiros();
                break;

            case 5: //alterarUmPassageiro();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 6: //excluirUmPassageiro();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 7: //alterarUmVoo();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 8: // excluirVoo();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 0:
                Console.WriteLine("Tchaauu, volte sempre!");
                break;


            default:
                Console.Clear();
                Console.WriteLine("Você selecionou uma opção inválida, por favor tente novamente\n");
                exibirOpcoesDoMenu();
                break;
        }

    }

    static void ListaDosVoos()
    {
        //criando um vetor para armazenar os voos cadastrados

    int[] vetorListaDosVoos = new int[]{}; // int recenbendo o codigo

    int tamanhoLista = vetorListaDosVoos.Length;
    
    for (int i = 0; i < tamanhoLista; i++)
    {
        //Console.WriteLine($"Vôos: {ListaDosVoos[i]}");        /*essa parte fica aqui ou onde vou listar?*/
        Console.WriteLine($"Vôos: {vetorListaDosVoos[i]}");
    }


    }



    static void verTodosPassageiros(){
        Console.Clear();

        Console.WriteLine("**********************");
        Console.WriteLine("Ver Passageiros");
        Console.WriteLine("**********************\n");

        Console.WriteLine("\nDigite 1 para ver um passageiro específico.");
        Console.WriteLine("Digite 2 para ver todos os passageiros desse vôo.");
        Console.WriteLine("Digite 0 para voltar ao menu.");
        
        Console.Write("\nDigite sua opção:");
        int OpcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (OpcaoEscolhida)
        { 
            case 1: 
                Console.WriteLine("VOCE CHEGOU ATE AQUI");
                break;

            case 2: 
                Console.WriteLine("VOCE CHEGOU ATE AQUI");
                break;
                
            case 3: exibirOpcoesDoMenu();
                break;
                
            default:
                Console.Clear();
                Console.WriteLine("Você selecionou uma opção inválida. Por favor tente novamente.\n");
                Thread.Sleep(2500);
                verTodosPassageiros();
            break;
        }





        /*if (OpcaoEscolhida == 1){

            Console.WriteLine("\nChegou ate aqui.");
        } 
        else if (OpcaoEscolhida == 2)
        {
            Console.WriteLine("Chegou ate aqui");

        } else{
            Console.Clear();
            Console.WriteLine("Você selecionou uma opção inválida. Por favor tente novamente.\n");
            Thread.Sleep(2500);
            verTodosPassageiros();
        }*/
    }



    static void verVoos()
    {
        Console.Clear();

        Console.WriteLine("**********************");
        Console.WriteLine("Ver vôos disponiveis");
        Console.WriteLine("**********************\n");

        Console.WriteLine("\nDigite 1 para ver todos os vôos.");
        Console.WriteLine("Digite 2 para ver os vôos com mais passageiros.");
        Console.WriteLine("Digite 3 para ver os vôos com menos passageiros.");
        Console.WriteLine("Digite 4 para ver os vôos com maior distância.");
        Console.WriteLine("Digite 5 para ver os vôos com menor distância.");
        Console.WriteLine("Digite 6 para ver os vôos com ocupação média dos vôos"); // semelhante a  Media De Uma Banda
        Console.WriteLine("Digite 0 para voltar ao menu.");

        Console.Write("\nDigite sua opção:");
        int OpcaoEscolhida = int.Parse(Console.ReadLine()!);

        switch (OpcaoEscolhida)
        {
            case 1: verTodosOsVoos();
                //Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 2: //voosMaisPassageiros();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 3: //voosMenosPassageiros();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 4: //voosMaiorDistancia();
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 5: // voosMenorDistancia()
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 6: //ocupacaoMediaVoos()
                Console.WriteLine($"Sua escolha foi {OpcaoEscolhida}");
                break;

            case 0: Console.Clear();
            exibirOpcoesDoMenu();
                break;

            default:
                Console.Clear();
                Console.WriteLine("Você selecionou uma opção inválida. Por favor tente novamente.\n");
                Thread.Sleep(2500);
                verVoos();
                break;
        }

        void verTodosOsVoos()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("Exibição de todos os vôos registrados.");
            Console.WriteLine("********************************\n");

            /*for (int i = 0; i < ListaDosVoos.Length; i++)
            {
                Console.WriteLine($"Vôos: {ListaDosVoos[i]}");
            }*/

            ListaDosVoos();

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            //faz com que qualquer tecla que for digitada faça ir para o menu
            Console.ReadKey();
            Console.Clear();
            exibirOpcoesDoMenu();

        }


        /*void voosMaisPassageiros(){

        }


        void voosMenosPassageiros(){
            
        }

         void voosMaiorDistancia(){
            
        }

        void voosMenorDistancia(){
            
        }

        void ocupacaoMediaVoos(){
            
        }*/







    }


    static void CadastrarVoos()
    {
        Console.Clear();

        Console.WriteLine("**********************");
        Console.WriteLine("Cadastro de vôos");
        Console.WriteLine("**********************\n");

        Console.Write("Digite o codigo do vôo:");
        string CodigoVoo = Console.ReadLine()!;
        Console.Write("Digite a distância do vôo:");
        string DistanciaVoo = Console.ReadLine()!;
        Console.Write("Digite a quantidades de acentos desse Vôo:");
        string AcentosDoVoo = Console.ReadLine()!;
        


        //vetorListaDosVoos.Add(CodigoVoo);
        // ListaDosVoos.Add(DistanciaVoo);
        //  ListaDosVoos.Add(AcentosDoVoo);


        Console.WriteLine($"O vôo de codigo {CodigoVoo} foi cadastrado com sucesso!");

        Thread.Sleep(3000); //faz o carregamento de alguns segundos

        Console.Clear();
        exibirOpcoesDoMenu();

    }


    static void CadastroDePassageiros()
    {
        Console.Clear();
        Console.WriteLine("**********************");
        Console.WriteLine("Cadastro De Passageiros");
        Console.WriteLine("**********************\n");


        Console.Write("Digite o codigo do passageiro:");
        string codigoPassageiro = Console.ReadLine()!;
        Console.Write("Digite o nome do passageiro:");
        string nomePassageiro = Console.ReadLine()!;

        //ListaDosPassageiros.Add(codigoPassageiro);
        Console.WriteLine($"O passageiro(a) {nomePassageiro} de codigo {codigoPassageiro} foi cadastrado com sucesso!");

        Thread.Sleep(3500);

        Console.Clear();
        exibirOpcoesDoMenu();

    }


    public static void Main(string[] args)
    {
        exibirMensagemBoasVindas();
        exibirOpcoesDoMenu();


    }

}




