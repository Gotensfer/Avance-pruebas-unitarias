using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public class Enemy : Entity
    {
        private void Awake()
        {
            strenght = initialStrenght;
            UpdateStrenghtDisplay();
        }
    }
}

