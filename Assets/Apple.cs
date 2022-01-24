using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Apple : MonoBehaviour
{
    public float speed;
    int lives = 3;
    void Start()
    {

    }
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
        if (pos.y < 0.5)
        {
            if (!(GameObject.Find("Basket").transform.position.x - 0.5 < pos.x && pos.x < GameObject.Find("Basket").transform.position.x + 0.5))
            {
                switch (lives)
                {
                    case 3:
                        Destroy(GameObject.Find("Heart1"));
                        break;
                    case 2:
                        Destroy(GameObject.Find("Heart2"));
                        break;
                    case 1:
                        Destroy(GameObject.Find("Heart3"));
                        break;
                }
                lives--;
            }
            pos.y = 3.9F;
            pos.x = Random.Range(-5.5F, 5.5F);
            transform.position = pos;
            if (lives == 0) {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
