int menuprincipal = 0;
int linha = 0;
int coluna = 0;
int pesquisarpor = 0;
string pesquisar = "";
string comprar = "";
string[,] produtos = new string[5, 4];
string voltarmenuprincipal = "S";
string continuarcompra = "S";
double totalcompra = 0;

while (voltarmenuprincipal == "S" || voltarmenuprincipal == "s")
{
    Console.Clear(); Console.WriteLine("Qual opção deseja?");
    Console.WriteLine("1 - Cadastrar Produtos");
    Console.WriteLine("2 - Pesquisar Produtos");
    Console.WriteLine("3 - Comprar Produtos");
    menuprincipal = int.Parse(Console.ReadLine());

    switch (menuprincipal)
    {
        case 1: // CADASTRAR PRODUTOS
            for (linha = 0; linha <= 4; linha++)
            {
                Console.WriteLine("DESCRIÇÃO do " + (linha + 1) + "º produto:");
                produtos[linha, coluna++] = Console.ReadLine();
                Console.WriteLine("PREÇO do " + (linha + 1) + "º produto:");
                produtos[linha, coluna++] = Console.ReadLine();
                Console.WriteLine("COR do " + (linha + 1) + "º produto:");
                produtos[linha, coluna++] = Console.ReadLine();
                Console.WriteLine("DESCONTO do " + (linha + 1) + "º produto:");
                produtos[linha, coluna++] = Console.ReadLine();

                coluna = 0;
            }

            for (linha = 0; linha <= 4; linha++)
            {
                for (coluna = 0; coluna <= 3; coluna++)
                {
                    Console.Write(" -- " + produtos[linha, coluna] + " -- ");
                }
                Console.WriteLine("");
            }

            break;
        case 2: // PESQUISAR PRODUTOS
            Console.Clear();

            for (linha = 0; linha <= 4; linha++)
            {
                for (coluna = 0; coluna <= 3; coluna++)
                {
                    Console.Write(" -- " + produtos[linha, coluna] + " -- ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Console.WriteLine("Deseja PESQUISAR por:");
            Console.WriteLine("1 - Descrição");
            Console.WriteLine("2 - Cor");
            pesquisarpor = int.Parse(Console.ReadLine());
            if (pesquisarpor == 1)
            {
                coluna = 0;
            }
            if (pesquisarpor == 2)
            {
                coluna = 2;
            }
            Console.WriteLine("\n O quê deseja pesquisar?");
            pesquisar = Console.ReadLine();

            Console.WriteLine("");

            for (linha = 0; linha <= 4; linha++)
            {
                if (produtos[linha, coluna] == pesquisar)
                {
                    Console.WriteLine(" -- " + produtos[linha, 0] + " -- " + produtos[linha, 1] + " -- " + produtos[linha, 2] + " -- " + produtos[linha, 3]);
                }
            }
            Console.WriteLine("");

            break;
        case 3: // COMPRAR PRODUTOS
            while (continuarcompra == "S" || continuarcompra == "s")
            {
                Console.Clear();

                for (linha = 0; linha <= 4; linha++)
                {
                    for (coluna = 0; coluna <= 3; coluna++)
                    {
                        Console.Write(" -- " + produtos[linha, coluna] + " -- ");
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("");

                Console.WriteLine("\n O quê (DESCRIÇÃO) deseja comprar?");
                comprar = Console.ReadLine();

                Console.WriteLine("");

                for (linha = 0; linha <= 4; linha++)
                {
                    if (produtos[linha, 0] == comprar)
                    {
                        totalcompra = totalcompra + (double.Parse(produtos[linha, 1]) - (double.Parse(produtos[linha, 1]) * (double.Parse(produtos[linha, 3]) / 100)));
                    }
                }

                Console.WriteLine("TOTAL atual da compra é: " + totalcompra);

                Console.WriteLine("\n Deseja continuar comprando? S / N");
                continuarcompra = Console.ReadLine();
            }
            break;
    }

    Console.WriteLine("Deseja voltar ao MENU PRINCIPAL? S / N");
    voltarmenuprincipal = Console.ReadLine();
}