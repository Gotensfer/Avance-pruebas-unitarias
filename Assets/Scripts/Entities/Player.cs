using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public class Player : Entity
    {
        private void Awake()
        {
            strenght = initialStrenght;
            UpdateStrenghtDisplay();
        }

        public override void CombatVictory(Entity opponent)
        {
            strenght += opponent.Strenght;
        }

        public override void CombatDefeat()
        {
            GameManager.instance.isPlayerAlive = false;
            Destroy(this.gameObject);
        }
    }
}

