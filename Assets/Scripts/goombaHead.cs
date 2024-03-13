using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombaHead : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mario")
        {

        }
    }
}
