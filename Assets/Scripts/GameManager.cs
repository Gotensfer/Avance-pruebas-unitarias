using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CacoTorres
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance; // Singleton instance
        public GameObject playerObject;
        public Tower playerTower;
        public Tower enemyTower;
        public GameObject playerTowerLevel;

        public GameObject WinPanel;
        public GameObject LosePanel;

        public int enemyCount = 6;

        private void Awake()
        {
            // Singleton ---> ?

            instance = this;

            // Singleton < ---
        }

        // Method overload
        void Combat(Player player, Enemy opponent)
        {

            if (player.Strenght > opponent.Strenght)
            {
                player.CombatVictory(opponent);
                opponent.CombatDefeat();

                player.UpdateStrenghtDisplay();

                enemyCount -= 1;

                if (enemyCount <= 0)
                {
                    WinPanel.SetActive(true);
                    Invoke(nameof(RestartGame), 2);
                }
            }
            else
            {
                opponent.CombatVictory(player);
                player.CombatDefeat();

                opponent.UpdateStrenghtDisplay();

                LosePanel.SetActive(true);
                Invoke(nameof(RestartGame), 2);
            }
        }

        // Method overload
        void Combat(Player player, Obstacle obstacle)
        {
            player.CombatVictory(obstacle);
            obstacle.CombatDefeat();

            player.UpdateStrenghtDisplay();
        }

        public void MoveTo(Level levelDestination)
        {
            playerObject.transform.SetParent(levelDestination.arrivingPlayerPosition);
            playerObject.transform.localPosition = new Vector3(0, 0, -0.1f);

            if (levelDestination.storedEntity is Enemy)
            {
                Combat(playerObject.GetComponent<Player>(), levelDestination.storedEntity as Enemy);
            }
            else if (levelDestination.storedEntity is Obstacle)
            {
                Combat(playerObject.GetComponent<Player>(), levelDestination.storedEntity as Obstacle);
            }
        }

        void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}

