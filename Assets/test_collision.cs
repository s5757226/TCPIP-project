using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_collision : MonoBehaviour
{
    // Start is called before the first frame update
    public CircleCollider2D circleCollider;
    //CollectHandle collectHandle = new CollectHandle();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (circleCollider.gameObject.CompareTag("Enemy"))
        {

            Debug.Log("test");


        }
    }
}
