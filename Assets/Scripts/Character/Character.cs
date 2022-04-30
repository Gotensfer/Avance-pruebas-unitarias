using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public int str;

    public int GenerateStrg()
    {
        int force = Random.Range(str, 5);           //Esta con random porque no se como lo vamos a manejar
        str = force;
        return str;
    }
}
