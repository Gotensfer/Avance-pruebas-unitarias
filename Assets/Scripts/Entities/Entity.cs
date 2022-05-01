using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace CacoTorres
{
    public abstract class Entity : MonoBehaviour
    {
        [SerializeField] protected int initialStrenght;
        [SerializeField] protected TextMeshProUGUI displayStrenght;

        protected int strenght;
        public int Strenght { get => strenght; set => strenght = value; }

        public void UpdateStrenghtDisplay()
        {
            displayStrenght.text = strenght.ToString();
        }

        public virtual void CombatVictory(Entity opponent)
        {
            strenght += opponent.Strenght;
        }

        public virtual void CombatDefeat()
        {
            Destroy(this.gameObject);
        }
    }
}

