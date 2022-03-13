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
                Assert.ThrowsException<Exception>(() => new TowerPlayer(failCases_SizeLessThanOneLevels[i]), "Se esperaba que saliera una excepción");
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

                Assert.IsTrue( player.strg >= 1, "El personaje tiene menos de 1 de valor al ser generado");
            }

            //Verificar casos de crear el personaje del jugador con un valor inferior a 1 lo cual
            //no debe ser posible
            for (int i = 0; i < failCases_PlayerCharacterValueLessThanOne.Length; i++)
            {
                Assert.ThrowsException<Exception>(() => new Player(failCases_PlayerCharacterValueLessThanOne[i]), "Se esperaba que saliera una excepción");
            }
        }

        [TestMethod]
        public void PlayerCharacter_IsCurrentlyIn_ALevelOfPlayerTower()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void PlayerFacesEnemy_CharacterWithGreaterValueWins_AndPlayerLoseOnTie()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void PlayerFacesObstacle_InPlayerTower_PlayerAlwaysWins()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void OnFightResolve_WinningPlayerValueGets_LoserPlayerValue()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void PlayerFacesEnemy_PlayerWins_PTowerIncreasesOneLevel_ETowerDecreasesOneLevel()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void PlayerFacesLastRemaniningEnemy_PlayerWins_ETowerLevelIsAddedToPTower_ETowerDisappears()
        {
            Assert.IsTrue(0 == 1);
        }

        [TestMethod]
        public void PlayerFacesEnemy_EnemyHasGreaterValueThanPlayer_PlayerLoses_PlayerLosesOneLife()
        {
            Assert.IsTrue(0 == 1);
        }
    }
}
