using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class romashka : MonoBehaviour
{
    solnicki sol;
    IEnumerator move()
    {
        yield return new WaitForSeconds(2);
        sol.moresolnc(25);
    }
}
