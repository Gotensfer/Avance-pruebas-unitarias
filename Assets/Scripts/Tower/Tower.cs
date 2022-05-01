using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public class Tower : MonoBehaviour
    {
        public List<Level> levels;

        public void HideFar_MoveToButtons(Level pivot)
        {
            if (Equals(gameObject.name, "Enemy Tower"))
            {
                for (int i = pivot.positionIndex + 2; i < levels.Count; i++)
                {
                    levels[i].asociatedMoveToButton.gameObject.SetActive(false);
                }

                for (int i = pivot.positionIndex - 2; i >= 0; i--)
                {
                    levels[i].asociatedMoveToButton.gameObject.SetActive(false);
                }
            }

            levels[pivot.positionIndex].asociatedMoveToButton.gameObject.SetActive(false);
        }

        public void ShowNear_MoveToButtons(Level pivot)
        {
            if (Equals(gameObject.name, "Enemy Tower"))
            {
                for (int i = pivot.positionIndex + 1; i < pivot.positionIndex + 2 && i < levels.Count; i++)
                {
                    levels[i].asociatedMoveToButton.gameObject.SetActive(true);
                }

                for (int i = pivot.positionIndex - 1; i > pivot.positionIndex - 2 && i >= 0; i--)
                {
                    levels[i].asociatedMoveToButton.gameObject.SetActive(true);
                }
            }
        }

        public void RemoveNear_EmptyEnemyLevels(Level pivot)
        {
            if (Equals(gameObject.name, "Enemy Tower"))
            {
                for (int i = pivot.positionIndex; i < pivot.positionIndex + 2 && i < levels.Count; i++)
                {
                    // Remover el nivel si no hay entidades
                    if (levels[i].storedEntity == null)
                    {
                        ReOrderTowerFromRemovedLevel(i);
                        Destroy(levels[i].gameObject);
                        levels.RemoveAt(i);

                        // Agregar a la torre del jugador un nivel
                        Vector3 pivotPosition = GameManager.instance.playerTower.levels[GameManager.instance.playerTower.levels.Count - 1].transform.localPosition;
                        GameObject newPlayerLevel = Instantiate(GameManager.instance.playerTowerLevel, Vector3.zero, Quaternion.identity, GameManager.instance.playerTower.transform);
                        newPlayerLevel.transform.localPosition = new Vector3(0, pivotPosition.y + 0.5f, 0);
                        GameManager.instance.playerTower.levels.Add(newPlayerLevel.GetComponent<Level>());
                    }
                }

                for (int i = pivot.positionIndex; i > pivot.positionIndex - 2 && i >= 0; i--)
                {
                    // Remover el nivel si no hay entidades
                    if (levels[i].storedEntity == null)
                    {
                        ReOrderTowerFromRemovedLevel(i);
                        Destroy(levels[i].gameObject);
                        levels.RemoveAt(i);

                        // Agregar a la torre del jugador un nivel
                        Vector3 pivotPosition = GameManager.instance.playerTower.levels[GameManager.instance.playerTower.levels.Count - 1].transform.localPosition;
                        GameObject newPlayerLevel = Instantiate(GameManager.instance.playerTowerLevel, Vector3.zero, Quaternion.identity, GameManager.instance.playerTower.transform);
                        newPlayerLevel.transform.localPosition = new Vector3( 0, pivotPosition.y + 0.5f, 0);
                        GameManager.instance.playerTower.levels.Add(newPlayerLevel.GetComponent<Level>());
                    }
                }

                ShowNear_MoveToButtons(pivot);
                HideFar_MoveToButtons(pivot);
            }
        }

        void ReOrderTowerFromRemovedLevel(int pivot)
        {
            for (int i = 0; i < levels.Count; i++)
            {
                if (i > pivot)
                {
                    levels[i].gameObject.transform.Translate(new Vector3(0, -0.5f, 0), Space.Self);
                    levels[i].positionIndex -= 1;
                }          
            }
        }
    }
}

