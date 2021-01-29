using System;

namespace Trabai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Principais -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            int[][] estoqueAntigo = new int[40][];
            int[][] estoqueNovo = new int[40][];
            GeraBD mat = new GeraBD();
            estoqueAntigo = mat.GeraMatriz();
            int contar0 = 0;
            int contar1 = 0;
            int contar2 = 0;
            int contar3 = 0;
            int contar4 = 0;
            string escolha;
            bool permite = false;
            int GC = 0;
            int RemoverW = 0;
            int RemoverE = 0;

            for (int i = 0; i < estoqueNovo.Length; i++)
            {
                estoqueNovo[i] = new int[40];
            }

            // Estoque Antigo -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            for (int i = 0; i < estoqueAntigo.Length; i++)
            {
                for (int j = 0; j < estoqueAntigo[i].Length; j++)
                {
                    if (estoqueAntigo[i][j] == 1)
                    {
                        contar1++;
                    }
                    else if (estoqueAntigo[i][j] == 2)
                    {
                        contar2++;
                    }
                    else if (estoqueAntigo[i][j] == 3)
                    {
                        contar3++;
                    }
                    else if (estoqueAntigo[i][j] == 4)
                    {
                        contar4++;
                    }
                    else
                    {
                        contar0++;
                    }
                    //Console.Write(estoqueAntigo[i][j] + " ");
                }
                //Console.WriteLine();
            }
            //Console.WriteLine();

            // Estoque Novo -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < estoqueNovo[i].Length; j++)
                {
                    if (estoqueNovo[i][j] == 0)
                    {
                        contar1--;
                        if (contar1 > 0)
                        {
                            estoqueNovo[i][j] = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 10; i < 20; i++)
            {
                for (int j = 0; j < estoqueNovo[i].Length; j++)
                {
                    if (estoqueNovo[i][j] == 0)
                    {
                        contar2--;
                        if (contar2 > 0)
                        {
                            estoqueNovo[i][j] = 2;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 20; i < 30; i++)
            {
                for (int j = 0; j < estoqueNovo[i].Length; j++)
                {
                    if (estoqueNovo[i][j] == 0)
                    {
                        contar3--;
                        if (contar3 > 0)
                        {
                            estoqueNovo[i][j] = 3;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 30; i < 40; i++)
            {
                for (int j = 0; j < estoqueNovo[i].Length; j++)
                {
                    if (estoqueNovo[i][j] == 0)
                    {
                        contar4--;
                        if (contar4 > 0)
                        {
                            estoqueNovo[i][j] = 4;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int q = 0; 3 > 0; q++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("|                                                                 |");
                Console.Write("|              ");
                Console.Write("!  Use o APP em Janela Máximizada!  !", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("              |", Console.ForegroundColor = ConsoleColor.White);
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("|         OBS: Use os números para executar as operações!         |");
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("|   --|    1 - Adicionar um novo Produto.                         |");
                Console.WriteLine("|  ---|    2 - Remover um Produto em Estoque.                     |");
                Console.WriteLine("| ----|    3 - Mostrar o estoque atual.                           |");
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("|-----|    9 - Fechar Programa!!!                                 |");
                Console.WriteLine("|                                                                 |");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {
                    // Adicionar um Produto -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                    for (int i = 0; 3 > 0; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("|                                                                 |");
                        Console.Write("|               ");
                        Console.Write("|  Adicionar Produtos ao Estoque  |", Console.ForegroundColor = ConsoleColor.DarkCyan);
                        Console.WriteLine("               |", Console.ForegroundColor = ConsoleColor.White);
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|    -|Adicionar:                                                 |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|   --|    1 - Alimento.                                          |");
                        Console.WriteLine("|  ---|    2 - Higiene Pessoal.                                   |");
                        Console.WriteLine("| ----|    3 - Limpeza.                                           |");
                        Console.WriteLine("|-----|    4 - Utensílios.                                        |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|-----|    9 - Voltar ao Menu.                                    |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        escolha = Convert.ToString(Console.ReadLine());

                        if (escolha == "1")
                        {
                            if (estoqueNovo[9][39] == 1)
                            {
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("|                       Estoque 1 Cheio!!                         |");
                                Console.WriteLine("|                 Precione Enter para Continuar!                  |");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                permite = false;
                                for (int w = 0; w < 10; w++)
                                {
                                    for (int e = 0; e < estoqueNovo[w].Length; e++)
                                    {
                                        if (estoqueNovo[w][e] == 0)
                                        {
                                            permite = true;
                                            GC = e;
                                            break;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if (permite == true)
                                    {
                                        estoqueNovo[w][GC] = 1;
                                        break;
                                    }
                                    else
                                    {

                                    }
                                }
                            }

                        }
                        else if (escolha == "2")
                        {
                            if (estoqueNovo[19][39] == 2)
                            {
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("|                       Estoque 2 Cheio!!                         |");
                                Console.WriteLine("|                 Precione Enter para Continuar!                  |");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                permite = false;
                                for (int w = 10; w < 20; w++)
                                {
                                    for (int e = 0; e < estoqueNovo[w].Length; e++)
                                    {
                                        if (estoqueNovo[w][e] == 0)
                                        {
                                            permite = true;
                                            GC = e;
                                            break;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if (permite == true)
                                    {
                                        estoqueNovo[w][GC] = 2;
                                        break;
                                    }
                                }
                            }

                        }
                        else if (escolha == "3")
                        {
                            if (estoqueNovo[29][39] == 3)
                            {
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("|                       Estoque 3 Cheio!!                         |");
                                Console.WriteLine("|                 Precione Enter para Continuar!                  |");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                permite = false;
                                for (int w = 20; w < 30; w++)
                                {
                                    for (int e = 0; e < estoqueNovo[w].Length; e++)
                                    {
                                        if (estoqueNovo[w][e] == 0)
                                        {
                                            permite = true;
                                            GC = e;
                                            break;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if (permite == true)
                                    {
                                        estoqueNovo[w][GC] = 3;
                                        break;
                                    }
                                }
                            }

                        }
                        else if (escolha == "4")
                        {
                            if (estoqueNovo[39][39] == 4)
                            {
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("|                       Estoque 4 Cheio!!                         |");
                                Console.WriteLine("|                 Precione Enter para Continuar!                  |");
                                Console.WriteLine("|                                                                 |");
                                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                permite = false;
                                for (int w = 30; w < 40; w++)
                                {
                                    for (int e = 0; e < estoqueNovo[w].Length; e++)
                                    {
                                        if (estoqueNovo[w][e] == 0)
                                        {
                                            permite = true;
                                            GC = e;
                                            break;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if (permite == true)
                                    {
                                        estoqueNovo[w][GC] = 4;
                                        break;
                                    }
                                }
                            }

                        }
                        else if (escolha == "9")
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Erro! - Selecione o Número corretamente!");
                            Console.WriteLine("Enter para Continuar!");
                            Console.ReadLine();
                        }
                    }
                }
                else if (escolha == "2")
                {
                    // Remover um Produto -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                    for (int i = 0; 3 > 0; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine("|                                                                 |");
                        Console.Write("|                ");
                        Console.Write("|  Remover Produtos do Estoque  |", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("                |", Console.ForegroundColor = ConsoleColor.White);
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|    -|Remover:                                                   |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|   --|    1 - Alimento.                                          |");
                        Console.WriteLine("|  ---|    2 - Higiene Pessoal.                                   |");
                        Console.WriteLine("| ----|    3 - Limpeza.                                           |");
                        Console.WriteLine("|-----|    4 - Utensílios.                                        |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("|-----|    9 - Voltar ao Menu.                                    |");
                        Console.WriteLine("|                                                                 |");
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        Console.WriteLine();
                        escolha = Convert.ToString(Console.ReadLine());

                        if (escolha == "1")
                        {

                            Console.Clear();
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|                |  Remover Produtos do Estoque  |                |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|    -|Escolha a Linha e a Coluna que Deseja Retirar:             |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|   --|    [ Linha 1 a 10 ] - [ Coluna 1 a 40 ]                   |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine();
                            Console.WriteLine("Escolha a Linha: ");
                            RemoverW = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Escolha a Coluna: ");
                            RemoverE = Convert.ToInt32(Console.ReadLine());
                            if (RemoverW > 0 && RemoverW <= 10 && RemoverE > 0 && RemoverE <= 40)
                            {
                                estoqueNovo[RemoverW - 1][RemoverE - 1] = 0;
                            }
                            else
                            {

                            }
                        }
                        else if (escolha == "2")
                        {

                            Console.Clear();
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|                |  Remover Produtos do Estoque  |                |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|    -|Escolha a Linha e a Coluna que Deseja Retirar:             |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|   --|    [ Linha 11 a 20 ] - [ Coluna 1 a 40 ]                  |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine();
                            Console.WriteLine("Escolha a Linha: ");
                            RemoverW = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Escolha a Coluna: ");
                            RemoverE = Convert.ToInt32(Console.ReadLine());
                            if (RemoverW > 10 && RemoverW <= 20 && RemoverE > 0 && RemoverE <= 40)
                            {
                                estoqueNovo[RemoverW - 1][RemoverE - 1] = 0;
                            }
                            else
                            {

                            }
                        }
                        else if (escolha == "3")
                        {

                            Console.Clear();
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|                |  Remover Produtos do Estoque  |                |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|    -|Escolha a Linha e a Coluna que Deseja Retirar:             |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|   --|    [ Linha 21 a 30 ] - [ Coluna 1 a 40 ]                  |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine();
                            Console.WriteLine("Escolha a Linha: ");
                            RemoverW = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Escolha a Coluna: ");
                            RemoverE = Convert.ToInt32(Console.ReadLine());
                            if (RemoverW > 20 && RemoverW <= 30 && RemoverE > 0 && RemoverE <= 40)
                            {
                                estoqueNovo[RemoverW - 1][RemoverE - 1] = 0;
                            }
                            else
                            {

                            }
                        }
                        else if (escolha == "4")
                        {

                            Console.Clear();
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|                |  Remover Produtos do Estoque  |                |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|    -|Escolha a Linha e a Coluna que Deseja Retirar:             |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("|   --|    [ Linha 31 a 40 ] - [ Coluna 1 a 40 ]                  |");
                            Console.WriteLine("|                                                                 |");
                            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            Console.WriteLine();
                            Console.WriteLine("Escolha a Linha: ");
                            RemoverW = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Escolha a Coluna: ");
                            RemoverE = Convert.ToInt32(Console.ReadLine());
                            if (RemoverW > 30 && RemoverW <= 40 && RemoverE > 0 && RemoverE <= 40)
                            {
                                estoqueNovo[RemoverW - 1][RemoverE - 1] = 0;
                            }
                            else
                            {

                            }
                        }
                        else if (escolha == "9")
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Erro! - Selecione o Número corretamente!");
                            Console.WriteLine("Enter para Continuar!");
                            Console.ReadLine();
                        }
                    }
                }
                // Mostrar Estoque -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                else if (escolha == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Alimentos -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    for (int w = 0; w < 10; w++)
                    {
                        for (int e = 0; e < estoqueNovo[w].Length; e++)
                        {
                            if (estoqueNovo[w][e] == 1)
                            {
                                Console.Write("| ",Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkCyan);
                            }
                            else
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ",Console.ForegroundColor = ConsoleColor.DarkGray);
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Higiene Pessoal -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    for (int w = 10; w < 20; w++)
                    {
                        for (int e = 0; e < estoqueNovo[w].Length; e++)
                        {
                            if (estoqueNovo[w][e] == 2)
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkCyan);
                            }
                            else
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkGray);
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Limpeza -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    for (int w = 20; w < 30; w++)
                    {
                        for (int e = 0; e < estoqueNovo[w].Length; e++)
                        {
                            if (estoqueNovo[w][e] == 3)
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkCyan);
                            }
                            else
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkGray);
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- Utensílio -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    for (int w = 30; w < 40; w++)
                    {
                        for (int e = 0; e < estoqueNovo[w].Length; e++)
                        {
                            if (estoqueNovo[w][e] == 4)
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkCyan);
                            }
                            else
                            {
                                Console.Write("| ", Console.ForegroundColor = ConsoleColor.DarkGray);
                                Console.Write(estoqueNovo[w][e] + " ", Console.ForegroundColor = ConsoleColor.DarkGray);
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("|");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine();
                    Console.WriteLine("Para voltar, Dê enter!");
                    Console.ReadLine();
                }
                else if (escolha == "9")
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado por Usufruir deste programa!", Console.ForegroundColor = ConsoleColor.Green);
                    Console.WriteLine("Dê enter para Finalizar!", Console.ForegroundColor = ConsoleColor.DarkCyan);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("~ Blu", Console.ForegroundColor = ConsoleColor.White);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro! - Selecione o Número corretamente!");
                    Console.WriteLine("Enter para Continuar!");
                    Console.ReadLine();
                }

            }
        }
    }
}
