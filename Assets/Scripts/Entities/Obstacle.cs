using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public class Obstacle : Entity
    {
        private void Awake()
        {
            strenght = initialStrenght;
            UpdateStrenghtDisplay();
        }
    }
}

