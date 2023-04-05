using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class osnova : MonoBehaviour
{
    // Start is called before the first frame update
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
            Instantiate(files[0], mas[x, y]);

        }
        if (plant=="Landish")
        {
            Instantiate(files[1], mas[x, y]);
        }
        if (plant=="Mushmula")
        {
            Instantiate(files[2], mas[x, y]);
        }
        if (plant=="Ogurec")
        {
            Instantiate(files[3], mas[x, y]);
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
