using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private object basket;
    void Start()
    {
        basket = GetComponent<Basket>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Vector3 pos = transform.position;
            pos.x -= 1.5F;
            transform.position = pos;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Vector3 pos = transform.position;
            pos.x += 1.5F;
            transform.position = pos;
        }
    }
}
