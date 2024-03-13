using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour
{
    public float goombaSpeed = 1f;


    private void Update()
    {
        transform.Translate(goombaSpeed * Vector2.left * Time.deltaTime, Space.World);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "triggerGoomba")
        {
            goombaSpeed *=  -1;
        }
    }

    public void goombaDies()
    {
        Destroy(gameObject);
    }
}
