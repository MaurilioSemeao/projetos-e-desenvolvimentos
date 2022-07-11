using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Program
    {

        static void Tabuleiro(string[,] tab)
        {
            int numCasa = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab[i, j] = ($"[ {numCasa} ]");
                    numCasa++;
                }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(tab[i, j]);
                }
                Console.WriteLine();
            }

        }

        static void SelecionaCasa(string[,] tab, string palyerIn, string digito)
        { 
            switch (digito.Trim())
            {
                case "0":
                    tab[0, 0] = palyerIn;
                    break;
                case "1":
                    tab[0, 1] = palyerIn;
                    break;
                case "2":
                    tab[0, 2] = palyerIn;
                    break;
                case "3":
                    tab[1, 0] = palyerIn;
                    break;
                case "4":
                    tab[1, 1] = palyerIn;
                    break;
                case "5":
                    tab[1, 2] = palyerIn;
                    break;
                case "6":
                    tab[2, 0] = palyerIn;
                    break;
                case "7":
                    tab[2, 1] = palyerIn;
                    break;
                case "8":
                    tab[2, 2] = palyerIn;
                    break;
                default:
                    Console.WriteLine("Selecione Um numero valido");
                    break;

            }

        }

        static void EscreveTabuleito(string[,] tabuleiro)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                  Console.Write(tabuleiro[i, j]);
                }
                Console.WriteLine();
            }
        }

        static string condicaoVitoria(string[,] tab, string playerIn)
        {
            string vitoria = "";

            if (tab[0, 0] == playerIn && tab[0, 1] == playerIn && tab[0, 2] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[1, 0] == playerIn && tab[1, 1] == playerIn && tab[1, 2] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[2, 0] == playerIn && tab[2, 1] == playerIn && tab[2, 2] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[0, 0] == playerIn && tab[1, 0] == playerIn && tab[2, 0] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[0, 1] == playerIn && tab[1, 1] == playerIn && tab[2, 1] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[0, 2] == playerIn && tab[1, 2] == playerIn && tab[2, 2] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[0, 0] == playerIn && tab[1, 1] == playerIn && tab[2, 2] == playerIn)
            {
                vitoria = playerIn;
            }
            if (tab[0, 2] == playerIn && tab[1, 1] == playerIn && tab[2, 0] == playerIn)
            {
                vitoria = playerIn;
            }

            return vitoria;
        }
        static void Main(string[] args)
        {

            string[,] tabela = new string[3, 3];
            string[] jogadas = new string[9];
            string player1 = "[ X ]";
            string player2 = "[ O ]";
            string escolha = "";
            string jogadorVitorioso = "";
            bool vezJogador = true;
            int cont = 0;
            bool condVitoria = false;
            string namePlayer1 = "Player 1";
            string namePlayer2 = "Player 2";


            Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
            Tabuleiro(tabela);
            Console.WriteLine($"sua Vez {namePlayer1} você marca coma {player1} ");
            while (condVitoria != true)
            {
                
                if(vezJogador == true)
                {
                    //Jogada Player X
                    Console.WriteLine("Escolha um valor de 1 a 8");
                    while (string.IsNullOrEmpty(escolha = Console.ReadLine()) || !char.IsDigit(escolha, 0) || int.Parse(escolha) > 8)
                    {
                        Console.Clear();
                        Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                        EscreveTabuleito(tabela);
                        Console.WriteLine("Escolha um valor de 1 a 8");
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        while (escolha == jogadas[i])
                        {
                            Console.Clear();
                            Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");     
                            EscreveTabuleito(tabela);
                            Console.WriteLine("Esta Casa Ja foi Selecionada Seleicone outra Casa");
                            Console.WriteLine($"sua Vez {namePlayer1} você marca coma {player1} ");
                            while (string.IsNullOrEmpty(escolha = Console.ReadLine()) || !char.IsDigit(escolha, 0) || int.Parse(escolha) > 8)
                            {
                                Console.Clear();
                                Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                                EscreveTabuleito(tabela);
                                Console.WriteLine("Esta Casa Ja foi Selecionada Seleicone outra Casa");
                                Console.WriteLine($"sua Vez {namePlayer1} você marca coma {player1} ");
                            }
                            i = 0;
                        }
                    }
                    if (int.Parse(escolha) < 8)
                        jogadas[cont] = escolha.TrimStart();      
                    Console.Clear();
                    SelecionaCasa(tabela, player1, escolha);
                    //escrevendo a tabela prara a vez do player 2
                    Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                    EscreveTabuleito(tabela);
                    Console.WriteLine($"sua Vez {namePlayer2} você marca coma {player2} ");
                    jogadorVitorioso = condicaoVitoria(tabela, player1);
                    if (cont == 8 && jogadorVitorioso == "")
                        break;

                    if (jogadorVitorioso != "")
                    {
                        jogadorVitorioso += namePlayer1;
                        condVitoria = true;
                        break;
                    }
                    vezJogador =false;
                }
                else
                {
                    //jogada Player O
                    Console.WriteLine("escolha um valor de 1 a 8");
                    while (string.IsNullOrEmpty(escolha = Console.ReadLine()) || !char.IsDigit(escolha, 0) || int.Parse(escolha) >8)
                    {
                        Console.Clear();
                        Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                        EscreveTabuleito(tabela);
                        Console.WriteLine("Digite um valor valido");
                        Console.WriteLine($"sua Vez {namePlayer2} você marca com {player2} ");
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        while (escolha == jogadas[i])
                        {
                            Console.Clear();
                            Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                            EscreveTabuleito(tabela);
                            Console.WriteLine("Esta Casa Ja foi Selecionada Seleicone outra Casa");
                            Console.WriteLine($"sua Vez {namePlayer2} você marca com {player2} ");
                            while (string.IsNullOrEmpty(escolha = Console.ReadLine()) || !char.IsDigit(escolha, 0) || int.Parse(escolha) > 8)
                            {
                                Console.Clear();
                                Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                                EscreveTabuleito(tabela);
                                Console.WriteLine("Digite um valor valido");
                                Console.WriteLine($"sua Vez {namePlayer2} você marca com {player2} ");
                            }

                            i =0;
                        }
                    }
                    if(int.Parse(escolha) < 8)
                        jogadas[cont] = escolha.TrimStart();
                    Console.Clear();
                    SelecionaCasa(tabela, player2, escolha.Trim());
                    //escrevendo a tabela para a vez do player 1
                    Console.WriteLine($"{namePlayer1} X {namePlayer2}\n");
                    EscreveTabuleito(tabela);
                    Console.WriteLine($"sua Vez {namePlayer1} você marca coma {player1} ");
                    jogadorVitorioso = condicaoVitoria(tabela, player2);

                    if (cont == 8 && jogadorVitorioso == "")
                        break;

                    if (jogadorVitorioso != "")
                    {
                        jogadorVitorioso += namePlayer1;
                        condVitoria = true;
                        break;
                    }
                    vezJogador = true;
                }
                cont++;
            }
            if(cont == 8 && jogadorVitorioso=="")
            {
                Console.WriteLine("\nO Jogo Empatou!");
            }else if (jogadorVitorioso != "")
            {
                
            Console.WriteLine($"\nO Player {jogadorVitorioso} Venceu !");
            }

       
            Console.ReadKey();

            
        }

    }
}
