using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP2 : MonoBehaviour
{
    public int lifes = 3;

    public void Damage(int d)
    {
        lifes -= d;
        if (lifes <= 0)
        {
            Destroy(gameObject);
        }
    }
}
