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

            //Verificar casos de tener torres con al menos 1 nivel
            for (int i = 0; i < correctCases_SizeOneOrMoreLevels.Length; i++)
            {
                Tower tower = new Tower(correctCases_SizeOneOrMoreLevels[i]);

                Assert.IsTrue(tower.tower.Count >= 1, "La torre tiene menos de 1 nivel al ser generada");
            }

            //Verificar casos de tener torres con menos de 1 nivel
            for (int i = 0; i < failCases_SizeLessThanOneLevels.Length; i++)
            {
                Assert.ThrowsException<Exception>(() => new Tower(failCases_SizeLessThanOneLevels[i]), "Se esperaba que saliera una excepción");
            }
        }

        [TestMethod]
        public void CreatedPlayerCharacter_HasStartingValue_GreaterThanZero()
        {
            Assert.IsTrue(0 == 1);
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
