using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float speed;
    public GameObject emptyObject;
    Vector3 position;
    void Update()
    {
        position = transform.position;
        position.y -= speed * Time.deltaTime;
        transform.position = position;
        if (transform.position.y < -6)
        {
            Destroy(transform.gameObject);
            emptyObject.GetComponent<Game>().minuslife();
        }
    }
}
