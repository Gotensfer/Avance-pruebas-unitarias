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
            if (enemyDead == 2) print("Doble kill");
            else if (enemyDead == 3) print("Triple Kill");
            else if (enemyDead == 4) print("Cuadra Kill");
            else if (enemyDead == 5) print("Penta Kill");
        }
    }
}

