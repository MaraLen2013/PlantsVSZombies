using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int lifes;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Damage(int x)
    {
        lifes -= x;
        if (lifes<=0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
