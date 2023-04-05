using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kletki : MonoBehaviour
{
    private int x;
    private int y;
    osnova o;
    public void init(int X, int Y, osnova O)
    {
        x = X;
        y = Y;
        o = O;

        GetComponent<Button>().onClick.AddListener( () =>
        {
            O.setPlant(x, y);
        });
    }
}
