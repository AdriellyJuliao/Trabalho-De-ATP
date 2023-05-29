using System;

class TrabalhoFinal
{

    static string[,] vetorListaDosVoos = new string[1,3];//codigo = [0], distancia = [1], assentos = [2]
    static int qtdVoo = 1;

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
        
        for (int i = 0; i < qtdVoo; i++)
        {
            //Console.WriteLine($"Vôos: {ListaDosVoos[i]}");        /*essa parte fica aqui ou onde vou listar?*/
            Console.WriteLine($"Vôos: {vetorListaDosVoos[i,0]}");
            Console.WriteLine($"Distância: {vetorListaDosVoos[i,1]}");
            Console.WriteLine($"Assentos: {vetorListaDosVoos[i,2]}");
        }


    }

    static void AddVoo(string[] voo){
        //passando as caracteristicas do voo


        string[,] vetorListaDosVoos_aux = new string[qtdVoo+1,3];

        for (int i = 0; i < qtdVoo; i++)
        {

            for (int j = 0; j < 3; j++)
            {

                vetorListaDosVoos_aux[i,j]=vetorListaDosVoos[i,j];
                
            }
            
        }
        for (int j = 0; j < 3; j++)
        {
            
            vetorListaDosVoos_aux[qtdVoo,j]=voo[j];
            
        }

        vetorListaDosVoos = new string[qtdVoo+1,3];

        qtdVoo ++;

        vetorListaDosVoos = vetorListaDosVoos_aux;

    }

    static string[] retornaVoo(int a){

        string[] retorno = new string[3];
    //retorna linha

        for (int j = 0; j < 3; j++)
        {
            
            retorno[j]=vetorListaDosVoos[a,j];
            
        }

        return retorno;

    }

    static void excluiVoo(int a){

        string[,] vetorListaDosVoos_aux = new string[qtdVoo-1,3];

        for (int i = 0; i < qtdVoo; i++)
        {

            if(i<a){

                for (int j = 0; j < 3; j++)
                {
                    
                    vetorListaDosVoos_aux[i,j]=vetorListaDosVoos[i,j];
                    
                }

            }
            else if(i>a){

                for (int j = 0; j < 3; j++)
                {
                    
                    vetorListaDosVoos_aux[i-1,j]=vetorListaDosVoos[i,j];
                    
                }

            }
            
        }

        qtdVoo--;

        vetorListaDosVoos = vetorListaDosVoos_aux;


    }



    static void verTodosPassageiros(){
        Console.Clear();

        Console.WriteLine("**********************");
        Console.WriteLine("Ver Passageiros");
        Console.WriteLine("**********************\n");

        Console.WriteLine("\nDigite 1 para ver um passageiro específico.");
        Console.WriteLine("Digite 2 para ver todos os passageiros desse vôo.");
        Console.WriteLine("Digite 0 para voltar ao menu principal.");
        
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
                
            case 0: exibirOpcoesDoMenu();
                break;
                
            default:
                Console.Clear();
                Console.WriteLine("Você selecionou uma opção inválida. Por favor tente novamente.\n");
                //Thread.Sleep(2500);
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
                //Thread.Sleep(2500);
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
        


        AddVoo(new string[3]{CodigoVoo,DistanciaVoo,AcentosDoVoo});

        Console.WriteLine($"O vôo de codigo {CodigoVoo} foi cadastrado com sucesso!");

        //Thread.Sleep(3000); //faz o carregamento de alguns segundos

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

       // Thread.Sleep(3500);

        Console.Clear();
        exibirOpcoesDoMenu();

    }


    public static void Main(string[] args)
    {
        exibirMensagemBoasVindas();
        exibirOpcoesDoMenu();


    }

}



