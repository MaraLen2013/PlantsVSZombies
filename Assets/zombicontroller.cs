using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zombicontroller : MonoBehaviour
{
    NewBehaviourScript o;
    private int y;
    private int x;
    public float time;
    public int damage;
    public void init(NewBehaviourScript O, int X)
    {
        o = O;
        x = X;
        y = 4;
    }
    
    private void Start()
    {
        StartCoroutine(move());
    }
    IEnumerator move()
    {
        var oo = o.mas;
        for (int i = 0; i < 5; i++)
        {

            HP plant = null;
            foreach (Transform child in oo[x, y])
            {
                if (child.CompareTag("friendplant")) 
                {
                    plant = child.GetComponent<HP>();
                    break;
                }
            }
            if (plant != null) 
            {
                plant.Damage(damage);
                i--;
            }
            else { 
                y = 4 - i;
            
                gameObject.transform.parent = oo[x, y];
                gameObject.transform.localPosition = Vector3.zero;
            }
            yield return new WaitForSeconds(time);
        }
        SceneManager.LoadScene("SampleScene");
    }

    private void OnDestroy()
    {
        o.createnewzombi();
    }
}
