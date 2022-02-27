using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Vector3 RandomTarget = new Vector2();
    public Vector3 pos;
    public float speed;
    public bool onWayToTarget;
    public GameObject apple;
    void Start()
    {
        Invoke("Move", 0f);
        Invoke("Spawn", 3f);
    }

    void Update()
    {
        if (RandomTarget.x > transform.position.x && onWayToTarget)
        {
            pos.x += speed * Time.deltaTime;
            if (RandomTarget.x <= pos.x)
                onWayToTarget = false;
            transform.position = pos;
        }
        else if (RandomTarget.x < transform.position.x && onWayToTarget)
        {
            pos.x -= speed * Time.deltaTime;
            if (RandomTarget.x >= pos.x)
                onWayToTarget = false;
            transform.position = pos;
        }
        else
            Invoke("Move", 0f);
    }

    void Move()
    {
        RandomTarget.x = Random.Range(-10, 10);
        pos = transform.position;
        onWayToTarget = true;

    }

    void Spawn()
    {
        Instantiate(apple, transform.position, transform.rotation);
        Invoke("Spawn", 3f);
    }
}