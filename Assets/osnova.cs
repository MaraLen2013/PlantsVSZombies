using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class osnova : MonoBehaviour
{
    solnicki sol;
    public Transform[,] mas = new Transform[5, 5];
    int i = 0;
    int j = 0;
    public List<GameObject> files;
   
    private string plant;
    void Start()
    {
        foreach (Transform child in transform)
            {
                if (j == 5)
                {
                    i++;
                    j = 0;
                }
                mas[i, j] = child;
                child.AddComponent<kletki>().init(i,j, this);
                
                j++;
            }
        }
    public void setPlant(int x, int y)
    {
        if (mas[x, y].childCount > 0) return;
        if (plant == "Romashka")
        {
            if (sol.GetCount() >= 20)
            {
                Instantiate(files[0], mas[x, y]);
                sol.moresolnc(-20);
            }
        }
        if (plant=="Landish")
        {
            if (sol.GetCount()>=80)
            {
                Instantiate(files[1], mas[x, y]);
                sol.moresolnc(-80);
            }
            
        }
        if (plant=="Mushmula")
        {
            if (sol.GetCount()>=60)
            {
                Instantiate(files[2], mas[x, y]);
                sol.moresolnc(-60);
            }
        }
        if (plant=="Ogurec")
        {
            if (sol.GetCount() >= 40)
            {
                Instantiate(files[3], mas[x, y]);
                sol.moresolnc(-40);
            }
        }
    }
    public void setplantromashka()
    {
        plant = "Romashka";
    }
    public void setplantlandish()
    {
        plant = "Landish";
    }
    public void setplantmushmula()
    {
        plant = "Mushmula";
    }
    public void setoalntogurec()
    {
        plant = "Ogurec";
    }
}
