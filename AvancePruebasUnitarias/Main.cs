using System;
namespace AvancePruebasUnitarias
{
    class GameMain
    {

        public static void Main(string[] args)
        {

            int[] winCase_OpponentValues = { 6, 10 };
            int[] winCase_PlayerValues = { 7, 15 };

            int[] expected_WinCase_WinnerCharacterFinalValue = { 13, 25 };

            int[] loseCase_OponentValues = { 4, 7 };
            int[] loseCase_PlayerValues = { 4, 5 };

            int[] expected_LoseCase_WinnerCharacterFinalValue = { 8, 12 };

            for (int i = 0; i < winCase_PlayerValues.Length; i++)
            {
                Player player = new Player(winCase_PlayerValues[i]);
                Enemy enemy = new Enemy(winCase_OpponentValues[i]);
                Combat combat = new Combat();

                combat.Fight(player, enemy);

                Console.WriteLine(player.str + " Resultado Jugador main");
                Console.WriteLine(enemy.str + " Resultado Enemigo main");
            }

            for (int i = 0; i < loseCase_PlayerValues.Length; i++)
            {
                Player player = new Player(loseCase_PlayerValues[i]);
                Enemy enemy = new Enemy(loseCase_OponentValues[i]);
                Combat combat = new Combat();

                combat.Fight(player, enemy);

                Console.WriteLine(player.str + " Resultado Jugador main");
                Console.WriteLine(enemy.str + " Resultado Enemigo main");

            }
        }
    }
}