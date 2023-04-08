using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avtopoav : MonoBehaviour
{
    solnicki o;
    void Start()
    {
        o = FindObjectOfType<solnicki>();
    }
    public void OnClick()
    {
        o.moresolnc(25);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
