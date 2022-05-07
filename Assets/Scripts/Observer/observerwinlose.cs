using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres {
    public class observerwinlose : MonoBehaviour, Observer
    {
     public void Updated (GameManager gameManager)
        {
            print("a");
            if(gameManager.enemyCount <= 0)
            {
                gameManager.WinPanel.SetActive(true);
                print("b");
            }
            else if(gameManager.isPlayerAlive == false)
            {
                gameManager.LosePanel.SetActive(true);
                print("c");
            }
        }
    }
}

