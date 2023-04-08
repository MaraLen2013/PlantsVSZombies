using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform[,] mas = new Transform[5, 10];
    public List<GameObject> files;
    int i = 0;
    int j = 0;
    int x;
    GameObject xxx;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (j == 10)
            {
                i++;
                j = 0;
            }
            mas[i, j] = child;
            j++;
        }

        Invoke("createnewzombi", 30);
    }
    int y = 10;
    public void createnewzombi()
    {
        x = Random.Range(0, 5);
        Instantiate(
            files[Random.Range(0, files.Count)]
            , mas[x, 9]).GetComponent<zombicontroller>().init(this, x);
    }

    void Update()
    {

    }
}