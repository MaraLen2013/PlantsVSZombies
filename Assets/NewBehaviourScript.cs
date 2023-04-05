using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform[,] mas = new Transform[5, 5];
    public List<GameObject> files;
    int i = 0;
    int j = 0;
    int x = 0;
    GameObject xxx;
    // Start is called before the first frame update
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
            j++;
        }
        createnewzombi(0);
        createnewzombi(1);
        createnewzombi();
        createnewzombi(3);
        createnewzombi(4);
    }
    int y = 5;
    public void createnewzombi(int x = 2)
    {
        Instantiate(
            files[Random.Range(0, files.Count)]
            , mas[x, 4]).GetComponent<zombicontroller>().init(this, x);
    }

    void Update()
    {

    }
}