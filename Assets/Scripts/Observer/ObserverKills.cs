using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public class ObserverKills : MonoBehaviour, Observer
    {
        /// <summary>
        /// El GameManager funciona como sujeto concreto
        /// </summary>
        /// 
        

        int enemyDead = 0;

        public void Updated(GameManager gameManager)
        {
            enemyDead += 1;
            if (enemyDead == 2) gameManager.Double_Kill.SetActive(true);
            else if (enemyDead == 3)
            {
                gameManager.Triple_Kill.SetActive(true);
                gameManager.Double_Kill.SetActive(false);
            }
            else if (enemyDead == 4)
            {
                gameManager.Cuadra_Kill.SetActive(true);
                gameManager.Triple_Kill.SetActive(false);
            }
            else if (enemyDead == 5) {
                gameManager.Penta_Kill.SetActive(true);
                gameManager.Cuadra_Kill.SetActive(false);
            }
        }
    }
}

