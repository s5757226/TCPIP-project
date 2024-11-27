using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CollectHandle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("enter");
        Destroy(collision.gameObject);
        transform.localScale = transform.localScale+(collision.gameObject.transform.localScale/10);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit");
    }
}
