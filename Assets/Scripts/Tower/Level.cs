using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CacoTorres
{
    public class Level : MonoBehaviour
    {
        public Entity storedEntity;
        public Transform arrivingPlayerPosition;
        public Button asociatedMoveToButton;
        public int positionIndex;

        public void MoveOnThisLevel()
        {
            GameManager.instance.MoveTo(this);
            transform.GetComponentInParent<Tower>().HideFar_MoveToButtons(this);
            transform.GetComponentInParent<Tower>().ShowNear_MoveToButtons(this);
            transform.GetComponentInParent<Tower>().RemoveNear_EmptyEnemyLevels(this);
        }
    }
}