using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solnicki : MonoBehaviour
{
    osnova o;
    public GameObject sonce;
    public int coln = 0;
    public int GetCount()
    {
        return coln;
    }
    public void moresolnc(int x)
    {
        coln += x;
    }
    private void Start()
    {
        o = FindObjectOfType<osnova>();
        StartCoroutine(move());
    }
    IEnumerator move()
    {
        while (true)
        {
            yield return new WaitForSeconds(15);
            int x = Random.Range(0, 5);
            int y = Random.Range(0, 10);
            Destroy(Instantiate(sonce, o.mas[x, y]), 10);
        }
    }
}
