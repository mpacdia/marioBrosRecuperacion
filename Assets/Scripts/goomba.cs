using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    public float goombaSpeed = 1f;

    private void Update()
    {
        gameObject.transform.position = ;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "triggerGoomba")
        {
            goombaSpeed *=  -1;
        }
    }
}
