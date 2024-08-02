using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida = 5;

    public void BajarVida()
    {
        vida = vida - 1;
        if (vida == 0)
        {
            Destroy(gameObject);
        }

    }
}
