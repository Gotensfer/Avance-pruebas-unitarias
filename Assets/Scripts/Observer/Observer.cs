using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CacoTorres
{
    public interface Observer
    {
        void Updated(GameManager gameManager);
    }
}

