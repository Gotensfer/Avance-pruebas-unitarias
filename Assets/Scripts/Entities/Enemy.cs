using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public enum EnemyType
    {
        Normal,
        Muerto,
        Jefe
    }

    public class Enemy : Entity
    {
        private void Awake()
        {
            strenght = initialStrenght;
            UpdateStrenghtDisplay();
        }
    }
}

