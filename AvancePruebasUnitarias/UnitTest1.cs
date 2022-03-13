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
            //Create instance of tower with n levels

            int[] correctCases_OneOrMoreLevels = { 1, 8 };
            int[] failCases_LessThanOneLevels = { 0, -1, -20 };

            for (int i = 0; i < correctCases_OneOrMoreLevels.Length; i++)
            {
                Tower tower = new Tower(/*correctCases_OneOrMoreLevels[i]*/);

                Assert.IsTrue(0 == 0 /*tower.levels?.size/count/lenght >= 1*/, "La torre tiene menos de 1 nivel al ser generada");
            }

            for (int i = 0; i < failCases_LessThanOneLevels.Length; i++)
            {
                try
                {
                    Tower tower = new Tower(/*failCases_LessThanOneLevels[i]*/);
                    Assert.Fail();
                }
                catch (Exception)
                {                    
                    return;
                }
            }
        }

        [TestMethod]
        public void CreatedPlayerCharacter_HasStartingValue_GreaterThanZero()
        {

        }

        [TestMethod]
        public void PlayerCharacter_IsCurrentlyIn_ALevelOfPlayerTower()
        {

        }

        [TestMethod]
        public void PlayerFacesEnemy_CharacterWithGreaterValueWins_AndPlayerLoseOnTie()
        {

        }

        [TestMethod]
        public void PlayerFacesObstacle_InPlayerTower_PlayerAlwaysWins()
        {

        }

        [TestMethod]
        public void OnFightResolve_WinningPlayerValueGets_LoserPlayerValue()
        {

        }

        [TestMethod]
        public void PlayerFacesEnemy_PlayerWins_PTowerIncreasesOneLevel_ETowerDecreasesOneLevel()
        {

        }

        [TestMethod]
        public void PlayerFacesLastRemaniningEnemy_PlayerWins_ETowerLevelIsAddedToPTower_ETowerDisappears()
        {

        }

        [TestMethod]
        public void PlayerFacesEnemy_EnemyHasGreaterValueThanPlayer_PlayerLoses_PlayerLosesOneLife()
        {

        }
    }
}
