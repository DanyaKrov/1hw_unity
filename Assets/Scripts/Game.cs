using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static int lives;
    void Start()
    {
        lives = 3;
    }
    public void minuslife()
    {
        if (lives > 0)
        {
            if (lives == 3)
                Destroy(GameObject.Find("Heart3"));
            if (lives == 2)
                Destroy(GameObject.Find("Heart2"));
            if (lives == 1)
                Destroy(GameObject.Find("Heart1"));
            lives--;
        }
        if (lives == 0)
            SceneManager.LoadScene("SampleScene");
    }
}
