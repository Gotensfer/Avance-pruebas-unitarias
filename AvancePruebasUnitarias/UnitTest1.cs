using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace AvancePruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatedTower_HasAtLeastOneLevel()
        {
            //Vectores de prueba
            int[] correctCases_SizeOneOrMoreLevels = { 1, 8 };
            int[] failCases_SizeLessThanOneLevels = { 0, -1, -25 };

            //Verificar casos de crear torres con al menos 1 nivel las cuales deberian tener
            //efectivamente al menos un nivel
            for (int i = 0; i < correctCases_SizeOneOrMoreLevels.Length; i++)
            {
                TowerPlayer tower = new TowerPlayer(correctCases_SizeOneOrMoreLevels[i]);

                Assert.IsTrue(tower.tower.Count >= 1, "La torre tiene menos de 1 nivel al ser generada");
            }

            //Verificar casos de crear torres con menos de 1 nivel lo cual
            //no debe ser posible
            for (int i = 0; i < failCases_SizeLessThanOneLevels.Length; i++)
            {
                Assert.ThrowsException<Exception>(() => new TowerPlayer(failCases_SizeLessThanOneLevels[i]), "Se esperaba que saliera una excepci�n");
            }
        }

        [TestMethod]
        public void CreatedPlayerCharacter_HasStartingValue_GreaterThanZero()
        {
            //Vectores de prueba
            int[] correctCases_PlayerCharacterValueOfAtLeastOne = { 1, 19 };
            int[] failCases_PlayerCharacterValueLessThanOne = { 0, -1, -12 };

            //Verificar casos de crear el personaje del jugador con un valor de al menos 1 el cual
            //deberia tener efectivamente al menos 1 de valor
            for (int i = 0; i < correctCases_PlayerCharacterValueOfAtLeastOne.Length; i++)
            {
                Player player = new Player(correctCases_PlayerCharacterValueOfAtLeastOne[i]);

                Assert.IsTrue( player.str >= 1, "El personaje tiene menos de 1 de valor al ser generado");
            }

            //Verificar casos de crear el personaje del jugador con un valor inferior a 1 lo cual
            //no debe ser posible
            for (int i = 0; i < failCases_PlayerCharacterValueLessThanOne.Length; i++)
            {
                Assert.ThrowsException<Exception>(() => new Player(failCases_PlayerCharacterValueLessThanOne[i]), "Se esperaba que saliera una excepci�n");
            }
        }

        [TestMethod]
        public void PlayerCharacter_IsCurrentlyIn_ALevelOfPlayerTower()
        {
            TowerPlayer pTower = new TowerPlayer();

            //Se recorren todas las posiciones de la torre del jugador
            //en busca de instancias del jugador (O sea que existe en una determinada posicion i en la torre)
            int playerAppeareancesInTower = 0;
            for (int i = 0; i < pTower.tower.Count; i++)
            {
                if (pTower.tower[i].player != null) playerAppeareancesInTower++;
            }

            if (playerAppeareancesInTower == 0) Assert.Fail("El jugador no se encuentra en la torre");
            else if (playerAppeareancesInTower > 1) Assert.Fail("El jugador se encuentra en m�s de una posici�n en la torre simult�neamente");
        }

        [TestMethod]
        public void PlayerFacesEnemy_CharacterWithGreaterValueWins_AndPlayerLoseOnTie()
        {
            //Fight
            //Vectores de prueba
            int[] winCase_OpponentValues = { 2, 4};
            int[] winCase_PlayerValues = { 4, 5};

            string[] expected_WinCase_AftermathResult = { "Win", "Win"};

            int[] tieCase_OponentValues = { 3, 6};
            int[] tieCase_PlayerValues = { 3, 6};

            string[] expected_TieCase_AftermathResult = { "Lose", "Lose" };

            for (int i = 0; i < winCase_PlayerValues.Length; i++)
            {
                Player player = new Player(winCase_PlayerValues[i]);
                Enemy enemy = new Enemy(winCase_OpponentValues[i]);
                Combat combat = new Combat();

                string aftermathResult = combat.Fight(player, enemy);

                Assert.IsTrue(aftermathResult == expected_WinCase_AftermathResult[i], "El jugador perdi� cuando debi� ganar");            
            }

            for (int i = 0; i < tieCase_PlayerValues.Length; i++)
            {
                Player player = new Player(tieCase_PlayerValues[i]);
                Enemy enemy = new Enemy(tieCase_OponentValues[i]);
                Combat combat = new Combat();

                string aftermathResult = combat.Fight(player, enemy);

                Assert.IsTrue(aftermathResult == expected_TieCase_AftermathResult[i], "El jugador gan� cuando debio perder por el empate");
            }
        }

        [TestMethod]
        public void PlayerFacesObstacle_InPlayerTower_PlayerAlwaysWins()
        {
            int[] playerValues = { 4, 5 };

            string[] expected__AftermathResult = { "Win", "Win" };

            for (int i = 0; i < playerValues.Length; i++)
            {
                Player player = new Player(playerValues[i]);
                Obstacle obs = new Obstacle();
                Combat combat = new Combat();

                combat.Fight(player, obs);

                string aftermathResult = "Win";

                Assert.IsTrue(aftermathResult == expected__AftermathResult[i], "El jugador perdi� cuando siempre debe ganar contra un objeto");
            }
        }

        [TestMethod]
        public void OnFightResolve_WinningPlayerValueGets_LoserPlayerValue()
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

                Assert.IsTrue(player.str == expected_WinCase_WinnerCharacterFinalValue[i], "El valor con el que termino el jugador es incorrecto");
            }

            for (int i = 0; i < loseCase_PlayerValues.Length; i++)
            {
                Player player = new Player(loseCase_PlayerValues[i]);
                Enemy enemy = new Enemy(loseCase_OponentValues[i]);
                Combat combat = new Combat();

                combat.Fight(player, enemy);

                Assert.IsTrue(enemy.str == expected_LoseCase_WinnerCharacterFinalValue[i], "El valor con el que termino el enemigo es incorrecto");
            }
        }

        [TestMethod]
        public void PlayerFacesEnemy_PlayerWins_PTowerIncreasesOneLevel_ETowerDecreasesOneLevel()
        {
            int winCase_PlayerValues = 8;
            int winCase_OpponentValues = 5;
            int sizeOfPTower = 5;
            int sizeOfETower = 7;
            int directionOfAttack = 3;
            int expected_FinalSizeOfPTower = 6;
            int expected_FinalSizeOfETower = 6;

            Player player = new Player(winCase_PlayerValues);
            Enemy enemy = new Enemy(winCase_OpponentValues);
            Combat combat = new Combat();
            TowerPlayer pTower = new TowerPlayer(sizeOfPTower);
            TowerEnemy eTower = new TowerEnemy(sizeOfETower);

            combat.Fight(player, enemy, pTower, eTower, directionOfAttack);

            Assert.IsTrue(pTower.tower.Count == expected_FinalSizeOfPTower, "El tama�o final de la torre del jugador no aumento al valor correcto");
            Assert.IsTrue(eTower.tower.Count == expected_FinalSizeOfETower, "El tama�o final de la torre del enemigo no disminuyo al valor correcto");
        }

        [TestMethod]
        public void PlayerFacesLastRemaniningEnemy_PlayerWins_ETowerLevelIsAddedToPTower_ETowerDisappears()
        {
            int winCase_PlayerValues = 8;
            int winCase_OpponentValues = 5;
            int sizeOfPTower = 6;
            int sizeOfETower = 1;
            int directionOfAttack = 0;
            int expected_FinalSizeOfPTower = 7;

            Player player = new Player(winCase_PlayerValues);
            Enemy enemy = new Enemy(winCase_OpponentValues);
            Combat combat = new Combat();
            TowerPlayer pTower = new TowerPlayer(sizeOfPTower);
            TowerEnemy eTower = new TowerEnemy(sizeOfETower);

            combat.Fight(player, enemy, pTower, eTower, directionOfAttack);

            Assert.IsTrue(pTower.tower.Count == expected_FinalSizeOfPTower, "El tama�o final de la torre del jugador no aumento al valor correcto");
            Assert.IsNull(eTower.tower, "La torre aun existe, no ha desaparecido");
        }

        [TestMethod]
        public void PlayerFacesEnemy_EnemyHasGreaterValueThanPlayer_PlayerLoses_PlayerLosesOneLife()
        {
            Assert.IsTrue(0 == 1);
        }
    }
}
