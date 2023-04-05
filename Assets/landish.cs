using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landish : MonoBehaviour
{
    osnova o;
    // Start is called before the first frame update
    void Start()
    {
        o = FindObjectOfType<osnova>();

        StartCoroutine(waitandaction());
    }
    IEnumerator waitandaction()
    {
        yield return new WaitForSeconds(2);
        int ooo = 1;
        /// проверяем клетки справа от той в которой находимся
        /// ближайшеиу найденному зомби наносим урон
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (transform.parent == o.mas[i, j])
                {
                    if (j == 3)
                    {
                        if (i == 0)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                        }
                        else if (i == 4)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                        }
                        else
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                        }
                    }
                    else if (j == 2)
                    {
                        if (i == 0)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i + 1, j + 2, 1);
                        }
                        else if (i == 4)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i - 1, j + 2, 1);
                        }
                        else
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i - 1, j + 2, 1);
                            perebor(i + 1, j + 2, 1);
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i + 1, j + 2, 1);
                            perebor(i, j + 3, 1);
                            perebor(i + 1, j + 3, 1);
                        }
                        else if (i == 4)
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i - 1, j + 2, 1);
                            perebor(i, j + 3, 1);
                            perebor(i - 1, j + 3, 1);
                        }
                        else
                        {
                            perebor(i, j + 1, 1);
                            perebor(i - 1, j + 1, 1);
                            perebor(i + 1, j + 1, 1);
                            perebor(i, j + 2, 2);
                            perebor(i - 1, j + 2, 1);
                            perebor(i + 1, j + 2, 1);
                            perebor(i, j + 3, 1);
                            perebor(i - 1, j + 3, 1);
                            perebor(i + 1, j + 3, 1);
                        }
                    }

                }
                if (ooo == 0)
                {
                    break;
                }
            }
            StartCoroutine(waitandaction());
        }
    }
    public void perebor(int i, int j, int dam)
    {
        for (int c = 0; c < o.mas[i, j].childCount; c++)
        {
            if (
                o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
            {
                o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(dam);
            }
        }
    }
}
