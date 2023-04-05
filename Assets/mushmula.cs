using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushmula : MonoBehaviour
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
        yield return new WaitForSeconds(1.6f);
        int ooo = 1;
        /// проверяем клетки справа от той в которой находимся
        /// ближайшеиу найденному зомби наносим урон
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (transform.parent == o.mas[i, j])
                {
                    if (j!=4)
                    {
                        if (i == 0)
                        {
                            for (int c = 0; c < o.mas[i + 1, j + 1].childCount; c++)
                            {
                                if (
                                    o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                            for (int c = 0; c < o.mas[i, j + 1].childCount; c++)
                            {
                                if (
                                    o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            for (int c = 0; c < o.mas[i - 1, j + 1].childCount; c++)
                            {
                                if (
                                    o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                            for (int c = 0; c < o.mas[i, j + 1].childCount; c++)
                            {
                                if (
                                    o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                        }
                        else
                        {
                            for (int c = 0; c < o.mas[i + 1, j + 1].childCount; c++)
                            {
                                if (
                                     o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                            for (int c = 0; c < o.mas[i, j + 1].childCount; c++)
                            {
                                if (
                                    o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                {
                                    o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                }
                            }
                            for (int c = 0; c < o.mas[i - 1, j + 1].childCount; c++)
                            {
                                {
                                    if (
                                        o.mas[i, j].GetChild(c).gameObject.CompareTag("Enemy"))
                                    {
                                        o.mas[i, j].GetChild(c).GetComponent<HP>().Damage(3);
                                    }
                                }
                            }
                        }
                    }
                    ooo = 0;
                    break;
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
