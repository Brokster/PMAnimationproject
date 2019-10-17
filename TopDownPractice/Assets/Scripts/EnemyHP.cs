using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int Ehealth = 3;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Ehealth--;
        if(Ehealth < 1)
        {
            Destroy(gameObject);
        }
    }
}
