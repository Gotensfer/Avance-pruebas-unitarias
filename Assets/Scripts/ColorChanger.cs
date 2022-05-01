using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    SpriteRenderer sp;
    // Start is called before the first frame update
    void Awake()
    {
        sp=GetComponent<SpriteRenderer>();

        sp.material.color = Random.ColorHSV(0f, 1f, 0.5f, 0.7f,0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
