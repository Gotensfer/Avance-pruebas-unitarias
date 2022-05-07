using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CacoTorres
{
    public class GameManager : MonoBehaviour, Subject
    {
        public static GameManager instance; // Singleton instance
        public GameObject playerObject;
        public Tower playerTower;
        public Tower enemyTower;
        public GameObject playerTowerLevel;
        public bool isPlayerAlive = true;
        public GameObject WinPanel;
        public GameObject LosePanel;

        [Header("kills")]
        public GameObject Double_Kill;
        public GameObject Triple_Kill;
        public GameObject Cuadra_Kill;
        public GameObject Penta_Kill;

        [SerializeField] List<Observer> observers = new List<Observer>();
        public int enemyCount = 6;
        [SerializeField] ObserverKills observer;
        [SerializeField] observerwinlose Observerwinlose;
        private void Awake()
        {
            // Singleton ---> ?
            Subscribe(observer);
            Subscribe(Observerwinlose);
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
                Notify();
                if (enemyCount <= 0)
                {
                    Notify();
                    Invoke(nameof(RestartGame), 2);
                }
            }
            else
            {
                opponent.CombatVictory(player);
                
                player.CombatDefeat();
                Notify();

                opponent.UpdateStrenghtDisplay();
                
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

        #region Observer
        public void Subscribe(Observer _observer)
        {
            observers.Add(_observer);
        }

        public void Unsubscribe(Observer _observer)
        {
            observers.Remove(_observer);
        }

        public void Notify()
        {
            foreach(var _observer in observers)
            {
                _observer.Updated(this);
            }
        }
        #endregion

        void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}

